using KennethKyleDeLunaProject1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KennethKyleDeLunaProject1.View
{

    public partial class InventoryStatsForm : Form
    {
        private CarLot carLot;
        public InventoryStatsForm()
        {
            InitializeComponent();
            carLot = new CarLot();
            ShowInventoryStats();
        }

        private void ShowInventoryStats()
        {
            inventoryListBox.Items.Clear();
            inventoryLabel.Text = $"Inventory of {carLot.Count} cars.";
            foreach (Car car in carLot.LotInventory)
            {
                inventoryListBox.Items.Add($"{car.Make} {car.Model} {car.Price:C} {car.Mpg}");
            }

            Car? mostExpensive = carLot.FindMostExpensiveCar();
            Car? leastExpensive = carLot.FindLeastExpensiveCar();
            Car? bestMPG = carLot.FindBestMpgCar();
            Car? worstMPG = carLot.FindWorstMPG();

            mostExpensiveTextBox.Text = $"{mostExpensive?.Make} {mostExpensive?.Model} {mostExpensive?.Price:C} {mostExpensive?.Mpg}";

            leastExpensiveTextBox.Text = $"{leastExpensive?.Make} {leastExpensive?.Model} {leastExpensive?.Price:C} {leastExpensive?.Mpg}";

            bestMPGTextBox.Text = $"{bestMPG?.Make} {bestMPG?.Model} {bestMPG?.Price:C} {bestMPG?.Mpg}";

            worstMPGTextBox.Text = $"{worstMPG?.Make} {worstMPG?.Model} {worstMPG?.Price:C} {worstMPG?.Mpg}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
