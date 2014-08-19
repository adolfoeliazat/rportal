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
        //enum CallCenters { SM, AUS, GF, DTX, DCA }// I would like to have each callcenter enumd, this needs to reflect the sqldb entry for callcenters..
        // note: we now use bu or business unit to identify centers of operations.
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

        private void interview_Load(object sender, EventArgs e)// set our default table view to load by the SM call center
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
            dataGridView.ReadOnly = true;
            // Admin Only Functions Here
            write.Hide();
            if ((auths.IsAdmin) == (1)) {
                try { 
                    dataGridView.ReadOnly = true;
                    write.Show();
                    }
                finally { //MessageBox.Show("ADMIN EDITING GRANTED","DEBUG INFO"); 
                        }
            }
            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
