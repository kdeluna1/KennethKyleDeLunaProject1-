using KennethKyleDeLunaProject1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KennethKyleDeLunaProject1.View
{
    public partial class ShopperForm : Form
    {
        public Shopper? Shopper { get; private set; }
        public ShopperForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both name and money.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal money))
            {
                MessageBox.Show("Please enter a valid amount of money.");
                return;
            }

            Shopper = new Shopper(textBox1.Text, money);

            DialogResult = DialogResult.OK;
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
