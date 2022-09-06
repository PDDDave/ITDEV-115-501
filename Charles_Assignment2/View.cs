using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment2
{
    internal class View
    {
        public void welcome() {
            Console.WriteLine("Welcome to Payroll Calculator!");
            DisplayInfo("Assignment 2");
        }

        public void pleaseEnter(string whatToEnter) {
            Console.WriteLine("Please enter " + whatToEnter + " :");
        }

        public string inString() {
            return Console.ReadLine();
        }

        internal void printString(string m)
        {
            Console.WriteLine(m);
        }

        private void DisplayInfo(string currentAssignment)
        {
            string barrier = "***********************************************************************************";

            Console.WriteLine(barrier + "\n\n");
            Console.WriteLine("Name:\t\tDavid Charles");
            Console.WriteLine("Course:\t\tITDEV-115-501");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t" + currentAssignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine("\n\n" + barrier);
        }
    }
}
