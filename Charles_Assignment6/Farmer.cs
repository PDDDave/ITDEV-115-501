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
                ui.PlayerChoice(northBank, southBank);
                ui.Enter();
                ui.Continue();

                //GameOver();
            }while(cont);
        }

        private void GameOver() {
        }
    }
}
