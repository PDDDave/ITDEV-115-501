using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_MidTerm_Election_Program
{
    internal class Info
    {
        public void DisplayInfo(string currentAssignment)
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
