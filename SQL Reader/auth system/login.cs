/*
 ____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		

(c) 2014 TeleNetwork Inc.
Created by David Trimm

LOGIN.cs - Handles our user authentication systems. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        
        public login() { InitializeComponent(); }
        private void label5_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void validate_Click(object sender, EventArgs e)//Validate our users creds
        {
            string U1 = (User1.UN);
            string U2 = (User2.UN);
            string U1P = (User1.PW);
            string U2P = (User2.PW);
            int logged = 0;
            int log;
            log = logged;
            string Check1;
            string Check2;
            Check1 = userName.Text;
            Check2 = password.Text;
            // working for now.. still want this cleaned into seperate functions
            // starting to move in some of these admin checks, need to add superusers still
                if (Check1 == @U1 && Check2 == @U1P)
           {
                try { auths.IsAdmin = 1; }
                finally
                {
                    var myForm = new main();
                    myForm.Show();
                    this.Hide();
                    log = 1;
                }
            }
                //if (Check1 == @U2 && Check2 == @U2P)
                if ((auths.IsAdmin)==(0))
            {
                try
                {
                    var myForm = new main();
                    myForm.Show();
                    this.Hide();
                }
                finally
                {
                    log = 1;
                }
            }
            if (log == 0)
            {
                MessageBox.Show("Invalid username or password.", "Login Error."); 
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            auths.IsAdmin = 0;
        }
    }
}
