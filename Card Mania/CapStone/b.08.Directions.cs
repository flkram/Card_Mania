using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapStone
{
    public partial class Directions : Form
    {
        AccountInfo I;
        string outgame;
        public Directions(AccountInfo passI, string ingame)
        {
            InitializeComponent();
            I = passI;
            outgame = ingame;
        }

        private void Directions_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\imgs\" + outgame + "IMG.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            if (outgame == "BlackJack")
            {
                lblDirections.Text = "Dealer and Player can have a hand up to five cards long. The goal is to get closest to 21. If cards exceed 21," +
                    "then player automatically loses. If player gets blackjack or stands, the dealer plays his turn. If the dealer recieves less than the" +
                    " player or busts then the player wins. Otherwise, the dealer wins. Dealer stops hitting when he gets 17 or above.";
                lblDirections.ForeColor = Color.White;
                btnBack.ForeColor = Color.Black;
                btnGo.ForeColor = Color.Black;
            }
            else if (outgame == "Crazy8")
            {
                 lblDirections.Text = "Dealer and Player start with 8 cards. The goal is to get to 0 cards as soon as possible, first one to get an empty" +
                    "hand wins the game. Dealer and player place a card in the deck if either the color or number matches. The 8 card can be used as any " +
                    "card. If no cards in hand match, player or dealer picks up one card from the deck.";
                lblDirections.ForeColor = Color.Black;
                btnBack.ForeColor = Color.White;
                btnGo.ForeColor = Color.White;
            }
            else if (outgame == "War")
            {
                 lblDirections.Text = "CPU and Player each recieve 26 cards (half the deck) face down. Each round the player and the CPU draw a card, whoever" +
                    "recieves the higher cards gets 2 points. If the cards are the same, the players draw 3 cards, add them up, and whoever wins get 8 cards. Who ever" +
                    "has the most points at the end of the game wins.";
                lblDirections.ForeColor = Color.Red;
                btnBack.ForeColor = Color.Green;
                btnGo.ForeColor = Color.Green;
            }
            btnBack.BackColor = lblDirections.ForeColor;
            btnGo.BackColor = lblDirections.ForeColor;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (outgame == "BlackJack")
            {
                BlackJackForm b = new BlackJackForm(I);
                try { b.Show(); } catch { }
                this.Close();
            }
            else if (outgame == "Crazy8")
            {
                Crazy8Form c = new Crazy8Form(I);
                try { c.Show(); } catch { }
                this.Close();
            }
            else if (outgame == "War")
            {
                WarForm w = new WarForm(I);
                try { w.Show(); } catch { }
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(I, false);
            m.Show();
            this.Close();
        }
    }
}
