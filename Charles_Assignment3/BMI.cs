using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment3
{
    internal class BMI
    {
        //Class properties (Auto Implemented)
        public double BodyMassIndex { get; set; } = 0.0;
        public double HeightInches { get; set; } = 0.0;
        public double WeightPounds { get; set; } = 0.0;

        //Constructors
        public BMI(double height, double wieght) { 
            WeightPounds = wieght;
            HeightInches = height;
        }
        public BMI() { 
        
        }

        public void CalculateBMI() {
            BodyMassIndex = (WeightPounds / (HeightInches * HeightInches)) * 703.0;
        }

        public override string ToString()
        {
            string result;
            switch (BodyMassIndex) {
                case   >= 30:
                    result = "Obese";
                    break;
                case >= 25:
                    result = "Overweight";
                    break;
                case >= 18.5:
                    result = "Normal";
                    break;
                default:
                    result = "Underweight";
                    break;
            }
            string message = "\n\nYour weight is " + WeightPounds +" pounds.\n" +
                "Your height is " + HeightInches + " inches.\n" +
                "Your body mass index result is: " + result;

            return message;
        }


    }
}
