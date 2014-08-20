using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApplication1.homespace
{
    public partial class homespace : Telerik.WinControls.UI.RadForm
    {
        public homespace()
        {
            InitializeComponent();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            var myForm = new aboutus();
            myForm.Show();
            //this.Hide();
        }
    }
}
