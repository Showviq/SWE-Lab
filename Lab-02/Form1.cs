using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double att = (double)int.Parse(textBox4.Text); //Attendance
            double mid = (double)int.Parse(textBox5.Text); //Mid
            double finals = (double)int.Parse(textBox6.Text); //Final Score
            label20.Text = "" + (int)att;
            label21.Text = "" + (int)mid;
            label23.Text = "" + (int)finals;

            double quiz = calc_quiz();
            label22.Text = "" + quiz;


            att /= 2.0; //10 marks from attendances out of 20
            mid /= 3.0; //25% mark from mid... that is 25 from 75
            finals /= 3.0; //50% mark from final... that is 50 from 150

            double Total = att + quiz + mid + finals;

            label24.Text = "" + Total;
            label25.Text = get_grade(Total);

            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
        }

        public string get_grade(double tot)
        {
            string grd;
            if (tot >= 80)
                grd = "A";
            else if (tot >= 70)
                grd = "B";
            else if (tot >= 60)
                grd = "C";
            else if (tot >= 50)
                grd = "D";
            else if (tot >= 40)
                grd = "E";
            else
                grd = "F";

            return grd;
        }

        public double calc_quiz()
        {
            int q1, q2, q3, q4;
            q1 = int.Parse(textBox7.Text);
            q2 = int.Parse(textBox8.Text);
            q3 = int.Parse(textBox9.Text);
            q4 = int.Parse(textBox10.Text);


            //FINDING BEST 3 QUIZES Q1, Q2, Q3
            int Q1, Q2, Q3, t1, t2;
            if (q1 > q2)
            {
                Q1 = q1;
                t1 = q2;
            }
            else
            {
                Q1 = q2;
                t1 = q1;
            }

            if (q3 > q4)
            {
                Q2 = q3;
                t2 = q4;
            }
            else
            {
                Q2 = q4;
                t2 = q3;
            }

            if (t1 > t2)
                Q3 = t1;
            else Q3 = t2;


            return (Q1 + Q2 + Q3) / 3.0;
        }


    }
}