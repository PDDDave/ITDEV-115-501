using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment7
{
    internal class GuiInfo
    {
        public String DisplayInfo(string currentAssignment)
        {
            string msg;
            string barrier = "***************************************************************";

            msg = barrier + "\n\n";
            msg += "Name:\t\tDavid Charles\n";
            msg += "Course:\t\tITDEV-115-501\n";
            msg += "Instructor:\tMr. Menzl\n";
            msg += "Assignment:\t" + currentAssignment +"\n";
            msg += "Date:\t\t" + System.DateTime.Today.ToShortDateString() + "\n";
            msg += "\n\n" + barrier;

            return msg;
        }
    }
}
