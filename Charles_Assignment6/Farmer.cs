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

        private void MoveFarmer(string choice, string currentBank, string otherBank) { 
            if (currentBank.Equals("north bank")){ 
                northBank.Remove(choice);

                southBank.Add(choice);
            }else { 
                southBank.Remove(choice);

                northBank.Add(choice);
            }

            ui.PrintString("Moving the " + choice + " from " + currentBank + " to " + otherBank);
        }

        private void Ferry(string choice, string currentBank, string otherBank) {
            if (currentBank.Equals("north bank")){ 
                northBank.Remove("farmer");
                northBank.Remove(choice);

                southBank.Add("farmer");
                southBank.Add(choice);
            }else { 
                southBank.Remove("farmer");
                southBank.Remove(choice);

                northBank.Add("farmer");
                northBank.Add(choice);
            }

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
                if ( northBank.Contains(choice)) {
                    if (choice.Equals("farmer")) {
                        MoveFarmer(choice, currentBank, otherBank);
                    }else { 
                        Ferry(choice, currentBank, otherBank);
                    }
                } else {
                    ui.PrintString(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(choice)
                        + " is not on this side of the river.");
                }
            }
            else {
                if (southBank.Contains(choice)) {
                    if (choice.Equals("farmer")) {
                        MoveFarmer(choice, currentBank, otherBank);
                    }else { 
                        Ferry(choice, currentBank, otherBank);
                    }
                } else { 
                    ui.PrintString(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(choice)
                        + " is not on this side of the river.");                   
                }
            }
        }

    }
}
