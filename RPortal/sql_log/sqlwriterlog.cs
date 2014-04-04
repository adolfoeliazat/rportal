using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.sql_log
{
    public partial class sqlwriterlog : Form
    {
        public sqlwriterlog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sqlwriterlog_Load(object sender, EventArgs e)
        {
            if ((richTextBox1.Text)==(null))
            {
                try { button1.Enabled = false; }
                finally { MessageBox.Show("DEBUG!"); }
            }     
        }
    }
}
