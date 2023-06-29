using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CapStone
{
    public partial class Options : Form
    {
        AccountInfo I;
        public Options(AccountInfo parameterI)
        {
            InitializeComponent();
            I = parameterI;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            lblAccount.Text = I.UserName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu(I, false);
            mm.Show();
            Close();
        }

        private void btnStatClear_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to clear your stats?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                FileStream fss = new FileStream(@".\userinfo\" + I.UserName + @"\stats.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter sws = new StreamWriter(fss);
                for (int i = 0; i < 6; i++)
                {
                    I.Stats[i] = 0;
                    sws.WriteLine("0");
                }
                sws.Close();
                fss.Close();
                MessageBox.Show("Stats have been cleared");
            }

        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            bool invalid;
            do
            {
                string pass = Interaction.InputBox("Enter your current password");
                if (pass == "")
                {
                    invalid = false;
                }
                else if (pass == I.Password)
                {
                    string newpass = Interaction.InputBox("Enter your new password");
                    if (newpass == "")
                    {
                        invalid = false;
                    }
                    else
                    {
                        bool invalid2;
                        do
                        {
                            string confirmpass = Interaction.InputBox("Confirm your new password");
                            if (newpass == "")
                            {
                                invalid2 = false;
                            }
                            else if (newpass == confirmpass)
                            {
                                I.Password = newpass;
                                FileStream fsp = new FileStream(@".\userinfo\" + I.UserName + @"\password.txt", FileMode.Open, FileAccess.ReadWrite);
                                StreamWriter swp = new StreamWriter(fsp);
                                swp.Write(newpass);
                                swp.Close();
                                fsp.Close();
                                MessageBox.Show("Password has been reset");
                                invalid2 = false;
                            }
                            else
                            {
                                MessageBox.Show("Passwords dont match");
                                invalid2 = true;
                            }
                        } while (invalid2);
                        invalid = false;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                    invalid = true;
                }
            } while (invalid);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History h = new History(I);
            h.Show();
            Close();
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure that you want to delete your account?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                bool invalid = false;
                do
                {
                    string pass = Interaction.InputBox("Enter your password");
                    if (pass == "")
                    {
                        invalid = false;
                    }
                    else if (pass == I.Password)
                    {
                        DialogResult r2 = MessageBox.Show("Once again, are you sure that you want to delete your account?", "", MessageBoxButtons.YesNo);
                        if (r2 == DialogResult.Yes)
                        {
                            invalid = false;

                            File.Delete(@".\userinfo\" + I.UserName + @"\username.txt");
                            File.Delete(@".\userinfo\" + I.UserName + @"\password.txt");
                            File.Delete(@".\userinfo\" + I.UserName + @"\stats.txt");
                            File.Delete(@".\userinfo\" + I.UserName + @"\money.txt");
                            File.Delete(@".\userinfo\" + I.UserName + @"\refunds.txt");
                            File.Delete(@".\userinfo\" + I.UserName + @"\VHistoryw.txt");
                            File.Delete(@".\userinfo\" + I.UserName + @"\VHistoryg.txt");
                            Directory.Delete(@".\userinfo\" + I.UserName);

                            LogInScreen l = new LogInScreen();
                            l.Show();
                            Close();
                        }
                    }
                    else
                    {
                        invalid = true;
                        MessageBox.Show("Incorrect Password");
                    }
                } while (invalid);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you would like to exit?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                LogInScreen l = new LogInScreen();
                l.Show();
                Close();
            }
        }
    }
}
