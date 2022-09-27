using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment5
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double[] hours = new double[7];

        public Student(int inID, string inName)
        {
            Name = inName;
            Id = inID;
        }

        public double CalculateAvg() {
            double avg = 0;
            double accumulator = 0;
            
            foreach (int hour in hours) {
                accumulator += hour;
            }
            
            return accumulator / hours.Length;
        }

        public void EnterHours(string[] days) {
            int i = 0;
            foreach (double hour in hours)
            {
                Console.WriteLine("Enter hours studied on " + days[i] + ":");
                hours[i] = int.Parse(Console.ReadLine());
                i++;
            }
        }

        public void GetNumberHours() {
            //not sure what function is supposed to go to this method.
        }


    }
}
