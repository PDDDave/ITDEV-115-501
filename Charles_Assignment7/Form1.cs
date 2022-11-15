using Microsoft.VisualBasic;

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
            MessageBox.Show("Thank you for playing Farmer: Chicken, Grain, Fox!!!",
                "Game Over",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
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

            game.SetBank();
            DisableGroup();
        }

        private void southGrainBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.SetBank();
            game.Ferry("grain");

            northFarmer.Show();
            northGrain.Show();

            southFarmer.Hide();
            southGrain.Hide();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();
        }

        private void northFarmerBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.MoveFarmer("farmer");
            northFarmer.Hide();
            southFarmer.Show();

            String checkBanks = game.CheckBanks();

            switch (checkBanks) {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();

        }

        private void CheckButtons()
        {
            if (game.CurrentBank.Equals("north bank"))
            {
                if (!game.northBank.Contains("chicken"))
                {
                    northChickenBtn.Enabled = false;
                }
                else {
                    northChickenBtn.Enabled = true;
                }

                if (!game.northBank.Contains("grain"))
                {
                    northGrainBtn.Enabled = false;
                }
                else { 
                    northGrainBtn.Enabled= true;
                }

                if (!game.northBank.Contains("fox"))
                {
                    northFoxBtn.Enabled = false;
                }
                else {
                    northFoxBtn.Enabled = true;
                }
            }
            else {
                if (!game.southBank.Contains("chicken"))
                {
                    southChickenBtn.Enabled = false;
                }
                else {
                    southChickenBtn.Enabled = true;
                }

                if (!game.southBank.Contains("grain"))
                {
                    southGrainBtn.Enabled = false;
                }
                else
                {
                    southGrainBtn.Enabled = true;
                }

                if (!game.southBank.Contains("fox"))
                {
                    southFoxBtn.Enabled = false;
                }
                else
                {
                    southFoxBtn.Enabled = true;
                }
            }
        }

        private void ResetGame()
        {
            game.ResetBanks();
            DisableGroup();

            southChicken.Hide();
            southFarmer.Hide();
            southGrain.Hide();
            southFox.Hide();

            northChicken.Show();
            northFarmer.Show();
            northGrain.Show();
            northFox.Show();
        }

        private void GotAte(string devourer, string devouree)
        {
            var result = DialogResult;

            String title = "Game Over!";
            String msg = "Oh no! The " + devourer + " has devoured the " + devouree + "!\nWould you like to play again?";
            result = MessageBox.Show(
                msg,title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            EndGame(result);

        }

        private void EndGame(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                MessageBox.Show("Thanks for playing!  Your game will now exit.",
                    "Farmer: Chicken, Grain, Fox", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Windows.Forms.Application.ExitThread();
            }
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

        private void southFarmerBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.MoveFarmer("farmer");
            
            southFarmer.Hide();
            northFarmer.Show();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }

            game.SetBank();
            DisableGroup();
            CheckButtons();
        }

        private void northChickenBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.SetBank();
            game.Ferry("chicken");

            northFarmer.Hide();
            northChicken.Hide();

            southFarmer.Show();
            southChicken.Show();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();
        }

        private void southChickenBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.SetBank();
            game.Ferry("chicken");

            northFarmer.Show();
            northChicken.Show();

            southFarmer.Hide();
            southChicken.Hide();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();
        }

        private void northGrainBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.SetBank();
            game.Ferry("grain");

            northFarmer.Hide();
            northGrain.Hide();

            southFarmer.Show();
            southGrain.Show();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();
        }

        private void northFoxBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.SetBank();
            game.Ferry("fox");

            northFarmer.Hide();
            northFox.Hide();

            southFarmer.Show();
            southFox.Show();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();
        }

        private void southFoxBtn_Click(object sender, EventArgs e)
        {
            var result = DialogResult;

            //change farmer
            game.SetBank();
            game.Ferry("fox");

            northFarmer.Show();
            northFox.Show();

            southFarmer.Hide();
            southFox.Hide();

            String checkBanks = game.CheckBanks();

            switch (checkBanks)
            {
                case "chicken":
                    GotAte("fox", "chicken");
                    break;
                case "grain":
                    GotAte("chicken", "grain");
                    break;
                case "win":
                    result = MessageBox.Show("Congrats!!!\nWould you like to play again?",
                        "You Win!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Asterisk);
                    EndGame(result);
                    break;
                default:
                    break;
            }
            game.SetBank();
            DisableGroup();
            CheckButtons();
        }
    }
}


