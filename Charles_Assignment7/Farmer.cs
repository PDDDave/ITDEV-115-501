using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment7
{
    internal class Farmer
    {
        private ArrayList northBank = new ArrayList() { "farmer", "fox", "chicken", "grain" };
        private ArrayList southBank = new ArrayList();


        public bool CheckControlls() {
            bool disableGroup;
            //disableGroup true = disable south
            //disableGroup false = disable north


            if (northBank.Contains("farmer"))
            {
                disableGroup = true;
            }
            else {
                disableGroup = false;
            }

            return disableGroup;
        }
        public String CheckBanks()
        {
            String msg ="";
            
            //Check if fox eats chicken
            if ((northBank.Contains("fox") && northBank.Contains("chicken") && !northBank.Contains("farmer"))
                || (southBank.Contains("fox") && southBank.Contains("chicken") && !southBank.Contains("farmer")))
            {
                msg = "chicken";

            }

            //check if chicken eats grain

            if ((northBank.Contains("chicken") && northBank.Contains("grain") && !northBank.Contains("farmer"))
                || (southBank.Contains("chicken") && southBank.Contains("grain") && !southBank.Contains("farmer")))
            {
                msg = "grain";
            }

            //check for win condition
            if (northBank.Count < 1)
            {
                msg = "win";
            }

            return msg;
        }

    }
}
