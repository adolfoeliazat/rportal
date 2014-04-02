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
            // can we determine the access group? If user then hide our db editor. If admin then show.
            //AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit); 
            if ((auths.IsAdmin) == (1))
            {
                ast.Show();
            }
            if ((auths.IsAdmin) == (0))
            {
                ast.Hide();
            }
            if ((auths.IsAdmin) == (2))
            {
                MessageBox.Show("err", "errrr");
                ast.Hide();
            }
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            //Console.WriteLine("I'm out of here");
            //Form.ActiveForm.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    //
    //
    
    
    
    
    
    
    }
}
