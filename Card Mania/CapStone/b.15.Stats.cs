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
    public partial class Stats : Form
    {
        AccountInfo I;
        public Stats(AccountInfo parameterI)
        {
            I = parameterI;
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {

            label1.Text = "User: " + I.UserName;

            string bj;
            if (I.Stats[1] == 0) { bj = "Perfect"; }
            else { bj = (Convert.ToDecimal(I.Stats[0]) / Convert.ToDecimal(I.Stats[1])).ToString(); }
            lblBJ.Text = "Black Jack:" +
                "\n         Wins: " + I.Stats[0] +
                "\n         Losses: " + I.Stats[1] +
                "\n         W/L Ratio: " + bj;

            string c8;
            if (I.Stats[3] == 0) { c8 = "Perfect"; }
            else { c8 = (Convert.ToDecimal(I.Stats[2]) / Convert.ToDecimal(I.Stats[3])).ToString(); }
            lblC8.Text = "Crazy 8:" +
                "\n         Wins: " + I.Stats[2] +
                "\n         Losses: " + I.Stats[3] +
                "\n         W/L Ratio: " + c8;

            string w;
            if (I.Stats[5] == 0) { w = "Perfect"; }
            else { w = (Convert.ToDecimal(I.Stats[4]) / Convert.ToDecimal(I.Stats[5])).ToString(); }
            lblW.Text = "War:" +
                "\n         Wins: " + I.Stats[4] +
                "\n         Losses: " + I.Stats[5] +
                "\n         W/L Ratio: " + w;
        }
    }
}
