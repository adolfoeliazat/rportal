/*
 ____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		

(c) 2014 TeleNetwork Inc.
Created by David Trimm

homespace.cs - Main Application Window. 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.homespace
{
    public partial class homespace : Telerik.WinControls.UI.RadForm
    {
        public homespace()
        {
            InitializeComponent();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)//About Menu Button
        {
            var myForm = new aboutus();
            myForm.Show();
            //this.Hide();
        }

        private void homespace_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //Note: This now reflects the upcoming interviews query. This does how ever need to be sortable by BU.
            string select = @"SELECT a.wah,i.sid,i.appid,a.email,i.starttime,
									a.helpdesk,a.phone,a.fname,a.lname,
									case a.callcenter 
										when 1 then 'Aus' 
										when 2 then 'SM' 
										when 3 then 'Barnes' 
										when 7 then 'Fiber'
										when 8 then 'MTV'
										when 9 then 'DTX'
									end, i.stype 
								FROM 
									Prehire.dbo.Schedule i 
									LEFT JOIN Prehire.dbo.Applicants a 
										ON a.appid = i.appid 
								WHERE
									i.status = 'Open' AND 
									(   i.stype = 'Interview' OR 
										i.stype = '2nd Interview' OR 
										i.stype = '3rd Interview') AND 
									a.appstatus NOT LIKE 'hired' AND 
									a.appstatus NOT LIKE 'lost' 
								ORDER BY DATEDIFF(n,getdate(),i.starttime) ASC";
            SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(ds);
            radGridView1.ReadOnly = true;
            // Admin Only Functions Here
            //write.Hide();
           // if ((auths.IsAdmin) == (1))
           // {
            //    try
             //   {
             //       radGridView1.ReadOnly = true;
             //       write.Show();
             //   }
             //   finally
              //  { //MessageBox.Show("ADMIN EDITING GRANTED","DEBUG INFO"); 
              //  }
           // }
           // radGridView1.DataSource = ds.Tables[0];
        }
    }
}
