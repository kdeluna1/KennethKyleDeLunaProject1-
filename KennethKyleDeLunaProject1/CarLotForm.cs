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

                    nameTextBox.Text = shopper.Name;
                    moneyTextBox.Text = shopper.MoneyAvailable.ToString("C");
                }
            }
        }
    }
}
