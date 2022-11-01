using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Charles_Assignment6
{
    internal class Farmer
    {
        FarmerUI ui = new FarmerUI();
        private bool cont = true;
        private bool eaten = false;
        private bool accross = false;
        private ArrayList northBank = new ArrayList() { "farmer", "fox", "chicken", "grain"};
        private ArrayList southBank = new ArrayList();


        public void StartGame() {
            ui.Welcome();
            //ui.DisplayScreen(northBank, southBank);
            //ui.Enter();

           do {
                ui.ClearScreen();
                ui.Title();
                ui.DisplayScreen(northBank, southBank);
                PlayerChoice();
                ui.Enter();


            }while(cont);

            //play again
            Continue();
        }

        private char Continue() {
            string answer = "";
            char ans;
            bool cont = true;

            do {
                ui.PrintString("Would you like to play again? Y|N ");
                answer = ui.InString();
                ans = answer.ToLower()[0];

                switch (ans) { 
                    case 'y':
                        cont = false; 
                        break;

                    case 'n':
                        ui.ClearScreen();
                        ui.Title();
                        ui.PrintString("Thank you for playing!");
                        System.Threading.Thread.Sleep(1500);
                        System.Environment.Exit(1);
                        break;
                    default:
                        ui.PrintString("Unknown Response");
                        break;
                }
            } while(cont);
            

            return ans;
        }

        private void Ferry(string choice, ArrayList bank, string currentBank, string otherBank) {
            ui.PrintString("Moving the " + choice + " from " + currentBank + " to " + otherBank);
        }

        private void PlayerChoice() {
            string choice = "";
            string currentBank = ""; //true == north, false ==south
            string otherBank = "";

            if (northBank.Contains("farmer")) { 
                currentBank = "north bank";
                otherBank = "south bank";
            } else { 
                currentBank = "south bank";
                otherBank = "north bank";
            }
            ui.PrintString("What should the Farmer take with him from the " + currentBank + " to the " + otherBank + "?:");
            choice = ui.InString();
            choice = choice.ToLower();

            if (currentBank.Equals("north bank")) { //north=true
                if (northBank.Contains(choice)) {
                    Ferry(choice, northBank, currentBank, otherBank);
                } else {
                    ui.PrintString(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(choice)
                        + " is not on this side of the river.");
                }
            }
            else {
                if (southBank.Contains(choice)) { 
                    Ferry(choice, southBank, currentBank, otherBank);
                } else { 
                    ui.PrintString(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(choice)
                        + " is not on this side of the river.");                   
                }
            }


        }

    }
}
