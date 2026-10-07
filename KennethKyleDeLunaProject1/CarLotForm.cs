using KennethKyleDeLunaProject1.Forms;
using KennethKyleDeLunaProject1.Model;
using KennethKyleDeLunaProject1.View;

namespace KennethKyleDeLunaProject1
{
    public partial class CarLotForm : Form
    {
        private CarLot carlot;
        private Shopper? shopper;
        public CarLotForm()
        {
            InitializeComponent();

            carlot = new CarLot();
            ShowInventory();
        }

        private void ShowInventory()
        {
            inventoryListBox.Items.Clear();
            foreach (Car car in carlot.LotInventory)
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
                Car selectedCar = carlot.LotInventory[inventoryListBox.SelectedIndex];
                if (shopper.CanPurchase(selectedCar.Price)){
                    carlot.PurchaseCar(selectedCar.Make, selectedCar.Model);
                    shopper.MoneyAvailable -= selectedCar.Price;
                    moneyTextBox.Text = $"{shopper.MoneyAvailable:C}";
                    ShowInventory();
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
                        carlot.AddCar(newCar.Make, newCar.Model, newCar.Price, newCar.Mpg);
                        ShowInventory();
                    }
                }
            }
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (inventoryListBox.SelectedIndex == -1)
            {
                selectedCarTextBox.Text = string.Empty;
            } else
            {
                selectedCarTextBox.Text = inventoryListBox?.SelectedItem?.ToString();
            }
        }
    }
}
