using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Charles_Assignment1
{
    public class View
    {
        public void Welcome() {
            String intro = "Welcome to Rec - count!\n" +
                "Please follow the prompts in order to enter the dimensions of your rectangle to find the area and perimiter.";

            DisplayInfo("1");
            Console.WriteLine(Title());
            Console.WriteLine(intro);
            Console.ReadKey();
        }

        public void displayResult(double result, string label) {
            String m = "The " + label + " of your rectangle is " + result +".";
            Console.WriteLine(m);
        }

        public double GetDimension(String dimension) {
            double input = 0;

            Console.WriteLine("Enter the " + dimension + " of the rectangle measured in inches:");
            input = double.Parse(Console.ReadLine());
            return input;
        }

        private void DisplayInfo(string currentAssignment)
        {
            string barrier = "***********************************************************************************";

            Console.WriteLine(barrier + "\n\n");
            Console.WriteLine("Name:\t\tDavid Charles");
            Console.WriteLine("Course:\t\tITDEV-115-501");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t" + currentAssignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine("\n\n" + barrier);
        }

        private String Title() {
            String t = "\r\n          _____                    _____                    _____                                    _____                   _______                   " +
                "_____                    _____                _____          \r\n         /\\    \\                  /\\    \\                  /\\    \\" +
                "                                  /\\    \\                 /::\\    \\                 /\\    \\                  /\\    \\              /\\    \\" +
                "         \r\n        /::\\    \\                /::\\    \\                /::\\    \\                                /::\\    \\               /::::\\" +
                "    \\               /::\\____\\                /::\\____\\            /::\\    \\        \r\n       /::::\\    \\              /::::\\    \\              " +
                "/::::\\    \\                              /::::\\    \\             /::::::\\    \\             /:::/    /               /::::|   |            \\:::\\    \\" +
                "       \r\n      /::::::\\    \\            /::::::\\    \\            /::::::\\    \\                            /::::::\\    \\           /::::::::\\    \\ " +
                "          /:::/    /               /:::::|   |             \\:::\\    \\      \r\n     /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\" +
                "                          /:::/\\:::\\    \\         /:::/~~\\:::\\    \\         /:::/    /               /::::::|   |              \\:::\\    \\     \r\n" +
                "    /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/  \\:::\\    \\                        /:::/  \\:::\\    \\       /:::/    \\:::\\    \\ " +
                "      /:::/    /               /:::/|::|   |               \\:::\\    \\    \r\n   /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\      /:::/    \\:::\\ " +
                "   \\                      /:::/    \\:::\\    \\     /:::/    / \\:::\\    \\     /:::/    /               /:::/ |::|   |               /::::\\    \\   \r\n " +
                " /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\    /:::/    / \\:::\\    \\                    /:::/    / \\:::\\    \\   /:::/____/   \\:::\\____\\ " +
                "  /:::/    /      _____    /:::/  |::|   | _____        /::::::\\    \\  \r\n /:::/\\:::\\   \\:::\\____\\  /:::/\\:::\\   \\:::\\    \\  /:::/    /   \\:::\\ " +
                "   \\                  /:::/    /   \\:::\\    \\ |:::|    |     |:::|    | /:::/____/      /\\    \\  /:::/   |::|   |/\\    \\      /:::/\\:::\\    \\ \r\n/:::/" +
                "  \\:::\\   \\:::|    |/:::/__\\:::\\   \\:::\\____\\/:::/____/     \\:::\\____\\                /:::/____/     \\:::\\____\\|:::|____|     |:::|    ||:::|    / " +
                "     /::\\____\\/:: /    |::|   /::\\____\\    /:::/  \\:::\\____\\\r\n\\::/   |::::\\  /:::|____|\\:::\\   \\:::\\   \\::/    /\\:::\\    \\      \\::/    /" +
                "                \\:::\\    \\      \\::/    / \\:::\\    \\   /:::/    / |:::|____\\     /:::/    /\\::/    /|::|  /:::/    /   /:::/    \\::/    /\r\n \\" +
                "/____|:::::\\/:::/    /  \\:::\\   \\:::\\   \\/____/  \\:::\\    \\      \\/____/                  \\:::\\    \\      \\/____/   \\:::\\    \\ /:::/    /" +
                "   \\:::\\    \\   /:::/    /  \\/____/ |::| /:::/    /   /:::/    / \\/____/ \r\n       |:::::::::/    /    \\:::\\   \\:::\\    \\       \\:::\\    \\ " +
                "                              \\:::\\    \\                \\:::\\    /:::/    /     \\:::\\    \\ /:::/    /           |::|/:::/    /   /:::/    / " +
                "         \r\n       |::|\\::::/    /      \\:::\\   \\:::\\____\\       \\:::\\    \\                               \\:::\\    \\                " +
                "\\:::\\__/:::/    /       \\:::\\    /:::/    /            |::::::/    /   /:::/    /           \r\n       |::| \\::/____/        \\:::\\   \\::/    / " +
                "       \\:::\\    \\                               \\:::\\    \\                \\::::::::/    /         \\:::\\__/:::/    /             |:::::/    / " +
                "   \\::/    /            \r\n       |::|  ~|               \\:::\\   \\/____/          \\:::\\    \\                               \\:::\\    \\" +
                "                \\::::::/    /           \\::::::::/    /              |::::/    /      \\/____/             \r\n       |::|   | " +
                "               \\:::\\    \\               \\:::\\    \\                               \\:::\\    \\                \\::::/    /             \\::::::/" +
                "    /               /:::/    /                           \r\n       \\::|   |                 \\:::\\____\\               \\:::\\____\\ " +
                "                              \\:::\\____\\                \\::/____/               \\::::/    /               /:::/    /                            \r\n " +
                "       \\:|   |                  \\::/    /                \\::/    /                                \\::/    /                 ~~ " +
                "                     \\::/____/                \\::/    /                             \r\n         \\|___|                   \\/____/   " +
                "               \\/____/                                  \\/____/                                           ~~                       \\/____/ " +
                "                             \r\n                                                                                                              " +
                "                                                                                                      \r\n";
            return t;
        }
    }
}
