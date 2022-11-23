using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charles_Assignment8
{
    internal class Child
    {
        public String Name  { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Address { get; set; }
        public String Sport { get; set; }

        public Child(String name, String sport) {
            this.Name = name;
            this.Sport = sport;
        }
    }


}
