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

namespace CapStone
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        //When the user attempts to make an account
        private void btnMakeAccount_Click(object sender, EventArgs e)
        {
            //If there is no username entered
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter a username");
            }

            //If there is no password entered
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password");
            }

            //If the username is already taken
            else if (Directory.Exists(@".\userinfo\" + txtUsername.Text))
            {
                MessageBox.Show("Username already taken");
            }
            else
            {
                //If the password and confirm password textbox match.
                if (txtPassword.Text == txtPasswordConfirm.Text)
                {
                    //Creates the folder for the account.
                    Directory.CreateDirectory(@".\userinfo\" + txtUsername.Text);

                    /* AccountInfo DEFAULT constructor. Holds account Information. Overloaded constructor is called if account is new 
                   and user is attempting create the new account. */
                    AccountInfo I = new AccountInfo(txtUsername.Text, txtPassword.Text);

                    //Closes this form and opens main menu.
                    MainMenu mainmenu = new MainMenu(I, false);
                    mainmenu.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
        }

        //When the user attempts to go back to the log in screen.
        private void btnBack_Click(object sender, EventArgs e)
        {
            //Opens log in screen and closes this form.
            LogInScreen l = new LogInScreen();
            l.Show();
            Close();
        }
    }
}
