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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void mst_Click(object sender, EventArgs e)
        {
            var myForm = new mst();
            myForm.Show();
            this.Hide();
        }

        private void ast_Click(object sender, EventArgs e)
        {
            var myForm = new ast();
            myForm.Show();
            this.Hide();
        }

        public void main_Load(object sender, EventArgs e)
        {
            //AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            if (User2.IsAdmin == false)
            {
                ast.Hide();
            }
            if (User1.IsAdmin == true)
            {
                ast.Show();
            }
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            //Console.WriteLine("I'm out of here");
            //Form.ActiveForm.Close();
        }
    
    //
    //
    
    
    
    
    
    
    }
}
