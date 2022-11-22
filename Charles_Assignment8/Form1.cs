namespace Charles_Assignment8
{
    public partial class Form1 : Form
    {
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
            SetDefaultImage();
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
    }
}