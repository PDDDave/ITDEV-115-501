using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Charles_Assignment5
{
    internal class StudentUI
    {
        Info info = new Info();
        Student student;
        String[] days = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        public void MainMethod()
        {
            info.DisplayInfo("Assignment 5");
            DisplayTitle();
            GatherInfo();
            FillHours();
            DisplayData();
            DisplayAverage();

        }

        private void GatherInfo()
        {
            string name;
            int id;

            Write("Please enter your name: ");
            name = ReadLine();
            Write("Please enter your ID number:");
            id = int.Parse(ReadLine());
            student = new Student(id,name);
            
        }

        public void DisplayAverage() {
            Clear();
            WriteLine("Name:\t" + student.Name);
            WriteLine("ID:  \t" + student.Id);
            WriteLine("\n\n\nThe number of hours of study that you did during the week are as follows:\n");

            for (int i = 0; i < days.Length; i++)
            {
                WriteLine(days[i] + ":  \t\t" + student.hours[i]);
            }

            WriteLine("\n\nThe average number of hours studied per day was: " + student.CalculateAvg().ToString("#.##"));

        }

        public void DisplayData() {
            string m = "";
            for (int i = 0; i < days.Length; i++) {
                m = "\t " + days[i] +":  \t\t" + student.hours[i];
                WriteLine(m);
            }
        
        }

        public void FillHours() {
            int i = 0;
            foreach (double hour in student.hours) {
                WriteLine("Enter hours studied on " + days[i] + ":");
                student.hours[i] = int.Parse(ReadLine());
                i++;
            }
        }
        private void DisplayTitle() {
            string title = "\r\n __ _             _            _     __ _             _           _               \r\n/ _\\ |_ _" +
                "   _  __| | ___ _ __ | |_  / _\\ |_ _   _  __| |_   _    /_\\  _ __  _ __  \r\n\\ \\| __| | | |/ _` |/ _ \\ '_ \\|" +
                " __| \\ \\| __| | | |/ _` | | | |  //_\\\\| '_ \\| '_ \\ \r\n_\\ \\ |_| |_| | (_| |  __/ | | | |_  _\\ \\ |_| |_| |" +
                " (_| | |_| | /  _  \\ |_) | |_) |\r\n\\__/\\__|\\__,_|\\__,_|\\___|_| |_|\\__| \\__/\\__|\\__,_|\\__,_|\\__, | \\_/ " +
                "\\_/ .__/| .__/ \r\n                                                        |___/        |_|   |_|    \r\n";
            WriteLine(title + "\n\n");
        }
    }
}
