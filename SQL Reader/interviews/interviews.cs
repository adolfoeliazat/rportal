/*
____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		
(c) 2014 TeleNetwork Inc.
Created by David Trimm
 INTERVIEWS.cs - Interview Previews, then select which interview in more depth needs to be edited. == 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.interviews
{
    public partial class interview : Form
    {
        public static enum CallCenters : int { SM, AUS, GF, DTX, DCA }
        public interview()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var myForm = new main();
            myForm.Show();
            this.Hide();
        }

        private void interview_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string select = @"SELECT TOP 5 * FROM dttests.dbo.scheduled a
                              WHERE center='SM'
                              ORDER BY time desc";
            //LEFT OUTER join [sql-prod].PreHire.dbo.Applicants e on e.appid=a.appid
            SqlConnection conn = new SqlConnection("server=itdev.corp.telenetwork.com;Database=dttests;User=sa; PWD=gR!FfiN-;");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
