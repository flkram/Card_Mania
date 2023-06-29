using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapStone
{
    public partial class BlackJackForm : Form
    {
        public BlackJackGame game { get; set; }
        public AccountInfo I;
        public BlackJackForm(AccountInfo parameterI)
        {
            InitializeComponent();
            game = new BlackJackGame(this, parameterI);
            I = parameterI;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            game.UserInput();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            game.StartGame();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            game.RunGame();
        }


        private void BlackJackForm_Load(object sender, EventArgs e)
        {
            game.StartGame();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            game.RunGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to quit? It will count as a loss.", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                I.EndGame(0, 0, false, true);
                MainMenu m = new MainMenu(I, true);
                m.Show();
                Close();
            }
        }
    }
}
