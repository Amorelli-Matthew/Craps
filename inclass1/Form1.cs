using System;
using System.Windows.Forms;

namespace inclass1
{
    // Name: Matthew Amorelli

    // Date: September 21, 2021

    // Assignment: Craps! game (Chapter 4- exersize 3)

    // Description: This is the Craps Game we made in class on September 21, 2021
    public partial class FormCrapsGame : Form
    {
        //declear the varables
        Random Rand = new Random();

        int playerRoll = 0;
        bool isFirstRoll = true;

        public FormCrapsGame()
        {
            InitializeComponent();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            int dieOne = Rand.Next(1, 6);
            int dieTwo = Rand.Next(1, 7);
            int roll = dieOne + dieTwo;


            //if first roll and not 2,3, or 12
            if (isFirstRoll == true)
            {
                if (roll < 4 || playerRoll == 12)
                {
                    label2.Text = "Loser rolled: " + roll;
                }
                else if (roll == 7 || roll == 11)
                {
                    label2.Text = "Loser rolled: " + roll;
                }
                else
                {
                    playerRoll = dieOne + dieTwo;
                    label2.Text = "player rolled: " + playerRoll;
                    isFirstRoll = false;
                }
            }

            else
            {
                if (playerRoll == roll)
                {
                    label2.Text += "\r\nPlayer Wins! Rolled " + roll;
                    isFirstRoll = true;
                }

                else if (roll < 4 || roll == 7 || roll > 10)
                {
                    label2.Text += "\r\nPlayer Loses! Rolled " + roll;
                    isFirstRoll = true;
                }
                else
                {
                    label2.Text += "\r\nPlayer Wins! Rolled " + roll + " Roll Again...";
                }


                int One = 1;
                One = One + 7;

                label1.Text = One.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
