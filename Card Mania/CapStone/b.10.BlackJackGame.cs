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
    sealed public class BlackJackGame : Game
    {
        private AccountInfo I;
        private BlackJackForm form;
        private int BettingAmount;
        private int RoundsWon;
        private int RoundsLost;
        private int pTotal;
        private int cTotal;

        public BlackJackGame(BlackJackForm parameterForm, AccountInfo parameterI)
        {
            form = parameterForm;
            I = parameterI;

            BettingAmount = I.StartGame();
            Shuffle();


            if (BettingAmount == -1)
            {
                Directions d = new Directions(I, "War");
                d.Show();
                form.Close();
            }
            else
            {
                SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\BlackJack.wav");
                sp.Play();
            }
        }

        Image hc;
        public override void StartGame()
        {
            for (int i = pHand.Count - 1; i >= 0; i--)
            {
                form.Controls.Remove(pHand[i].PB);
                pHand.RemoveAt(i);
            }
            for (int i = cHand.Count - 1; i >= 0; i--)
            {
                form.Controls.Remove(cHand[i].PB);
                cHand.RemoveAt(i);
            }
            pTotal = 0;
            cTotal = 0;
            pHasAce = 0;
            cHasAce = 0;
            RunGameCount = 0;
            form.btnStand.Show();
            form.btnHit.Show();
            form.btnCont.Hide();
            form.btnNew.Hide();

            cHandAdd();
            cHandAdd();
            pHandAdd();
            pHandAdd();

            hc = cHand[0].PB.Image;
            cHand[0].PB.Image = form.dEck.Image;

            form.lblLabel.Text = "Your total is " + pTotal.ToString() + ". \n";

            if (pTotal == 21)
            {
                form.lblLabel.Text += "BlackJack!!! Dealer's Turn. \n";
                form.btnHit.Hide();
                form.btnStand.Hide();
                form.btnCont.Show();
            }
            else
            {
                form.lblLabel.Text += "Stand or Hit? \n";
            }
        }

        public override void UserInput()
        {
            pHandAdd();

            form.lblLabel.Text = "You got a " + pHand[pHand.Count - 1].IntNumberString + " of " +
                    pHand[pHand.Count - 1].IntSuitString + "s\nYour total is " + pTotal.ToString() + ". \n";
            if (pTotal == 21)
            {
                form.lblLabel.Text += "BlackJack!!! \nDealer's Turn. ";
                form.btnHit.Hide();
                form.btnStand.Hide();
                form.btnCont.Show();
            }
            else if (pTotal > 21)
            {
                form.lblLabel.Text += "You busted \nYou Lost.";
                RoundsLost += 1;
                Checks();
            }
            else
            {
                form.lblLabel.Text += "Stand or Hit?";
            }
        }

        private int RunGameCount;
        public override void RunGame()
        {
            form.btnStand.Hide();
            form.btnHit.Hide();
            form.btnCont.Show();
            RunGameCount += 1;

            //Hidden Card is shown
            if (RunGameCount == 1)
            {
                cHand[0].PB.Image = hc;
                form.lblLabel.Text = "The dealer's hidden card was " + cHand[0].IntNumberString + " of " +
                    cHand[0].IntSuitString + "s. \nDealer's total is " + cTotal.ToString() + "\n";
            }

            //Dealer's turn
            else
            {
                //Stand method if player gets blackjack
                if (pTotal == 21)
                {
                    //Tie game if Dealer also gets blackjack
                    if (cTotal == 21)
                    {
                        form.lblLabel.Text += "Dealer also got blackjack. \nTie Game";
                        Checks();
                    }
                    //Player wins if Dealer busts
                    else if (cTotal > 21)
                    {
                        form.lblLabel.Text += "Dealer busted. \nYou Won!";
                        RoundsWon += 1;
                        Checks();
                    }
                    //Dealer hits again if he doesn't get 17
                    else if (cTotal < 17)
                    {
                        form.lblLabel.Text += "Dealer hits. \n";
                        cHandAdd();
                        form.lblLabel.Text = "Dealer got a " + cHand[cHand.Count - 1].IntNumberString + " of " +
                            cHand[cHand.Count - 1].IntSuitString + "s. \nDealer's total is " + cTotal.ToString() + "\n";
                    }
                    //Player wins if dealer doesnt get blackjack
                    else
                    {
                        form.lblLabel.Text = "You Won!";
                        RoundsWon += 1;
                        Checks();
                    }
                }
                //Stand method if player doesnt get blackjack
                else
                {
                    //If dealer gets blackjack, player loses
                    if (cTotal == 21)
                    {
                        form.lblLabel.Text += "Dealer got blackjack. \nYou Lost";
                        RoundsLost += 1;
                        Checks();
                    }
                    //If dealer busts, player wins
                    else if (cTotal > 21)
                    {
                        form.lblLabel.Text += "Dealer busted. \nYou Won!";
                        RoundsWon += 1;
                        Checks();
                    }
                    //If dealer doesnt get 17, he hits again.
                    else if (cTotal < 17)
                    {
                        form.lblLabel.Text += "Dealer plays. ";
                        cHandAdd();
                        form.lblLabel.Text = " Dealer got a " + cHand[cHand.Count - 1].IntNumberString + " of " +
                            cHand[cHand.Count - 1].IntSuitString + "s. \n" + "His total is " + cTotal.ToString() + ".\n";
                    }
                    //If Dealer gets more than player.
                    else if (cTotal > pTotal)
                    {
                        form.lblLabel.Text = "Dealer scored higher \nYou lost";
                        RoundsLost += 1;
                        Checks();
                    }
                    //If Player gets more than dealer.
                    else if (pTotal > cTotal)
                    {
                        form.lblLabel.Text = "You scored higher \nYou won!";
                        RoundsWon += 1;
                        Checks();
                    }
                    //If Player and dealer are equal.
                    else
                    {
                        form.lblLabel.Text = "Tie";
                        Checks();
                    }
                }
            }
        }

        public override void Checks()
        {
            if (deck.Count < 15)
            {
                bool restart;
                if (RoundsWon > RoundsLost)
                {
                    restart = I.EndGame(BettingAmount, 0, true, false);
                    if (restart == false) { form.Close(); }
                }
                else
                {
                    restart = I.EndGame(BettingAmount, 0, false, false);
                    if (restart == false) { form.Close(); }
                }

                if (restart)
                {
                    BlackJackForm b = new BlackJackForm(I);
                    b.Show();
                    form.Close();
                }
                else
                {
                    form.Close();
                }
            }
            else
            {
                form.btnStand.Hide();
                form.btnCont.Hide();
                form.btnHit.Hide();
                form.btnNew.Show();
            }
        }

        int pHasAce;
        int cHasAce;

        public void pHandAdd()
        {
            int c;

            pHand.Add(deck[deck.Count - 1]);
            deck.RemoveAt(deck.Count - 1);
            c = pHand.Count - 1;

            if (pHand[c].IntNumber == 1)
            {
                pHasAce += 1;
                pTotal += 11;
            }
            else
            {
                if (pHand[c].IntNumber > 10) { pTotal += 10; }
                else { pTotal += pHand[c].IntNumber; }
            }

            if (pTotal > 21)
            {
                if (pHasAce > 0)
                {
                    pTotal -= 10;
                    pHasAce -= 1;
                }
            }

            pHand[c].PB.Size = new Size(87, 127);
            if (pHand.Count < 9) { pHand[c].PB.Location = new Point(12 + (93 * (pHand.Count - 1)), 528); }
            else { pHand[c].PB.Location = new Point(12 + (93 * (pHand.Count - 9)), 469); }
            pHand[c].PB.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(pHand[c].PB);
        }

        public void cHandAdd()
        {
            form.lblScore.Text = "Score: \n" + RoundsLost + "\n to \n" + RoundsWon;

            int c;

            cHand.Add(deck[deck.Count - 1]);
            deck.RemoveAt(deck.Count - 1);
            c = cHand.Count - 1;

            if (cHand[c].IntNumber == 1)
            {
                cTotal += 11;
                cHasAce += 1;
            }
            else
            {
                if (cHand[c].IntNumber > 10) { cTotal += 10; }
                else { cTotal += cHand[c].IntNumber; }
            }

            if (cTotal > 21)
            {
                if (cHasAce > 0)
                {
                    cTotal -= 10;
                    cHasAce -= 1;
                }
            }

            cHand[c].PB.Size = new Size(87, 127);
            if (cHand.Count < 9) { cHand[c].PB.Location = new Point(12 + (93 * (cHand.Count - 1)), 12); }
            else { cHand[c].PB.Location = new Point(12 + (93 * (cHand.Count - 1)), 70); }
            cHand[c].PB.SizeMode = PictureBoxSizeMode.Zoom;
            form.Controls.Add(cHand[c].PB);
        }
    }
}
