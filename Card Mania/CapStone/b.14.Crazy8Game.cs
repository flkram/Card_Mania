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
    sealed public class Crazy8Game : Game
    {
        AccountInfo I;
        Crazy8Form form;
        private Card Opencard;
        private int BettingAmount;
        private bool Turn;
        public int cardScreen;
        public int bNum;
        public bool newCard;

        public Crazy8Game(Crazy8Form parameterForm, AccountInfo parameterI)
        {
            I = parameterI;
            form = parameterForm;
        }

        public override void StartGame()
        {

            BettingAmount = I.StartGame();

            if (BettingAmount == -1)
            {
                Directions d = new Directions(I, "Crazy8");
                d.Show();
                form.Close();
            }
            else 
            { 
                Shuffle();

                SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\Crazy8.wav");
                sp.Play();

                for (int i = 0; i < 16; i++)
                {
                    if (i < 8)
                    {
                        pHand.Add(deck[deck.Count - 1]);
                        deck.RemoveAt(deck.Count - 1);
                        pHand[i].PB.Size = new Size(83, 118);
                        pHand[i].PB.SizeMode = PictureBoxSizeMode.Zoom;
                        pHand[i].PB.Location = new Point(42 + (89 * i), 462);
                        form.Controls.Add(pHand[i].PB);
                    }
                    else
                    {
                        cHand.Add(deck[deck.Count - 1]);
                        deck.RemoveAt(deck.Count - 1);
                    }
                }

                form.btnContinue.Hide();
                Opencard = deck[deck.Count - 1];
                form.OpenCard.Image = Opencard.PB.Image;
                deck.RemoveAt(deck.Count - 1);
                form.btnFW.Hide();
                form.btnBW.Hide();
                form.lblLabel.Text = "Welcome. Put down a card that matches the open card";
            }
        }

        public override void UserInput()
        {
            if (newCard)
            {
                newCard = false;
                if (deck.Count == 0)
                {
                    Shuffle();
                    MessageBox.Show("Deck has been re-shuffled");
                }
                form.lblLabel.Text = "You drew a new card. Press the button to continue.";
                pHand.Add(deck[deck.Count - 1]);
                deck.RemoveAt(deck.Count - 1);
                pHand[pHand.Count - 1].PB.Size = new Size(83, 118);
                pHand[pHand.Count - 1].PB.SizeMode = PictureBoxSizeMode.Zoom;
                if (pHand.Count % 8 == 0) { cardScreen = pHand.Count / 8 - 1; }
                else { cardScreen = (pHand.Count - (pHand.Count % 8)) / 8; }
                form.Controls.Add(pHand[pHand.Count - 1].PB);
                CardDisplay();
            }
            else if (Opencard.IntSuit == pHand[bNum].IntSuit | Opencard.IntNumber == pHand[bNum].IntNumber | pHand[bNum].IntNumber == 8)
            {
                Opencard = pHand[bNum];
                form.OpenCard.Image = pHand[bNum].PB.Image;
                form.lblLabel.Text = "You put down a " + Opencard.IntNumberString + " of " + Opencard.IntSuitString +
                    "s. Press the button to continue";
                form.Controls.Remove(pHand[bNum].PB);
                pHand.RemoveAt(bNum);
                CardDisplay();
                Turn = true;
                Checks();
            }
            else
            {
                MessageBox.Show("Does not match the open card. Either take a card or put down a card with matching number/suit");
            }
        }

        public override void RunGame()
        {
            bool x = false;

            for (int i = 0; i < cHand.Count; i++)
            {
                if ((cHand[i].IntSuit == Opencard.IntSuit | cHand[i].IntNumber == Opencard.IntNumber | cHand[i].IntNumber == 8) & x == false)
                {
                    x = true;
                    Opencard = cHand[i];
                    form.OpenCard.Image = cHand[i].PB.Image;
                    cHand.RemoveAt(i);
                    form.lblLabel.Text = "CPU put down a " + Opencard.IntNumberString + " of " + Opencard.IntSuitString +
                        "s. Your turn.";

                    Turn = false;
                    Checks();
                }
            }

            if (x == false)
            {
                if (deck.Count == 0)
                {
                    Shuffle();
                    MessageBox.Show("Deck has been re-shuffled");
                }
                cHand.Add(deck[deck.Count - 1]);
                deck.RemoveAt(deck.Count - 1);
                form.lblLabel.Text = "CPU drew a card.";
                form.btnContinue.Show();
            }

            if (cHand.Count >= 2) { form.c2.Show(); }
            else { form.c2.Hide(); }
            if (cHand.Count >= 3) { form.c3.Show(); }
            else { form.c3.Hide(); }
            if (cHand.Count >= 4) { form.c4.Show(); }
            else { form.c4.Hide(); }
            if (cHand.Count >= 5) { form.c5.Show(); }
            else { form.c5.Hide(); }
            if (cHand.Count >= 6) { form.c6.Show(); }
            else { form.c6.Hide(); }
            if (cHand.Count >= 7) { form.c7.Show(); }
            else { form.c7.Hide(); }
            if (cHand.Count >= 8) { form.c8.Show(); }
            else { form.c8.Hide(); }
        }

        public override void Checks()
        {
            form.btnContinue.Hide();
            form.btnDrawCard.Hide();
            form.b1.Hide();
            form.b2.Hide();
            form.b3.Hide();
            form.b4.Hide();
            form.b5.Hide();
            form.b6.Hide();
            form.b7.Hide();
            form.b8.Hide();

            bool restart = false;
            if (pHand.Count == 0)
            {
                restart = I.EndGame(BettingAmount, 1, true, false);
                if (restart == false) { form.Close(); }
            }
            else if (cHand.Count == 0)
            {
                restart = I.EndGame(BettingAmount, 1, false, false);
                if (restart == false) { form.Close(); }
            }
            else if (Turn)
            {
                form.btnContinue.Show();
            }
            else
            {
                form.btnDrawCard.Show();
                form.b1.Show();
                form.b2.Show();
                form.b3.Show();
                form.b4.Show();
                form.b5.Show();
                form.b6.Show();
                form.b7.Show();
                form.b8.Show();
            }

            if (restart)
            {
                Crazy8Form c = new Crazy8Form(I);
                c.Show();
                form.Close();
            }



        }

        public void CardDisplay()
        {
            for (int i = 0; i < pHand.Count; i++)
            {
                pHand[i].PB.Location = new Point(42 + (89 * (i % 8)), 462);
                pHand[i].PB.Hide();
            }

            for (int i = cardScreen * 8; i < (cardScreen + 1) * 8; i++)
            {
                if (i < pHand.Count)
                {
                    pHand[i].PB.Show();
                    form.b1.Enabled = true;
                    form.b2.Enabled = true;
                    form.b3.Enabled = true;
                    form.b4.Enabled = true;
                    form.b5.Enabled = true;
                    form.b6.Enabled = true;
                    form.b7.Enabled = true;
                    form.b8.Enabled = true;
                }
                else
                {
                    if (i % 8 == 0) { form.b1.Enabled = false; }
                    if (i % 8 == 1) { form.b2.Enabled = false; }
                    if (i % 8 == 2) { form.b3.Enabled = false; }
                    if (i % 8 == 3) { form.b4.Enabled = false; }
                    if (i % 8 == 4) { form.b5.Enabled = false; }
                    if (i % 8 == 5) { form.b6.Enabled = false; }
                    if (i % 8 == 6) { form.b7.Enabled = false; }
                    if (i % 8 == 7) { form.b8.Enabled = false; }
                }
            }

            if (cardScreen == 0)
            {
                form.btnBW.Hide();
            }
            else
            {
                form.btnBW.Show();
            }


            bool x = false;
            if (pHand.Count % 8 == 0)
            {
                if (cardScreen == (pHand.Count / 8) - 1)
                {
                    x = true;
                }
            }

            if (cardScreen == (pHand.Count - (pHand.Count % 8)) / 8 | x)
            {
                form.btnFW.Hide();
            }
            else
            {
                form.btnFW.Show();
            }
        }
    }
}
