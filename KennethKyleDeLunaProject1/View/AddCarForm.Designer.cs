namespace KennethKyleDeLunaProject1.Forms
{
    partial class AddCarForm
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
            addButton = new Button();
            cancelButton = new Button();
            label5 = new Label();
            mpgTextBox = new TextBox();
            priceTextBox = new TextBox();
            modelTextBox = new TextBox();
            makeTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(41, 242);
            addButton.Name = "addButton";
            addButton.Size = new Size(92, 22);
            addButton.TabIndex = 22;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(158, 242);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(92, 22);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 60);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 20;
            label5.Text = "Add Car To Inventory";
            // 
            // mpgTextBox
            // 
            mpgTextBox.Location = new Point(84, 192);
            mpgTextBox.Name = "mpgTextBox";
            mpgTextBox.Size = new Size(179, 23);
            mpgTextBox.TabIndex = 19;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(84, 163);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(179, 23);
            priceTextBox.TabIndex = 18;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(84, 134);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(179, 23);
            modelTextBox.TabIndex = 17;
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(84, 105);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(179, 23);
            makeTextBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 195);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 15;
            label4.Text = "MPG:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 166);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 137);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 13;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 108);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Make:";
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 335);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(label5);
            Controls.Add(mpgTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(makeTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCarForm";
            Text = "Add Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button cancelButton;
        private Label label5;
        private TextBox mpgTextBox;
        private TextBox priceTextBox;
        private TextBox modelTextBox;
        private TextBox makeTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}