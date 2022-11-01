using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Charles_Assignment6
{
    
    internal class FarmerUI
    {
        Info info = new Info();

        public void Welcome() {
            info.DisplayInfo("Assignment 6");
            Title();
            Instructions();
            WriteLine();
            Enter();
        }

        public string InString() {
            string inString = ReadLine();
            return inString;
        }

        public void PrintString(string msg) { 
            WriteLine(msg);
        }



        public void DisplayScreen(ArrayList northBank, ArrayList southBank) {
            string nBank = "";
            if(northBank.Count > 0) {
                for (int i = 0; i < northBank.Count; i++) {
                    nBank += northBank[i] + "\t";
                }
            } else { 
                nBank = " ";
            }

            string water = "";
            for (int i = 0; i < 4; i++) { 
                water += "^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ \n";
            }

            string sBank = "";
            if( southBank.Count > 0 ) { 
                for (int i = 0; i < southBank.Count; i++) { 
                    sBank += southBank[i] + "\t";
                }

            } else {
                sBank = " ";
            }


            BackgroundColor = ConsoleColor.DarkGreen;
            WriteLine("\n"+nBank.PadRight(21)+"\n");
            BackgroundColor = ConsoleColor.Blue;
            WriteLine(water.PadRight(21));
            BackgroundColor = ConsoleColor.DarkGreen;
            WriteLine(sBank.PadRight(21)+"\n");
            BackgroundColor= ConsoleColor.Black;
        }

        public void ClearScreen() {
            Clear();
        }
        public void Enter() { 
            WriteLine("Press enter to continue...");
            ReadLine();  
        }

        private void Instructions() {
            string instructions = "The farmer must get his fox, chicken, and grain safley facross the river from the NORTH BANK to the SOUTH BANK " +
                "The farmer can make the trip carying only one thing with him.  Choose which item you want the farmer to carry with him, and get all" +
                "three across safley!";

            WriteLine(instructions);
        }

        public void Title() {
            string title = "\r\n  ___                          ___ _    _    _              ___           ___          _      " +
                "\r\n | __|_ _ _ _ _ __  ___ _ _   / __| |_ (_)__| |_____ _ _   | __|____ __  / __|_ _ __ _(_)_ _  \r\n | _/ _` |" +
                " '_| '  \\/ -_) '_| | (__| ' \\| / _| / / -_) ' \\  | _/ _ \\ \\ / | (_ | '_/ _` | | ' \\ \r\n |_|\\__,_|_| |_|_" +
                "|_\\___|_|    \\___|_||_|_\\__|_\\_\\___|_||_| |_|\\___/_\\_\\  \\___|_| \\__,_|_|_||_|\r\n " +
                "                                                                                             \r\n";
            WriteLine(title);
        }
    }
}
