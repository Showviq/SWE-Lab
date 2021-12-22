using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form

    {
        List<Medicine> medicine = new List<Medicine>();
        
       


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDBox.Text);
            string Name = MedicineNameBox.Text;
            string Company = CompanyBox.Text;
            int Quantity = Convert.ToInt32(QuantityBox.Text);
            string ExpireDate = ExpireDateBox.Text;
            int Price = Convert.ToInt32(PriceBox.Text); ;

            if (Quantity < 0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            Medicine dummy = new Medicine(ID, Name, Company, Quantity, ExpireDate,Price);

            medicine.Add(dummy);
            MessageBox.Show("Medicine has been added successfully!");
        }

        private void ShowMedicine_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDShowBox.Text);
            bool flag = false;
            foreach (Medicine medicine in medicine)
            {
                if (medicine.ID == ID)
                {
                    flag = true;
                    MedicineIDShowLabel.Text = "Medicine ID:" + " " + medicine.ID.ToString();
                    NameShowLabel.Text = "Name:" + " " + medicine.Name;
                    ManufacturerCompanyShow.Text = "Manufacturer Company:" + " " + medicine.Company;
                    QuantityShowLabel.Text = "Quantity:" + " " + medicine.Quantity.ToString();
                    ExpireDateShowLabel.Text = "Expire Date:" + " " + medicine.ExpireDate;
                    ShowPriceLabel.Text = "Current Price:" + " " + medicine.Price;
                    
                }
               
            }

            if (flag == false)
            {
                MessageBox.Show("Medicine could not be found!");
            }
        }

        private void QuantityShowLabel_Click(object sender, EventArgs e)
        {

        }

        
        private bool MedicineExists(int id)
        {
            foreach (Medicine medicine in medicine)
            {
                if (medicine.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        public void SellMedicine_Click(object sender, EventArgs e)
        {
            int MedicineID = Convert.ToInt32(SellMedicineIDBox.Text);


            if (MedicineExists(MedicineID))
            {
                foreach (Medicine medicine in medicine)
                {
                    if (medicine.ID == MedicineID)
                    {                       
                        medicine.Quantity -=Convert.ToInt32(QuantitySellBox.Text);
                        MessageBox.Show("Medicine Sell Sucessfully");
                        if (medicine.Quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }

                    }
                    break;
                    
                }
            }

           

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

