namespace Pharmacy_Management_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddMedicineButton = new System.Windows.Forms.Button();
            this.MedicineNameBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.ExpireDateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDShowBox = new System.Windows.Forms.TextBox();
            this.NameShowLabel = new System.Windows.Forms.Label();
            this.ExpireDateShowLabel = new System.Windows.Forms.Label();
            this.QuantityShowLabel = new System.Windows.Forms.Label();
            this.ManufacturerCompanyShow = new System.Windows.Forms.Label();
            this.ShowMedicine = new System.Windows.Forms.Button();
            this.MedicineIDShowLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SellMedicineIDBox = new System.Windows.Forms.TextBox();
            this.SellMedicine = new System.Windows.Forms.Button();
            this.ShowPriceLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.QuantitySellBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manufacturer Company:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expire Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(280, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicine  History";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddMedicineButton
            // 
            this.AddMedicineButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddMedicineButton.Location = new System.Drawing.Point(284, 421);
            this.AddMedicineButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddMedicineButton.Name = "AddMedicineButton";
            this.AddMedicineButton.Size = new System.Drawing.Size(164, 43);
            this.AddMedicineButton.TabIndex = 5;
            this.AddMedicineButton.Text = "Add Medicine";
            this.AddMedicineButton.UseVisualStyleBackColor = false;
            this.AddMedicineButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MedicineNameBox
            // 
            this.MedicineNameBox.Location = new System.Drawing.Point(251, 121);
            this.MedicineNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedicineNameBox.Name = "MedicineNameBox";
            this.MedicineNameBox.Size = new System.Drawing.Size(219, 28);
            this.MedicineNameBox.TabIndex = 6;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(251, 232);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(219, 28);
            this.QuantityBox.TabIndex = 7;
            // 
            // CompanyBox
            // 
            this.CompanyBox.Location = new System.Drawing.Point(251, 180);
            this.CompanyBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(219, 28);
            this.CompanyBox.TabIndex = 8;
            // 
            // ExpireDateBox
            // 
            this.ExpireDateBox.Location = new System.Drawing.Point(251, 295);
            this.ExpireDateBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpireDateBox.Name = "ExpireDateBox";
            this.ExpireDateBox.Size = new System.Drawing.Size(219, 28);
            this.ExpireDateBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medicine ID:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(251, 70);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(219, 28);
            this.IDBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medicine ID:";
            // 
            // IDShowBox
            // 
            this.IDShowBox.Location = new System.Drawing.Point(913, 30);
            this.IDShowBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDShowBox.Name = "IDShowBox";
            this.IDShowBox.Size = new System.Drawing.Size(219, 28);
            this.IDShowBox.TabIndex = 14;
            // 
            // NameShowLabel
            // 
            this.NameShowLabel.AutoSize = true;
            this.NameShowLabel.Location = new System.Drawing.Point(957, 134);
            this.NameShowLabel.Name = "NameShowLabel";
            this.NameShowLabel.Size = new System.Drawing.Size(0, 22);
            this.NameShowLabel.TabIndex = 19;
            // 
            // ExpireDateShowLabel
            // 
            this.ExpireDateShowLabel.AutoSize = true;
            this.ExpireDateShowLabel.Location = new System.Drawing.Point(957, 301);
            this.ExpireDateShowLabel.Name = "ExpireDateShowLabel";
            this.ExpireDateShowLabel.Size = new System.Drawing.Size(0, 22);
            this.ExpireDateShowLabel.TabIndex = 20;
            // 
            // QuantityShowLabel
            // 
            this.QuantityShowLabel.AutoSize = true;
            this.QuantityShowLabel.Location = new System.Drawing.Point(957, 236);
            this.QuantityShowLabel.Name = "QuantityShowLabel";
            this.QuantityShowLabel.Size = new System.Drawing.Size(0, 22);
            this.QuantityShowLabel.TabIndex = 21;
            this.QuantityShowLabel.Click += new System.EventHandler(this.QuantityShowLabel_Click);
            // 
            // ManufacturerCompanyShow
            // 
            this.ManufacturerCompanyShow.AutoSize = true;
            this.ManufacturerCompanyShow.Location = new System.Drawing.Point(957, 187);
            this.ManufacturerCompanyShow.Name = "ManufacturerCompanyShow";
            this.ManufacturerCompanyShow.Size = new System.Drawing.Size(0, 22);
            this.ManufacturerCompanyShow.TabIndex = 22;
            // 
            // ShowMedicine
            // 
            this.ShowMedicine.BackColor = System.Drawing.Color.Peru;
            this.ShowMedicine.Location = new System.Drawing.Point(1179, 30);
            this.ShowMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowMedicine.Name = "ShowMedicine";
            this.ShowMedicine.Size = new System.Drawing.Size(148, 35);
            this.ShowMedicine.TabIndex = 23;
            this.ShowMedicine.Text = "Show Medicine";
            this.ShowMedicine.UseVisualStyleBackColor = false;
            this.ShowMedicine.Click += new System.EventHandler(this.ShowMedicine_Click);
            // 
            // MedicineIDShowLabel
            // 
            this.MedicineIDShowLabel.AutoSize = true;
            this.MedicineIDShowLabel.Location = new System.Drawing.Point(957, 98);
            this.MedicineIDShowLabel.Name = "MedicineIDShowLabel";
            this.MedicineIDShowLabel.Size = new System.Drawing.Size(0, 22);
            this.MedicineIDShowLabel.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(302, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sell Medicine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Medicine ID:";
            // 
            // SellMedicineIDBox
            // 
            this.SellMedicineIDBox.Location = new System.Drawing.Point(251, 561);
            this.SellMedicineIDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellMedicineIDBox.Name = "SellMedicineIDBox";
            this.SellMedicineIDBox.Size = new System.Drawing.Size(219, 28);
            this.SellMedicineIDBox.TabIndex = 28;
            // 
            // SellMedicine
            // 
            this.SellMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SellMedicine.Location = new System.Drawing.Point(328, 702);
            this.SellMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SellMedicine.Name = "SellMedicine";
            this.SellMedicine.Size = new System.Drawing.Size(87, 31);
            this.SellMedicine.TabIndex = 32;
            this.SellMedicine.Text = "Sell";
            this.SellMedicine.UseVisualStyleBackColor = false;
            this.SellMedicine.Click += new System.EventHandler(this.SellMedicine_Click);
            // 
            // ShowPriceLabel
            // 
            this.ShowPriceLabel.AutoSize = true;
            this.ShowPriceLabel.Location = new System.Drawing.Point(957, 338);
            this.ShowPriceLabel.Name = "ShowPriceLabel";
            this.ShowPriceLabel.Size = new System.Drawing.Size(0, 22);
            this.ShowPriceLabel.TabIndex = 34;
            this.ShowPriceLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(251, 355);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(219, 28);
            this.PriceBox.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 641);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "Quantity:";
            // 
            // QuantitySellBox
            // 
            this.QuantitySellBox.Location = new System.Drawing.Point(251, 641);
            this.QuantitySellBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantitySellBox.Name = "QuantitySellBox";
            this.QuantitySellBox.Size = new System.Drawing.Size(219, 28);
            this.QuantitySellBox.TabIndex = 38;
            this.QuantitySellBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 924);
            this.Controls.Add(this.QuantitySellBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ShowPriceLabel);
            this.Controls.Add(this.SellMedicine);
            this.Controls.Add(this.SellMedicineIDBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MedicineIDShowLabel);
            this.Controls.Add(this.ShowMedicine);
            this.Controls.Add(this.ManufacturerCompanyShow);
            this.Controls.Add(this.QuantityShowLabel);
            this.Controls.Add(this.ExpireDateShowLabel);
            this.Controls.Add(this.NameShowLabel);
            this.Controls.Add(this.IDShowBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ExpireDateBox);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.MedicineNameBox);
            this.Controls.Add(this.AddMedicineButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddMedicineButton;
        private System.Windows.Forms.TextBox MedicineNameBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.TextBox ExpireDateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDShowBox;
        private System.Windows.Forms.Label NameShowLabel;
        private System.Windows.Forms.Label ExpireDateShowLabel;
        private System.Windows.Forms.Label QuantityShowLabel;
        private System.Windows.Forms.Label ManufacturerCompanyShow;
        private System.Windows.Forms.Button ShowMedicine;
        private System.Windows.Forms.Label MedicineIDShowLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SellMedicineIDBox;
        private System.Windows.Forms.Button SellMedicine;
        private System.Windows.Forms.Label ShowPriceLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox QuantitySellBox;
    }
}

