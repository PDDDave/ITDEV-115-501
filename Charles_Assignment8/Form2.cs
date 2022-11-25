using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charles_Assignment8
{
    public partial class Form2 : Form
    {
        ArrayList registeredChildren; 

        public Form2(ArrayList listOChildren)
        {
            InitializeComponent();
            registeredChildren = listOChildren;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String child;
            String sport;

            for(int i =0; i < registeredChildren.Count; i++)
            {

                child = ((Child)registeredChildren[i]).Name;
                sport = ((Child)registeredChildren[i]).Sport;


                registeredLstBx.Items.Add(child);
                sportLstBx.Items.Add(sport);
            }
        }
    }
}
