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
       public static string UN;
       //public static string PW;
        
        
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void validate_Click(object sender, EventArgs e)
        {

            //PW = password.Text;
            string U1 = (User1.UN);
            string U2 = (User2.UN);
            string U1P = (User1.PW);
            string U2P = (User2.PW);
            //Boolean U1G = User1.GP;
            //Boolean U2G = User2.GP;
            int logged = 0;
            int log;
            log = logged;

            // This needs to be redone agaaaain
            if (userName.Text == @U1 && password.Text == @U1P)
            {
                var myForm = new main();
                myForm.Show();
                this.Hide();
                log = 1;
                auths.IsAdmin += 1;
            }
            if (userName.Text == @U2 && password.Text == @U2P)
            {
                var myForm = new main();
                myForm.Show();
                this.Hide();
                log = 1;
                auths.IsAdmin += 0;
            }


           // else if (!(null == userName.Text) && !(null == password.Text))
            //{ 
             //   MessageBox.Show("You must enter a User Name and Password.", "Login Error");
             //   log = 1;
           // }
            if (log == 0)
            {
                MessageBox.Show("Invalid username or password.", "Login Error."); 
            }

            
        }
    }
}
