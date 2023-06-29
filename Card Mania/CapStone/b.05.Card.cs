using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace CapStone
{
    public class Card
    {
        private int intNumber;
        public int IntNumber
        {
            get { return intNumber; }
            set { intNumber = value; }
        }

        private string intNumberString;
        public string IntNumberString
        {
            get { return intNumberString; }
            set { intNumberString = value; }
        }

        private int intSuit;
        public int IntSuit
        {
            get { return intSuit; }
            set { intSuit = value; }
        }

        private string intSuitString;
        public string IntSuitString
        {
            get { return intSuitString; }
            set { intSuitString = value; }
        }

        private PictureBox pb;
        public PictureBox PB
        {
            get { return pb; }
            set { pb = value; }
        }

        public void Set()
        {
            string[] ins = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] iss = new string[4] { "Club", "Spade", "Heart", "Diamond" };
            PB = new PictureBox();
            IntNumberString = ins[IntNumber];
            IntSuitString = iss[IntSuit];
            IntNumber += 1;
            PB.Image = Image.FromFile(Environment.CurrentDirectory + @"\cards\" + IntSuitString + IntNumber.ToString() + ".png");
            PB.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
