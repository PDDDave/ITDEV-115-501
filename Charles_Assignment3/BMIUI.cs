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
        public void ObtainWeightHeight()
        {
            Console.WriteLine("Please Enter your weight in pounds: ");
            userBMI.WeightPounds = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your height in inches: ");
            userBMI.HeightInches = Double.Parse(Console.ReadLine());
        }
    }
}
