using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace CapStone
{
    sealed public class WarGame : Game
    {
        private AccountInfo i;
        public AccountInfo I
        {
            get { return i; }
            set { i = value; }
        }
        private WarForm secureform;
        public WarForm form 
        { 
            get { return secureform; }
            set { secureform = value; }
        }

        private int BettingAmount;
        public int bettingAmount
        {
            get { return bettingAmount; }
            set { bettingAmount = value; }
        }
        private Card p;
        private Card c;
        private int wins;
        private int losses;
        private bool War;
        private int WarCount;
        private int WarWinCount;

        public WarGame(WarForm passing, AccountInfo passI)
        {
            I = passI;
            form = passing;
        }

        public override void StartGame()
        {

            BettingAmount = I.StartGame();

            if (BettingAmount == -1)
            {
                Directions d = new Directions(I, "War");
                d.Show();
                form.Close();
            }
            else
            {
                SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\War.wav");
                sp.Play();

                Shuffle();
                form.btnContinue.Hide();

                for (int i = 0; i < deck.Count; i++)
                {
                    if (i < 26) pHand.Add(deck[i]);
                    else cHand.Add(deck[i]);
                }

                deck.Clear();
                form.lblScore.Text = "Score is: " + wins + " to " + losses + "\n Cards Left: " + pHand.Count;
            }

        }

        public override void UserInput()
        {
            p = pHand[pHand.Count - 1];
            c = cHand[cHand.Count - 1];

            if (War)
            {
                WarCount += 1;

                if (WarCount == 1)
                {
                    form.warCardP1.Image = p.PB.Image;
                    form.warCardP1.Show();
                    form.warCardC1.Image = c.PB.Image;
                    form.warCardC1.Show();
                    form.lblLabel.Text = "You got a " + p.IntNumberString + " of " + p.IntSuitString + "s\n" +
                        "the CPU got a " + c.IntNumberString + " of " + c.IntSuitString + "s";
                }
                else if (WarCount == 2)
                {
                    form.warCardP2.Image = p.PB.Image;
                    form.warCardP2.Show();
                    form.warCardC2.Image = c.PB.Image;
                    form.warCardC2.Show();
                    form.lblLabel.Text = "You got a " + p.IntNumberString + " of " + p.IntSuitString + "s\n" +
                        "the CPU got a " + c.IntNumberString + " of " + c.IntSuitString + "s";
                }
                else
                {
                    form.warCardP3.Image = p.PB.Image;
                    form.warCardP3.Show();
                    form.warCardC3.Image = c.PB.Image;
                    form.warCardC3.Show();
                    form.lblLabel.Text = "You got a " + p.IntNumberString + " of " + p.IntSuitString + "s\n" +
                        "the CPU got a " + c.IntNumberString + " of " + c.IntSuitString + "s";
                }
            }

            else
            {
                form.DeckC.Show();
                form.DeckP.Show();

                form.DeckC.Image = c.PB.Image;
                form.DeckP.Image = p.PB.Image;
                form.lblLabel.Text = "You got a " + p.IntNumberString + " of " + p.IntSuitString + "s\n" +
                    "the CPU got a " + c.IntNumberString + " of " + c.IntSuitString + "s";
            }

            form.btnFlip.Hide();
            form.btnContinue.Show();
        }

        public override void RunGame()
        {
            if (War)
            {
                if (c.IntNumber > p.IntNumber)
                {
                    form.lblLabel.Text = "You lost, flip again.";
                    WarWinCount -= 1;
                }
                else if (c.IntNumber < p.IntNumber)
                {
                    form.lblLabel.Text = "You won, flip again.";
                    WarWinCount += 1;
                }
                else
                {
                    form.lblLabel.Text = "Tie War";
                }

                if (WarCount == 3)
                {
                    if (WarWinCount < 0)
                    {
                        form.lblLabel.Text = "You lost the war, cpu gets 3 points";
                        losses += 3;
                        form.pDeckC.Image = form.warCardC3.Image;
                    }
                    else if (WarWinCount > 0)
                    {
                        form.lblLabel.Text = "You won the war, you get 3 points";
                        wins += 3;
                        form.pDeckP.Image = form.warCardP3.Image;
                    }
                    else
                    {
                        form.lblLabel.Text = "War was a stalemate";
                    }

                    War = false;

                    form.warCardC1.Hide();
                    form.warCardC2.Hide();
                    form.warCardC3.Hide();
                    form.warCardP1.Hide();
                    form.warCardP2.Hide();
                    form.warCardP3.Hide();
                }
            }

            else
            {
                if (c.IntNumber > p.IntNumber)
                {
                    form.DeckC.Hide();
                    form.DeckP.Hide();
                    form.pDeckC.Image = form.DeckP.Image;
                    losses += 1;
                    form.lblLabel.Text = "You lost, flip again.";
                }

                else if (c.IntNumber < p.IntNumber)
                {
                    form.DeckC.Hide();
                    form.DeckP.Hide();
                    form.pDeckP.Image = form.DeckC.Image;
                    wins += 1;
                    form.lblLabel.Text = "You win, flip again.";
                }

                else
                {
                    form.lblLabel.Text = "War!";
                    War = true;
                    WarCount = 0;
                    WarWinCount = 0;
                }
            }


            form.btnContinue.Hide();
            pHand.RemoveAt(pHand.Count - 1);
            cHand.RemoveAt(cHand.Count - 1);
            form.lblScore.Text = "Score is: " + wins + " to " + losses + "\n Cards Left: " + pHand.Count;
            Checks();
        }

        public override void Checks()
        {
            if (pHand.Count > 0)
            {
                form.btnFlip.Show();
            }
            else
            {
                bool restart;
                if (wins > losses)
                {
                    MessageBox.Show("You Won!!!!");
                    restart = I.EndGame(BettingAmount, 2, true, false);
                    if (restart == false) { form.Close(); }
                }

                else if (wins < losses)
                {
                    MessageBox.Show("You Lost : (");
                    restart = I.EndGame(BettingAmount, 2, false, false);
                    if (restart == false) { form.Close(); }
                }
                else
                {
                    DialogResult r = MessageBox.Show("Tie. Would you like to play again?", "", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        restart = true;
                    }
                    else
                    {
                        restart = false;
                        MainMenu m = new MainMenu(I, true);
                        m.Show();
                        if (restart == false) { form.Close(); }
                    }

                }

                if (restart)
                {
                    WarForm w = new WarForm(I);
                    w.Show();
                    form.Hide();
                }


            }
        }

    }
}
