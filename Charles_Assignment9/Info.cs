using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePlayerTicTacToe
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {

            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Name:\t\tDavid Charles");
            Console.WriteLine("Course:\t\tITDEV-115-200");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
        }


    }
}
