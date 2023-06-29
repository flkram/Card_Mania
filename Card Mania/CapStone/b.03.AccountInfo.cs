using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CapStone
{
    public class AccountInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }
        public int Refunds { get; set; }
        public int[] Stats { get; set; }
        public int[,] VHistory { get; set; }

        public AccountInfo()
        { 
            UserName = LogInScreen.u;

            //FileStream that reads the user's password, and sets it to the Password property.
            FileStream fsp = new FileStream(@".\userinfo\" + UserName + @"\password.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader srp = new StreamReader(fsp);
            Password = srp.ReadLine();
            srp.Close();
            fsp.Close();

            //File stream that reads the money and assigns it to the Money property.
            FileStream fsm = new FileStream(@".\userinfo\" + UserName + @"\money.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader srm = new StreamReader(fsm);
            Money = Convert.ToInt32(srm.ReadLine());
            srm.Close();
            fsm.Close();

            //File stream the reads the amount of times a user has refunded and sets it to the money property.
            FileStream fsr = new FileStream(@".\userinfo\" + UserName + @"\refunds.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader srr = new StreamReader(fsr);
            Refunds = Convert.ToInt32(srr.ReadLine());
            srr.Close();
            fsr.Close();

            //6-length array that stores how many wins losses of each game. 0 and 1 are wins/losses for blackjack. 2 and 3 are for crazy 8
            // 4 and 5 are for war 
            Stats = new int[6];
            string x;
            FileStream fss = new FileStream(@".\userinfo\" + UserName + @"\stats.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader srs = new StreamReader(fss);
            for (int i = 0; i < 6; i++)
            {
                x = srs.ReadLine();
                Stats[i] = Convert.ToInt32(x);
            }
            srs.Close();
            fss.Close();

            VHistory = new int[8, 2];
            string y;
            string z;
            FileStream fsh = new FileStream(@".\userinfo\" + UserName + @"\VHistoryg.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader shs = new StreamReader(fsh);
            FileStream fsh2 = new FileStream(@".\userinfo\" + UserName + @"\VHistoryw.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader shs2 = new StreamReader(fsh2);
            for (int i = 0; i < 8; i++)
            {
                try
                {
                    y = shs.ReadLine();
                    VHistory[i, 0] = Convert.ToInt32(y);
                    z = shs2.ReadLine();
                    VHistory[i, 1] = Convert.ToInt32(z);
                }
                catch (FormatException)
                {
                    //Leaves VHistory array slot empty
                }
            }
            fsh.Close();
            shs.Close();
            fsh2.Close();
            shs2.Close();
        }

        public AccountInfo(string username, string password)
        {
            FileStream fsu = new FileStream(@".\userinfo\" + username + @"\username.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter swu = new StreamWriter(fsu);
            swu.Write(username);
            UserName = username;
            swu.Close();

            FileStream fsp = new FileStream(@".\userinfo\" + username + @"\password.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter swp = new StreamWriter(fsp);
            swp.Write(password);
            Password = password;
            swp.Close();

            FileStream fsm = new FileStream(@".\userinfo\" + username + @"\money.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swm = new StreamWriter(fsm);
            swm.Write("50");
            Money = 50;
            swm.Close();

            FileStream fsr = new FileStream(@".\userinfo\" + username + @"\refunds.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swr = new StreamWriter(fsr);
            swr.Write("0");
            Refunds = 0;
            swr.Close();

            FileStream fss = new FileStream(@".\userinfo\" + username + @"\stats.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sws = new StreamWriter(fss);
            Stats = new int[6];
            for (int i = 0; i < 6; i++)
            {
                sws.WriteLine("0");
                Stats[i] = 0;
            }
            sws.Close();

            VHistory = new int[8, 2];
            FileStream fsh = new FileStream(@".\userinfo\" + username + @"\VHistoryg.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            FileStream fsh2 = new FileStream(@".\userinfo\" + username + @"\VHistoryw.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
        }

        public void Refund()
        {
            Refunds += 1;
            FileStream fsr = new FileStream(@".\userinfo\" + UserName + @"\refunds.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swr = new StreamWriter(fsr);
            swr.Write(Refunds);
            swr.Close();

            Money += 50;
            FileStream fsm = new FileStream(@".\userinfo\" + UserName + @"\money.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swm = new StreamWriter(fsm);
            swm.Write(Money);
            swm.Close();
        }

        public int StartGame()
        {
            int BettingAmount = 0;

            string r = Interaction.InputBox("How much money would you like to bet?");
            if (r == "")
            {
                return -1;
            }
            else
            {
                bool error = false;
                try
                {
                    BettingAmount = Convert.ToInt32(r);
                    if (BettingAmount > Money) throw new InvalidBettingAmountException();
                    if (BettingAmount < 1) throw new BetMoreMoneyException();
                }
                catch 
                {
                    error = true;
                }
                
                if (error)
                {
                    return StartGame();
                }
                else
                {
                    Money -= BettingAmount;
                    FileStream fsm = new FileStream(@".\userinfo\" + UserName + @"\money.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    StreamWriter swm = new StreamWriter(fsm);
                    swm.Write(Money);
                    swm.Close();
                    return BettingAmount * 2;
                }
              
            }

        }

        public bool EndGame(int bet, int game, bool win, bool force)
        {
            //game 0 is blackjack / 1 is crazy 8 / 2 is war 

            if (win) { Money += bet; }
            FileStream fsm = new FileStream(@".\userinfo\" + UserName + @"\money.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swm = new StreamWriter(fsm);
            swm.Write(Money);
            swm.Close();
            fsm.Close();

            FileStream fss = new FileStream(@".\userinfo\" + UserName + @"\stats.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sws = new StreamWriter(fss);
            if (win) { Stats[(2 * game)] += 1; }
            else { Stats[(2 * game) + 1] += 1; }
            for (int i = 0; i < 6; i++)
            {
                sws.WriteLine(Stats[i]);
            }
            sws.Close();
            fss.Close();

            bool found;
            int VHistoryspot = 0;
            do
            {
                if (VHistory[VHistoryspot, 1] == 0)
                {
                    found = true;
                    if (win)
                    {
                        VHistory[VHistoryspot, 1] = 1;
                    }
                    else
                    {
                        VHistory[VHistoryspot, 1] = 2;
                    }
                    VHistory[VHistoryspot, 0] = game;
                }
                else
                {
                    found = false;
                    VHistoryspot += 1;
                }
            } while (found == false & VHistoryspot < 8);

            if (found == false)
            {
                for (int i = 1; i < 8; i++)
                {
                    VHistory[i - 1, 0] = VHistory[i, 0];
                    VHistory[i - 1, 1] = VHistory[i, 1];
                }
                VHistory[8, 0] = game;
                if (win) { VHistory[8, 1] = 1; }
                else { VHistory[8, 1] = 2; }
            }

            FileStream fsh = new FileStream(@".\userinfo\" + UserName + @"\VHistoryg.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swh = new StreamWriter(fsh);
            FileStream fsh2 = new FileStream(@".\userinfo\" + UserName + @"\VHistoryw.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter swh2 = new StreamWriter(fsh2);
            for (int i = 0; i < 8; i++)
            {
                swh.WriteLine(VHistory[i, 0].ToString());
                swh2.WriteLine(VHistory[i, 1].ToString());
            }
            swh.Close();
            fsh.Close();
            swh2.Close();
            fsh2.Close();

            if (force == false)
            {
                DialogResult r;
                if (win)
                {
                    r = MessageBox.Show("You won! Would you like to play again?", "", MessageBoxButtons.YesNo);
                }
                else
                {
                    r = MessageBox.Show("You lost. Would you like to play again?", "", MessageBoxButtons.YesNo);
                }

                if (r == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    MainMenu m = new MainMenu(this, true);
                    m.Show();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
