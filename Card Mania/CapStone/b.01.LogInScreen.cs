using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CapStone
{
    public partial class LogInScreen : Form
    {
        //Sets username
        static public string u;

        public LogInScreen()
        {
            InitializeComponent();
            SoundPlayer sp = new SoundPlayer(Environment.CurrentDirectory + @"\sounds\main.wav");
            sp.Play();

            MaximizeBox = false;
        }

        //When the user attempts to log in
        private void LogInScreen_Load(object sender, EventArgs e)
        {
            //Displays user with welcome message and greets them by their computer username -- uses environmental variable username
            lblTitle.Text = "Welcome " + Environment.UserName;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Makes new directory that holds all usernames if it doesnt already exist.
            if (Directory.Exists(@".\userinfo") == false) Directory.CreateDirectory(@".\userinfo");

            //If the username textbox is empty, messagebox will ask user to enter a usename
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter a username");
            }

            //If the username does not exist it will display a message box saying "username not found"
            else if (Directory.Exists(@".\userinfo\" + txtUsername.Text))
            {
                //If the file password (correct password) with the entered password in textbox.
                if (File.ReadAllText(@".\userinfo\" + txtUsername.Text + @"\password.txt") == txtPassword.Text)
                {
                    //Sets username variable.
                    u = txtUsername.Text;

                    /* AccountInfo DEFAULT constructor. Holds account Information. Default constructor is called if account is already made 
                    and user is attempting to log in. */
                    AccountInfo I = new AccountInfo();

                    //Hides this form and opens the main menu.
                    Hide();
                    MainMenu main = new MainMenu(I, false);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }
        }

        //When the user attempts to sign up.
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Makes new directory that holds all usernames if it doesnt already exist.
            if (Directory.Exists(@".\userinfo") == false) Directory.CreateDirectory(@".\userinfo");

            //Hides this form and opens sign up form
            Hide();
            SignUp su = new SignUp();
            su.Show();
        }
    }
    
}
