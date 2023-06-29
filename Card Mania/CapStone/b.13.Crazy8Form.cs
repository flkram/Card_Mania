using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CapStone
{
    public partial class Crazy8Form : Form
    {
        AccountInfo I;
        Crazy8Game game;
        public int BettingAmount { get; set; }

        public Crazy8Form(AccountInfo passI)
        {
            InitializeComponent();
            I = passI;
            game = new Crazy8Game(this, I);
            game.StartGame();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            game.bNum = (0 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            game.bNum = (1 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            game.bNum = (2 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            game.bNum = (3 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            game.bNum = (4 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            game.bNum = (5 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            game.bNum = (6 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            game.bNum = (7 + (8 * game.cardScreen));
            game.UserInput();
        }

        private void newCard_Click(object sender, EventArgs e)
        {
            game.newCard = true;
            game.UserInput();
        }

        private void btnBW_Click(object sender, EventArgs e)
        {
            game.cardScreen -= 1;
            game.CardDisplay();
        }

        private void btnFW_Click(object sender, EventArgs e)
        {
            game.cardScreen += 1;
            game.CardDisplay();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            game.RunGame();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to quit? It will count as a loss.", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                I.EndGame(0, 1, false, true);
                MainMenu m = new MainMenu(I, true);
                m.Show();
                Close();
            }
        }
    }

}
