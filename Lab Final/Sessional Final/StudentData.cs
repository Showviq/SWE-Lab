using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessional_Final
{
    class StudentData
    {
        public int id;
        public string name;
        public int attendance;
        public int quiz1, quiz2, quiz3, quiz4;
        public int quizTotal;
        public int mid, final, viva;

        public int total;
        public double percentage;
        public string grade;
        int calculateQuizTotal()
        {
            int worst = quiz1;
            if (worst > quiz2)
                worst = quiz2;
            if (worst > quiz3)
                worst = quiz3;
            if (worst > quiz4)
                worst = quiz4;

            int total = quiz1 + quiz2 + quiz3 + quiz4 - worst;
            //double avg = (double)total / 3.0;
            return total;
        }

        int calculateTotalMarks()
        {
            return quizTotal + attendance + mid + final + viva;
        }

        string calculateGrade(double _total)
        {
            if (_total >= 80)
                return "A+";
            if (_total >= 75)
                return "A";
            if (_total >= 70)
                return "A-";
            if (_total >= 65)
                return "B+";
            if (_total >= 60)
                return "B";
            if (_total >= 55)
                return "B-";
            if (_total >= 50)
                return "C+";
            if (_total >= 45)
                return "C";
            if (_total >= 40)
                return "D";
            else
                return "F";
        }
        
        public StudentData(int _id, string _name, int _attendance, int _quiz1, int _quiz2, int _quiz3, int _quiz4, int _mid, int _final, int _viva)
        {
            id = _id;
            name = _name;
            attendance = _attendance;
            quiz1 = _quiz1;
            quiz2 = _quiz2;
            quiz3 = _quiz3;
            quiz4 = _quiz4;
            mid = _mid;
            final = _final;
            viva = _viva;

            quizTotal = calculateQuizTotal();
            total = calculateTotalMarks();
            percentage = total * 100.0/ 300.0;
            grade = calculateGrade(percentage);
        }

        public static StudentData buildStudentDataFromCSV(string csvLine)
        {
            string[] values = csvLine.Split(',');
            for (int i = 2; i <= 9; i++)
            {
                if (values[i].Equals(""))
                    values[i] = "0";
            }

            StudentData studentData = new StudentData(
                Convert.ToInt32(values[0].Trim()), 
                values[1].ToString(),  // Name
                Convert.ToInt32(values[2]), //Attendance
                Convert.ToInt32(values[3]), //Quiz 1
                Convert.ToInt32(values[4]),
                Convert.ToInt32(values[5]),
                Convert.ToInt32(values[6]), //Quiz 4
                Convert.ToInt32(values[7]),
                Convert.ToInt32(values[8]), //Final
                Convert.ToInt32(values[9])
                );
            return studentData;
        }
    }
}
