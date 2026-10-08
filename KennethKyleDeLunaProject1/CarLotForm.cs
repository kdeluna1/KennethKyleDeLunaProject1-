using KennethKyleDeLunaProject1.Forms;
using KennethKyleDeLunaProject1.Model;
using KennethKyleDeLunaProject1.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KennethKyleDeLunaProject1
{
    public partial class CarLotForm : Form
    {
        private CarLot carLot;
        private List<Car> displayedCars;
        private Shopper? shopper;

        /// <summary>
        /// Initializes the main Car Lot Form
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();

            carLot = new CarLot();
            displayedCars = new List<Car>();
            ShowInventory();
        }

        private void ShowInventory()
        {
            displayedCars = carLot.LotInventory;
            inventoryListBox.Items.Clear();
            foreach (Car car in carLot.LotInventory)
            {
                inventoryListBox.Items.Add($"{car.Make} {car.Model} {car.Price:C} {car.Mpg}");
            }
        }

        private void shopperButton_Click(object sender, EventArgs e)
        {
            using (var shopperForm = new ShopperForm())
            {
                if (shopperForm.ShowDialog() == DialogResult.OK)
                {
                    shopper = shopperForm.Shopper;

                    nameTextBox.Text = shopper?.Name ?? string.Empty;
                    moneyTextBox.Text = shopper?.MoneyAvailable.ToString("C") ?? string.Empty;
                }
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            if (shopper == null)
            {
                MessageBox.Show("Please create a shopper first.");
                return;
            }

            if (inventoryListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a car to purchase.");
                return;
            }

            if (inventoryListBox.SelectedIndex != -1)
            {
                Car selectedCar = displayedCars[inventoryListBox.SelectedIndex];
                if (shopper.CanPurchase(selectedCar.Price))
                {
                    carLot.PurchaseCar(selectedCar.Make, selectedCar.Model);
                    shopper.PurchaseCar(selectedCar, carLot.GetTotalCostOfPurchase(selectedCar));
                    moneyTextBox.Text = $"{shopper.MoneyAvailable:C}";
                    ShowInventory();
                    purchasesListBox.Items.Clear();
                    foreach (Car car in shopper.PurchasedCars())
                    {
                        purchasesListBox.Items.Add($"{car.Make} {car.Model} {car.Price:C} {car.Mpg}");
                    }
                    selectedCarTextBox.Text = string.Empty;
                    MessageBox.Show($"Congratulations! You are now the owner of the {selectedCar.Make} {selectedCar.Model}");
                }
                else
                {
                    MessageBox.Show($"Sorry, you do not have sufficient funds to purchase this {selectedCar.Make} {selectedCar.Model}");
                }
            }

        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var addCarForm = new AddCarForm())
            {
                if (addCarForm.ShowDialog() == DialogResult.OK)
                {
                    Car? newCar = addCarForm.car;
                    if (newCar != null)
                    {
                        carLot.AddCar(newCar.Make, newCar.Model, newCar.Price, newCar.Mpg);
                        ShowInventory();
                    }
                }
            }
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex == -1)
            {
                selectedCarTextBox.Text = string.Empty;
            }
            else
            {
                selectedCarTextBox.Text = inventoryListBox?.SelectedItem?.ToString();
            }
        }

        private void inventoryStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryStatsForm = new InventoryStatsForm();
            inventoryStatsForm.Show();
        }

        private void filterByMakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string make = Microsoft.VisualBasic.Interaction.InputBox("Enter the make of the car:", "Filter By Make");

            if (string.IsNullOrWhiteSpace(make))
            {
                return;
            }

            List<Car> cars = carLot.FindCarsByMake(make);

            if (cars == null || cars.Count() == 0)
            {
                MessageBox.Show($"No cars were found of the make {make}.", "No Cars Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            displayedCars = cars;
            inventoryListBox.Items.Clear();
            foreach (Car car in cars)
            {
                inventoryListBox.Items.Add($"{car.Make} {car.Model} {car.Price:C} {car.Mpg}");
            }

        }

        private void showAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();
            ShowInventory();
        }
    }
}
