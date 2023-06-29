using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapStone
{
    public partial class MainMenu : Form
    {
        AccountInfo I { get; set; }
        Random r = new Random();
        public MainMenu(AccountInfo ArgumentI, bool newsound)
        {
            InitializeComponent();
            I = ArgumentI;

            lblAccount.Text = "Account Name: \n" + I.UserName;
            if (I.Money == 0)
            {
                lblMoney.Text = "No Money"; 
                btnRefund.Show();
            }
            else
            {
                lblMoney.Text = "Money: " + I.Money.ToString() + "\nRefunds: " + I.Refunds.ToString();
            }
            if (newsound)
            {
                SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\main.wav");
                sp.Play();
            }

            MaximizeBox = false;
        }


        private void tmrCardAnimation_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int intNum = r.Next(1, 14);
                int intSuitNum = r.Next(0, 4);
                string type = "";
                if (intSuitNum == 0) type = "Club";
                else if (intSuitNum == 1) type = "Spade";
                else if (intSuitNum == 2) type = "Heart";
                else if (intSuitNum == 3) type = "Diamond";

                if (i == 0) DisplayImage1.Image = Image.FromFile(Environment.CurrentDirectory + @"\cards\" + type + intNum.ToString() + @".png");
                else if (i == 1) DisplayImage2.Image = Image.FromFile(Environment.CurrentDirectory + @"\cards\" + type + intNum.ToString() + @".png");
                else if (i == 2) DisplayImage3.Image = Image.FromFile(Environment.CurrentDirectory + @"\cards\" + type + intNum.ToString() + @".png");
            }
        }

        private void btnBlackJack_Click(object sender, EventArgs e)
        {
            Directions d = new Directions(I, "BlackJack");
            d.Show();
            Close();
        }

        private void btnRummy_Click(object sender, EventArgs e)
        {
            Directions d = new Directions(I, "GoFish");
            d.Show();
            Close();
        }

        private void btnWar_Click(object sender, EventArgs e)
        {
            Directions d = new Directions(I, "War");
            d.Show();
            Close();
        }

        private void btnCrazy8_Click(object sender, EventArgs e)
        {
            Directions d = new Directions(I, "Crazy8");
            d.Show();
            Close();
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            I.Refund();
            lblMoney.Text = "Money: " + I.Money.ToString() + "\nRefunds: " + I.Refunds.ToString();
            btnRefund.Hide();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Stats s = new Stats(I);
            s.Show();
        }


        private void btnRandom_Click(object sender, EventArgs e)
        {
            Directions d;
            int rGen = r.Next(0, 3);
            if (rGen == 0 ) {d = new Directions(I, "BlackJack"); }
            else if (rGen == 1) {d = new Directions(I, "Crazy8"); }
            else { d = new Directions(I, "War"); }
            d.Show();
            this.Close();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Options o = new Options(I);
            o.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\Exit.wav");
                sp.PlaySync();
                Environment.Exit(0);
            }
        }
    }
}
