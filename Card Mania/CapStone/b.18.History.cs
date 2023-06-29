using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapStone
{
    public partial class History : Form
    {
        AccountInfo I;
        public History(AccountInfo parameterI)
        {
            InitializeComponent();
            I = parameterI;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Options o = new Options(I);
            o.Show();
            Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string[] GameReference = {"BlackJack", "Crazy 8", "War" };

            bool nohistory = true;
            for (int i = 7; i > -1; i--)
            {
                if (I.VHistory[i, 1] > 0)
                {
                    nohistory = false;
                    lblHistory.Text += "You played " + GameReference[I.VHistory[i, 0]];
                    if (I.VHistory[i, 1] == 1) { lblHistory.Text += "   You won that game \n \n"; }
                    else { lblHistory.Text += "   You lost that game \n\n"; }
                }
            }

            if (nohistory) { lblHistory.Text = "No History. Play games to see your history log."; }
        }
    }
}
