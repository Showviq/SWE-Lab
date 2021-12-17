using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(First_nameText.Text);
            int second=Convert.ToInt32(SecondNameText.Text);
            int add=first+second;
            Final_Value.Text = Convert.ToString(add);
            MessageBox.Show("Successfully Added!");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(First_nameText.Text);
            int second = Convert.ToInt32(SecondNameText.Text);
            int sub = first - second;
            Final_Value.Text = Convert.ToString(sub);
            MessageBox.Show("Successfully!");
        }
    }
}
