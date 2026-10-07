using KennethKyleDeLunaProject1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KennethKyleDeLunaProject1.Forms
{
    public partial class AddCarForm : Form
    {
        /// <summary>
        /// The car to be added
        /// </summary>
        public Car? car { get; private set; }

        /// <summary>
        /// Initializes the form to add a car
        /// </summary>
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(makeTextBox.Text) || string.IsNullOrWhiteSpace(modelTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text) || string.IsNullOrWhiteSpace(mpgTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(priceTextBox.Text, out decimal price) || !decimal.TryParse(mpgTextBox.Text, out decimal mpg))
            {
                MessageBox.Show("Please enter valid numeric values for price and MPG.");
                return;
            }
            else
            {
                car = new Car(makeTextBox.Text, modelTextBox.Text, price, mpg);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
