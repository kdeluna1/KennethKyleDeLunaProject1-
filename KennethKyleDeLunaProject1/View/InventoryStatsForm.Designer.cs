namespace KennethKyleDeLunaProject1.View
{
    partial class InventoryStatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mostExpensiveTextBox = new TextBox();
            leastExpensiveTextBox = new TextBox();
            bestMPGTextBox = new TextBox();
            worstMPGTextBox = new TextBox();
            inventoryLabel = new Label();
            inventoryListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Most Expensive:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 127);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Least Expensive:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 224);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Best MPG:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 322);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Worst MPG:";
            // 
            // mostExpensiveTextBox
            // 
            mostExpensiveTextBox.Location = new Point(43, 59);
            mostExpensiveTextBox.Name = "mostExpensiveTextBox";
            mostExpensiveTextBox.ReadOnly = true;
            mostExpensiveTextBox.Size = new Size(216, 23);
            mostExpensiveTextBox.TabIndex = 4;
            // 
            // leastExpensiveTextBox
            // 
            leastExpensiveTextBox.Location = new Point(43, 145);
            leastExpensiveTextBox.Name = "leastExpensiveTextBox";
            leastExpensiveTextBox.ReadOnly = true;
            leastExpensiveTextBox.Size = new Size(216, 23);
            leastExpensiveTextBox.TabIndex = 5;
            // 
            // bestMPGTextBox
            // 
            bestMPGTextBox.Location = new Point(43, 242);
            bestMPGTextBox.Name = "bestMPGTextBox";
            bestMPGTextBox.ReadOnly = true;
            bestMPGTextBox.Size = new Size(216, 23);
            bestMPGTextBox.TabIndex = 6;
            // 
            // worstMPGTextBox
            // 
            worstMPGTextBox.Location = new Point(43, 340);
            worstMPGTextBox.Name = "worstMPGTextBox";
            worstMPGTextBox.ReadOnly = true;
            worstMPGTextBox.Size = new Size(216, 23);
            worstMPGTextBox.TabIndex = 7;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(299, 41);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(60, 15);
            inventoryLabel.TabIndex = 8;
            inventoryLabel.Text = "Inventory:";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.Location = new Point(299, 59);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(291, 304);
            inventoryListBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(244, 417);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 10;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InventoryStatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 553);
            Controls.Add(button1);
            Controls.Add(inventoryListBox);
            Controls.Add(inventoryLabel);
            Controls.Add(worstMPGTextBox);
            Controls.Add(bestMPGTextBox);
            Controls.Add(leastExpensiveTextBox);
            Controls.Add(mostExpensiveTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InventoryStatsForm";
            Text = "InventoryStatsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mostExpensiveTextBox;
        private TextBox leastExpensiveTextBox;
        private TextBox bestMPGTextBox;
        private TextBox worstMPGTextBox;
        private Label inventoryLabel;
        private ListBox inventoryListBox;
        private Button button1;
    }
}