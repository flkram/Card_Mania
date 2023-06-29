using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapStone
{
    public class InvalidBettingAmountException : Exception
    {
        public InvalidBettingAmountException()
        {
            MessageBox.Show("You dont have that much money");
        }
    }

    public class BetMoreMoneyException : Exception
    { 
        public BetMoreMoneyException()
        {
            MessageBox.Show("You need to bet atleast one dollar");
        }
    }

}
