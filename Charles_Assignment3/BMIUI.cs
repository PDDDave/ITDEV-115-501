using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment3
{
    internal class BMIUI
    {
        BMI userBMI = new BMI();

        public void BMIMain() {
            displayDirections();
            RequestuserData();
            userBMI.CalculateBMI();
            displayResults();
            Console.ReadLine();
        
        }

        private void displayResults()
        {
            Console.WriteLine(userBMI);
            Console.WriteLine("Press any key to exit...");
        }

        private void displayDirections()
        {
            string title = "\r\n  o__ __o     o          o   __o__           o__ __o                  o                            o                 o                             " +
                "\r\n <|     v\\   <|\\        /|>    |            /v     v\\                <|>                          <|>               <|>                            \r\n / \\ " +
                "    <\\  / \\\\o    o// \\   / \\          />       <\\               / \\                          / \\               < >                            \r\n \\o/     " +
                "o/  \\o/ v\\  /v \\o/   \\o/        o/                o__ __o/  \\o/      __o__   o       o   \\o/     o__ __o/   |        o__ __o    \\o__ __o  \r\n  |__  _<| " +
                "   |   <\\/>   |     |        <|                /v     |    |      />  \\   <|>     <|>   |     /v     |    o__/_   /v     v\\    |     |> \r\n  |       \\  / \\ " +
                "       / \\   < >        \\\\              />     / \\  / \\   o/        < >     < >  / \\   />     / \\   |      />       <\\  / \\   < > \r\n <o>      /  \\o/ " +
                "       \\o/    |           \\         /   \\      \\o/  \\o/  <|          |       |   \\o/   \\      \\o/   |      \\         /  \\o/       \r\n  |      o    |  " +
                "        |     o            o       o     o      |    |    \\\\         o       o    |     o      |    o       o       o    |        \r\n / \\  __/>   / \\      " +
                "  / \\  __|>_          <\\__ __/>     <\\__  / \\  / \\    _\\o__</   <\\__ __/>   / \\    <\\__  / \\   <\\__    <\\__ __/>   / \\       \r\n  " +
                "                                                                                                                                                 \r\n  " +
                "                                                                                                                                                 \r\n   " +
                "                                                                                                                                                \r\n";
            Console.WriteLine(title);
            Console.WriteLine("Please follow the prompts to calculate your BMI!");
        }

        private void RequestuserData()
        {
            Console.WriteLine("Please Enter your weight in pounds: ");
            userBMI.WeightPounds = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your height in inches: ");
            userBMI.HeightInches = Double.Parse(Console.ReadLine());
        }
    }
}
