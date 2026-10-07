using KennethKyleDeLunaProject1.Model;

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
    }
}
