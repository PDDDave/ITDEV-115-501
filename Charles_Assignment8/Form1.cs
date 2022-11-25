using System.Collections;
using System.DirectoryServices;

namespace Charles_Assignment8
{
    public partial class Form1 : Form
    {

        ArrayList listOChildren = new ArrayList();
        Utilities utilities = new Utilities();
        public Form1()
        {
            InitializeComponent();
        }

        private void bladeRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetNewImage();
        }

        private void sftBallRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetNewImage();
        }


        private void fieldHocRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetNewImage();
        }

        private void SetNewImage()
        {
            if (fieldHocRdBtn.Checked)
            {
                mainPicBx.Image = Charles_Assignment8.Properties.Resources.fieldHockey;
                captionTxtBx.Text = "Hockey but no ice!";
            }
            else if (bladeRdBtn.Checked)
            {
                mainPicBx.Image = Charles_Assignment8.Properties.Resources.rollerblading;
                captionTxtBx.Text = "Carve the streets with your blades!";
            }
            else if (skateRdBtn.Checked)
            {
                mainPicBx.Image = Charles_Assignment8.Properties.Resources.skateboarding;
                captionTxtBx.Text = "Learn to shred with the best of them!";
            }
            else if (sftBallRdBtn.Checked)
            {
                mainPicBx.Image = Charles_Assignment8.Properties.Resources.softball;
                captionTxtBx.Text = "The balls not very soft...";
            }
            else {
                mainPicBx.Image = Charles_Assignment8.Properties.Resources.ultfrisbee;
                captionTxtBx.Text = "Fun for the whole family!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            stateCmboBx.Items.Add("WI");
            stateCmboBx.Items.Add("MI");
            stateCmboBx.Items.Add("IL");
            stateCmboBx.Items.Add("MN");
            stateCmboBx.Items.Add("IA");
            stateCmboBx.Items.Add("NE");

            fieldHocRdBtn.Checked = true;
            stateCmboBx.Text = "WI";
        }

        private void SetDefaultImage()
        {
            mainPicBx.Image = Charles_Assignment8.Properties.Resources.sports;
        }

        private void skateRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetNewImage();
        }

        private void ultFrisRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetNewImage();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            //check that boxes are not empty
            if (nameTxtBx.Text != string.Empty || addressTxtBx.Text != string.Empty) 
            {
                CreateChild();
                ResetForm();
            } else {
                MessageBox.Show("Please ensure all fields are completley filled out!","Form Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetForm()
        {
            utilities.ResetControlls(this);
            fieldHocRdBtn.Checked = true;
            nameTxtBx.Focus();
        }

        private void CreateChild()
        {
            String sport = "";

            if (skateRdBtn.Checked) { sport = "Skateboarding"; }
            else
            if (fieldHocRdBtn.Checked) { sport = "Field Hockey"; }
            else
            if (bladeRdBtn.Checked) { sport = "Rollerblading"; }
            else
            if (sftBallRdBtn.Checked) { sport = "Softball"; }
            else
            if (ultFrisRdBtn.Checked) { sport = "Ultimate Frisbee"; }


            Child child = new Child(nameTxtBx.Text, addressTxtBx.Text, cityTxtBx.Text, stateCmboBx.Text, sport);
            listOChildren.Add(child);
        }

        private String PrintList() {
            String msg = "";

            for (int i = 0; i < listOChildren.Count; i++) {
                msg += ((Child)listOChildren[i]).Name + "\t" + ((Child)listOChildren[i]).Sport + "\n";
            }

            return msg;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listOChildren.Count > 0) {
                Form2 form2 = new Form2(listOChildren);
                form2.ShowDialog();
            }
        }
    }
}