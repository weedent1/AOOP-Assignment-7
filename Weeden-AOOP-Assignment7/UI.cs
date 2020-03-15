using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Weeden_AOOP_Assignment7
{
    class UI
    {
        public void AppIntroduction()
        {
            WriteLine("\nThis app will take an input of scores and then display 2 outputs.\n" +
                "The first output will return all students and their scores when their score is greater than 80.\n" +
                "The second output will return an average of all the scores.");
        }

        public int GetScore(string student)
        {
            int inValue;
            WriteLine("\nPlease input {0}'s score:\t", student);
            while (!int.TryParse(ReadLine(), out inValue))
            {
                Write("\nPlease enter a valid integer:\t");
            }
            return inValue;
        }

        public string GetName()
        {
            WriteLine("\nPlease input students name:\t");
            string inValue = ReadLine();
            while (inValue == "")
            {
                Write("\nPlease enter a valid string:\t");
                inValue = ReadLine();
            }
            return inValue;
        }
    }
}
