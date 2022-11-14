namespace Charles_Assignment7
{
    public partial class Form1 : Form
    {
        Farmer game = new Farmer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowGameOver();
        }

        private void ShowGameOver()
        {
            MessageBox.Show("Thank you for playing Farmer: Chicken, Grain, Fox!", "Game Over");
        }

        private void mainPicBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instructionLbl.Text = "The farmer must get his fox, chicken, and grain across the river from the NORTH BANK to the SOUTH BANK." +
            "\nThe farmer can make the trip carying only one thing with him at a time.\nChoose which item you want the farmer to carry with him, and get " +
            "all three across safley!";

            southChicken.Hide();
            southFarmer.Hide();
            southFox.Hide();
            southGrain.Hide();

            DisableGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void northFarmerBtn_Click(object sender, EventArgs e)
        {
            String checkBanks = game.CheckBanks();

            switch (checkBanks) {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    MessageBox.Show("You Win!", "Congrats!!!\nWould you like to play again?",
                        MessageBoxButtons.YesNo);
                    break;
            }


            DisableGroup();
            
        }

        private void GotAte(string devourer, string devouree)
        {
            String title = "Game Over!";
            String msg = "Oh no! The " + devourer + " has devoured the " + devouree + "!\nWould you like to play again?";
            MessageBox.Show(
                msg,title,
                MessageBoxButtons.YesNo);
        }


        private void DisableGroup()
        {
            if (game.CheckControlls())
            {
                northBankGroupBx.Enabled = true;
                southBankGoupBx.Enabled = false;
            }
            else {
                southBankGoupBx.Enabled = true;
                northBankGroupBx.Enabled = false;
            }
        }
    }
}


