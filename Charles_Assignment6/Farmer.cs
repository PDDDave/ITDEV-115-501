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
        private ArrayList northBank = new ArrayList() { "farmer", "fox", "chicken", "grain"};
        private ArrayList southBank = new ArrayList();


        public void StartGame() {
            ui.Welcome();

           do {
                ui.ClearScreen();
                ui.Title();
                ui.DisplayScreen(northBank, southBank);
                PlayerChoice();
                ui.Enter();
                CheckBanks();


            }while(cont);

            //play again
            Continue();
        }

        private void ResetBanks() { 
            northBank.Clear();
            southBank.Clear();

            northBank.Add("farmer");
            northBank.Add("fox");
            northBank.Add("chicken");
            northBank.Add("grain");
        }

        private void CheckBanks() { 
            //Check if fox eats chicken
            if( ( northBank.Contains("fox") && northBank.Contains("chicken") && !northBank.Contains("farmer") ) 
                || ( southBank.Contains("fox") && southBank.Contains("chicken") && !southBank.Contains("farmer")  )) {
            
                ui.Title();
                ui.DisplayScreen(northBank, southBank);
                ui.GotAte("fox", "chicken");
                
                Continue();
            }

            //check if chicken eats grain

            if (( northBank.Contains("chicken") && northBank.Contains("grain") && !northBank.Contains("farmer") ) 
                || ( southBank.Contains("chicken") && southBank.Contains("grain") && !southBank.Contains("farmer")  )) { 

                ui.Title();
                ui.DisplayScreen(northBank, southBank);
                ui.GotAte("chicken", "grain");
                
                Continue();            
            }

            //check for win condition
            if ( northBank.Count < 1) {
                ui.ClearScreen();
                ui.Title();
                ui.DisplayScreen(northBank, southBank);
                ui.YouWin();
                System.Threading.Thread.Sleep(1000);
                ui.PrintString("\n\nAfter a long day of moving cargo across the creek, the farmer heads home to continue his quest of raising foxes and chickens.");
                System.Threading.Thread.Sleep(1000);
                Continue();
            }
        }


        private char Continue() {
            string answer = "";
            char ans;
            bool cont = true;

            do {
                ui.PrintString("\nWould you like to play again? Y|N ");
                answer = ui.InString();
                ans = answer.ToLower()[0];

                switch (ans) { 
                    case 'y':
                        ResetBanks();
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

            ui.PrintString("\nMoving the " + choice + " from " + currentBank + " to " + otherBank);
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

            ui.PrintString("\nMoving the " + choice + " from " + currentBank + " to " + otherBank);
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
