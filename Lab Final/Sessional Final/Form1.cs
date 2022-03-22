using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sessional_Final
{
    public partial class Form1 : Form
    {
        List<StudentData> values;
        public Form1()
        {
            InitializeComponent();
            InitalizeData();
        }

        void InitalizeData()
        {
            values = File.ReadAllLines("C:\\Users\\User\\Downloads\\SWE4201MarkSheet.csv") //Input Paths
                   .Skip(9) //First 9 lines are headlines, so ignored
                   .Select(v => StudentData.buildStudentDataFromCSV(v))
                   .ToList();

            for (int i = 0; i < values.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = values[i].id;
                row.Cells[1].Value = values[i].name;
                row.Cells[2].Value = values[i].percentage.ToString("F2");
                row.Cells[3].Value = values[i].grade;
                dataGridView1.Rows.Add(row);
            }
        }

        void SearchByID(int id)
        {
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].id == id)
                {
                    UpdateData(i);
                    return;
                }
            }

            // not found
            MessageBox.Show("Could not find anyone with given ID.");
        }

        void UpdateData(int index)
        {
            StudentNameText.Text = values[index].name;
            AttendanceText.Text = values[index].attendance + "";
            Quiz1Text.Text = values[index].quiz1 + "";
            Quiz2Text.Text = values[index].quiz2 + "";
            Quiz3Text.Text = values[index].quiz3 + "";
            Quiz4Text.Text = values[index].quiz4 + "";
            QuizTotalText.Text = values[index].quizTotal + "";
            MidText.Text = values[index].mid + "";
            FinalText.Text = values[index].final + "";
            VivaText.Text = values[index].viva + "";
            TotalText.Text = values[index].total + "";
            PercentageText.Text = values[index].percentage.ToString("F2") + "%";
            GradeText.Text = values[index].grade;

            if (values[index].grade.Equals("F"))
                GradeText.ForeColor = Color.Red;
            else
                GradeText.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchByID(Convert.ToInt32(textInput.Text.Trim()));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
