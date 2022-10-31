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
            ui.DisplayScreen(northBank, southBank);
            Console.ReadLine();
            ui.PlayerChoice(northBank, southBank);
            Console.ReadLine();

           /* do {
                ui.DisplayScreen(northBank, southBank);
                GameOver();
            }while(cont) */
        }

        private void GameOver() {
        }
    }
}
