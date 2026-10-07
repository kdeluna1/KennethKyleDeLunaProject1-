namespace KennethKyleDeLunaProject1
{
    partial class CarLotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inventoryListBox = new ListBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            iToolStripMenuItem = new ToolStripMenuItem();
            addCarToolStripMenuItem = new ToolStripMenuItem();
            shopperButton = new Button();
            label2 = new Label();
            nameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            moneyTextBox = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.Location = new Point(287, 64);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(375, 259);
            inventoryListBox.TabIndex = 0;
            inventoryListBox.Text = "Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 46);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // iToolStripMenuItem
            // 
            iToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCarToolStripMenuItem });
            iToolStripMenuItem.Name = "iToolStripMenuItem";
            iToolStripMenuItem.Size = new Size(69, 20);
            iToolStripMenuItem.Text = "Inventory";
            // 
            // addCarToolStripMenuItem
            // 
            addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            addCarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            addCarToolStripMenuItem.Size = new Size(155, 22);
            addCarToolStripMenuItem.Text = "Add Car";
            // 
            // shopperButton
            // 
            shopperButton.Location = new Point(110, 192);
            shopperButton.Name = "shopperButton";
            shopperButton.Size = new Size(92, 23);
            shopperButton.TabIndex = 3;
            shopperButton.Text = "Set Shopper";
            shopperButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 46);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 5;
            label2.Text = "Shopper Details";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(84, 98);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(178, 23);
            nameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 98);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 144);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 8;
            label4.Text = "Money:";
            // 
            // moneyTextBox
            // 
            moneyTextBox.Location = new Point(84, 141);
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(178, 23);
            moneyTextBox.TabIndex = 9;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moneyTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(shopperButton);
            Controls.Add(label1);
            Controls.Add(inventoryListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CarLotForm";
            Text = "Car Sale Inventory";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox inventoryListBox;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iToolStripMenuItem;
        private ToolStripMenuItem addCarToolStripMenuItem;
        private Button shopperButton;
        private Label label2;
        private TextBox nameTextBox;
        private Label label3;
        private Label label4;
        private TextBox moneyTextBox;
    }
}
