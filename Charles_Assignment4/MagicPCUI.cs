using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Charles_Assignment4
{
    internal class MagicPCUI
    {
        internal void welcome()
        {
            MagicPC magicPC = new MagicPC();
            bool cont = true;
            string input = null;
            string answer;
            printWelcome();

            do {
                directions();
                input = getInput();
                if (input != null)
                {
                    answer = magicPC.GetUserAnswer();
                    PrintResult(input, answer);
                }
                else { cont = false;  }
            } while (cont);

            exit();
        }

        private void PrintResult(string question, string answer)
        {
            Console.WriteLine("\n\nYour question:\t\t" + question);
            Console.WriteLine("Magical response: \t" + answer);
        }

        private string getInput()
        {
            string result;
            string inString = Console.ReadLine();

            if (inString.Length > 1)
            {
                result = inString;
            }
            else { result = null; }

            return result;
        }

        private void exit()
        {
            Console.WriteLine("Magic must recharge, come back later!");
            Environment.Exit(0);
        }

        private void printWelcome()
        {
            string ball = "        ____\r\n    ,dP9CGG88@b,\r\n  ,IP  _   Y888@@b,\r\n dIi  (_)   G8888@b\r\ndCII  (_)   G8888@@b\r\nGCCIi     ," +
                "GG8888@@@\r\nGGCCCCCCCGGG88888@@@\r\nGGGGCCCGGGG88888@@@@...\r\nY8GGGGGG8888888@@@@P.....\r\n Y88888888888@@@@@P......\r\n `Y8888888@@@@@@@P" +
                "'......\r\n    `@@@@@@@@@P'.......\r\n        \"\"\"\"........";

            string title = "\r\n __    __    ___  _        __   ___   ___ ___    ___      ______   ___       ___ ___   ____   ____  ____   __      ____    __  __ " +
                "\r\n|  |__|  |  /  _]| |      /  ] /   \\ |   |   |  /  _]    |      | /   \\     |   |   | /    | /    ||    | /  ]    |    \\  /  ]|  |\r\n|  |  | " +
                " | /  [_ | |     /  / |     || _   _ | /  [_     |      ||     |    | _   _ ||  o  ||   __| |  | /  /     |  o  )/  / |  |\r\n|  |  |  ||    _]| |___ / " +
                " /  |  O  ||  \\_/  ||    _]    |_|  |_||  O  |    |  \\_/  ||     ||  |  | |  |/  /      |   _//  /  |__|\r\n|  `  '  ||   [_ |     /   \\_ |     ||  " +
                " |   ||   [_       |  |  |     |    |   |   ||  _  ||  |_ | |  /   \\_     |  | /   \\_  __ \r\n \\      / |     ||     \\     ||     ||   |   ||     |  " +
                "    |  |  |     |    |   |   ||  |  ||     | |  \\     |    |  | \\     ||  |\r\n  \\_/\\_/  |_____||_____|\\____| \\___/ |___|___||_____|      |__|  " +
                " \\___/     |___|___||__|__||___,_||____\\____|    |__|  \\____||__|\r\n    " +
                "                                                                                                                             " +
                " \r\n";


            Console.WriteLine("Welcome to Magic PC!");
            Console.WriteLine(title);
            Console.WriteLine(ball);
        }

        private void directions()
        {
            Console.WriteLine("\n\nEnter your question to consult the MagicPC, or enter a blank to exit:");
        }
    }
}
