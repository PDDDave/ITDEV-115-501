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
        public ArrayList northBank = new ArrayList() { "farmer", "fox", "chicken", "grain" };
        public ArrayList southBank = new ArrayList();
        public String CurrentBank { get; set; }
        public String OtherBank { get; set; }


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

        public void MoveFarmer(string choice) {
            if (CurrentBank.Equals("north bank"))
            {
                northBank.Remove(choice);
                southBank.Add(choice);
            }
            else { 
                southBank.Remove(choice);
                northBank.Add(choice);
            }
        }
        public void Ferry(string choice) {
            if (CurrentBank.Equals("north bank"))
            {
                northBank.Remove("farmer");
                northBank.Remove(choice);

                southBank.Add("farmer");
                southBank.Add(choice);
            }
            else
            {
                southBank.Remove("farmer");
                southBank.Remove(choice);

                northBank.Add("farmer");
                northBank.Add(choice);
            }
        }

        public void SetBank()
        {
            if (northBank.Contains("farmer"))
            {
                CurrentBank = "north bank";
                OtherBank = "south bank";
            }
            else
            {
                CurrentBank = "south bank";
                OtherBank = "north bank";
            }
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

        public void ResetBanks()
        {
            northBank.Clear();
            southBank.Clear();

            northBank.Add("farmer");
            northBank.Add("fox");
            northBank.Add("chicken");
            northBank.Add("grain");
        }

    }
}
