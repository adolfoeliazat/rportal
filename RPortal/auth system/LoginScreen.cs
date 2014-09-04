/*
 ____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		

(c) 2014 TeleNetwork Inc.
Created by David Trimm

LoginScreen.cs - Updated User Login UI. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApplication1.auth_system
{
    public partial class LoginScreen : Telerik.WinControls.UI.ShapedForm
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            auths.IsAdmin = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
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
            Check1 = uN.Text;
            Check2 = pW.Text;
            // working for now.. still want this cleaned into seperate functions
            // starting to move in some of these admin checks, need to add superusers still
            if (Check1 == @U1 && Check2 == @U1P)
            {
                try { auths.IsAdmin = 1; }
                finally
                {
                    var myForm = new homespace.homespace();
                    myForm.Show();
                    var myForm2 = new main();
                    myForm2.Show();
                    this.Hide();
                    log = 1;
                }
            }
            //if (Check1 == @U2 && Check2 == @U2P)
            if ((auths.IsAdmin) == (0) && (Check1 == @U2 && Check2 == @U2P))
            {
                try
                {
                    var myForm = new homespace.homespace();
                    myForm.Show();
                    var myForm2 = new main();
                    myForm2.Show();
                    this.Hide();
                }
                finally
                {
                    log = 1;
                }
            }
            if (log == 0)
            {
                Telerik.WinControls.RadMessageBox.Show("Invalid username or password.", "Login Error.");
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
