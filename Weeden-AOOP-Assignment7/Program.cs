using System;

namespace Weeden_AOOP_Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            info.DisplayInfo();

            UI ui = new UI();

            ui.AppIntroduction();

            Student[] students = new Student[5];

            for(int i = 0; i < students.Length; i++)
            {

                string name = ui.GetName();
                int score = ui.GetScore(name);
                Student newStudent = new Student(name, score);
                students[i] = newStudent;
            }

            Class theClass = new Class(students);

            Console.WriteLine(theClass.GetAllAbove80());

            Console.WriteLine(theClass.GetHighestScore());

        }
    }
}
