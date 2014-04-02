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

        public void validate_Click(object sender, EventArgs e)
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

            if (Check1 == @U2 && Check2 == @U2P)
            {
                try { auths.IsAdmin = 0; }
                finally
                {
                    var myForm = new main();
                    myForm.Show();
                    this.Hide();
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
            auths.IsAdmin = 2;
        }
    }
}
