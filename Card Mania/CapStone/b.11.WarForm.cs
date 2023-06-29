using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace CapStone
{
    public partial class WarForm : Form
    {
        private AccountInfo I;
        private WarGame game;

        public WarForm(AccountInfo passI)
        {
            InitializeComponent();
            I = passI;
            game = new WarGame(this, I);
            game.StartGame();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            game.UserInput();
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
                I.EndGame(0, 2, false, true);
                MainMenu m = new MainMenu(I, true);
                m.Show();
                Close();
            }
        }
    }


}
