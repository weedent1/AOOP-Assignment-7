using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weeden_AOOP_Assignment7
{
    class Class
    {

        private Student[] students;

        public Class(Student[] students)
        {
            this.students = students;
        }

        public string GetAllAbove80()
        {
            string returnString = "\nScores above 80:";

            IEnumerable<Student> above80Query =
              from student in students
              where student.score > 80
              select student;

            foreach (Student student in above80Query)
            {
                returnString = returnString + "\n" + student.name + " score: \t" + student.score;
            }

            return returnString;
        }

        public string GetHighestScore()
        {
            string returnString = "\nHighest Score(s):";

            int highestScore = students.Max(student => student.score);
            var highestStudents = students.Where(student => student.score == highestScore);

            foreach (Student student in highestStudents)
            {
                returnString = returnString + "\n" + student.name + " score: \t" + student.score;
            }

            return returnString;
        }

    }
}
