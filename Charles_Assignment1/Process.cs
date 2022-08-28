using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment1
{
    public class Process
    {
        public double Area(double height, double width) {
            double result = height * width;
            return result;
        }

        public double Perimiter(double height, double width) { 
            double result = (width * 2) + (height * 2);
            return result;
        }
    }
}
