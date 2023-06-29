using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone
{
    public class Deck
    {
        private List<Card> fdeck;
        private List<Card> fpHand;
        private List<Card> fcHand;

        public List<Card> deck
        { 
            get { return fdeck; }
            set { fdeck = value; }
        }
        public List<Card> pHand
        {
            get { return fpHand; }
            set { fpHand = value; }
        }
        public List<Card> cHand
        {
            get { return fcHand; }
            set { fcHand = value; }
        }


        public void Shuffle()
        {
            deck = new List<Card>();
            cHand = new List<Card>();
            pHand = new List<Card>();

            bool[,] CardsTaken = new bool[13, 4];

            Random r = new Random();
            for (int i = 0; i < 52; i++)
            {
                bool flag;

                do
                {
                    flag = false;
                    int rCardN = r.Next(0, 13);
                    int rCardS = r.Next(0, 4);

                    if (CardsTaken[rCardN, rCardS] == true)
                    {
                        flag = true;
                    }
                    else
                    {
                        CardsTaken[rCardN, rCardS] = true;
                        deck.Add(new Card());
                        deck[i].IntNumber = rCardN;
                        deck[i].IntSuit = rCardS;
                        deck[i].Set();
                    }

                } while (flag == true);
            }
        }
    }
}
