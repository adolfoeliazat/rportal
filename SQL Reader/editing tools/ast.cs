/*
____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		
(c) 2014 TeleNetwork Inc.
Created by David Trimm
 AST.cs - Applicant Search Tool / Editor  == This file enables a SUPERUSER or ADMIN to make limited database changes.
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


namespace WindowsFormsApplication1
{
    public partial class ast : Form
    {
        SqlConnection con = new SqlConnection("server=itdev.corp.telenetwork.com;Database=dttests;User=sa; PWD=gR!FfiN-;");
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;

        public ast()
        {
            InitializeComponent();
        }

        private void read_Click(object sender, EventArgs e)// read table by first and last
        {
            //adding a reader conn for access to the recruiting db
            conn.Open();

            cmd.CommandText = "select * from PreHire.dbo.Applicants where fname='" + firstname.Text.Trim() + "' AND lname='" + lastname.Text.Trim() + "'";
            cmd.Connection = conn;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                int x;
                int z;
                x = rdr.GetInt32(0);
                z = rdr.GetByte(9);
                firstname.Text = rdr.GetString(1);
                lastname.Text = rdr.GetString(2);
                addy.Text = rdr.GetString(3);
                city.Text = rdr.GetString(4);
                state.Text = rdr.GetString(5);
                zip.Text = rdr.GetString(6);
                pnumber.Text = rdr.GetString(8);
                email.Text = rdr.GetString(10);
                ptft.Text = rdr.GetString(11);
                shift.Text = rdr.GetString(13);
               // y = rdr.GetDateTime(3);
                //rdr.GetDateTime(y);
                iD.Text = x.ToString();
                callcenter.Text = z.ToString();
                //deleted.Text = y.ToString();
                //iD.Text = rdr.GetString(3);
                //deleted.Text = rdr.GetString(4);
                //textBox6.Text = rdr.GetString(5);
                //textBox7.Text = rdr.GetString(6);
                //textBox8.Text = rdr.GetString(7);
                //textBox9.Text = rdr.GetString(8);
                //textBox10.Text = rdr.GetString(9);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("NO ENTRY FOUND", "SQL ERROR");
            conn.Close();
            conn.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PreHire.dbo.Applicants", conn);
            da.Fill(ds, "PreHire.dbo.Applicants");
            conn.Close();
        }

        private void write_Click(object sender, EventArgs e)// write to table - disabled for now
        {
            /*
            //SqlConnection conn = new SqlConnection("server=itdev.corp.telenetwork.com;Database=dttests;User=sa; PWD=gR!FfiN-;");
            //SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //DataSet ds = new DataSet();
            con.Close();
            try
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select fname, lname from dbo.dtable";
                cmd.Parameters.AddWithValue("@Fname", firstname.Text);
                cmd.Parameters.AddWithValue("@Lname", lastname.Text);
                cmd.CommandText = "insert into dbo.dtable (fname, lname) values (@Fname, @Lname)";
                // cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.ExecuteNonQuery();
               // conn.Open();
                //cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a SQL comm error.", "SQL Error");
            }
             */
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// search by appid
        {
            conn.Open();
            cmd.CommandText = "select * from PreHire.dbo.Applicants where appid='" + iD.Text.Trim() + "'";
            cmd.Connection = conn;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                int x;
                int z;
                x = rdr.GetInt32(0);
                z = rdr.GetByte(9);
                firstname.Text = rdr.GetString(1);
                lastname.Text = rdr.GetString(2);
                addy.Text = rdr.GetString(3);
                city.Text = rdr.GetString(4);
                state.Text = rdr.GetString(5);
                zip.Text = rdr.GetString(6);
                pnumber.Text = rdr.GetString(8);
                email.Text = rdr.GetString(10);
                ptft.Text = rdr.GetString(11);
                shift.Text = rdr.GetString(13);
                // y = rdr.GetDateTime(3);
                //rdr.GetDateTime(y);
                iD.Text = x.ToString();
                callcenter.Text = z.ToString();
                //deleted.Text = y.ToString();
                //iD.Text = rdr.GetString(3);
                //deleted.Text = rdr.GetString(4);
                //textBox6.Text = rdr.GetString(5);
                //textBox7.Text = rdr.GetString(6);
                //textBox8.Text = rdr.GetString(7);
                //textBox9.Text = rdr.GetString(8);
                //textBox10.Text = rdr.GetString(9);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("NO ENTRY FOUND", "SQL ERROR");
            conn.Close();
            conn.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PreHire.dbo.Applicants", conn);
            da.Fill(ds, "PreHire.dbo.Applicants");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)// search by email
        {
            conn.Close();
            conn.Open();
            cmd.CommandText = "select * from PreHire.dbo.Applicants where email='" + email.Text.Trim() + "'";
            cmd.Connection = conn;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                int x;
                int z;
                x = rdr.GetInt32(0);
                z = rdr.GetByte(9);
                firstname.Text = rdr.GetString(1);
                lastname.Text = rdr.GetString(2);
                addy.Text = rdr.GetString(3);
                city.Text = rdr.GetString(4);
                state.Text = rdr.GetString(5);
                zip.Text = rdr.GetString(6);
                pnumber.Text = rdr.GetString(8);
                email.Text = rdr.GetString(10);
                ptft.Text = rdr.GetString(11);
                shift.Text = rdr.GetString(13);
                // y = rdr.GetDateTime(3);
                //rdr.GetDateTime(y);
                iD.Text = x.ToString();
                callcenter.Text = z.ToString();
                //deleted.Text = y.ToString();
                //iD.Text = rdr.GetString(3);
                //deleted.Text = rdr.GetString(4);
                //textBox6.Text = rdr.GetString(5);
                //textBox7.Text = rdr.GetString(6);
                //textBox8.Text = rdr.GetString(7);
                //textBox9.Text = rdr.GetString(8);
                //textBox10.Text = rdr.GetString(9);
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("NO ENTRY FOUND", "SQL ERROR");
            conn.Close();
            conn.Open();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PreHire.dbo.Applicants", conn);
            da.Fill(ds, "PreHire.dbo.Applicants");
            conn.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            RecursiveClearTextBoxes(this.Controls);
        }

        private void RecursiveClearTextBoxes(Control.ControlCollection cc)
        {

            foreach (Control ctrl in cc)
            {

                TextBox tb = ctrl as TextBox;

                if (tb != null)

                    tb.Clear();

                else

                    RecursiveClearTextBoxes(ctrl.Controls);

            }

        }

        private void ast_Load(object sender, EventArgs e)
        {
            if ((auths.IsAdmin) == (1)) 
            {
                try { addy.Enabled = true; state.Enabled = true; city.Enabled = true; zip.Enabled = true; pnumber.Enabled = true; write.Enabled = true; ptft.Enabled = true; shift.Enabled = true; callcenter.Enabled = true; }
                finally { MessageBox.Show("ADMIN POOOOOWER!", "DEBUG INFO"); }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            var myForm = new main();
            myForm.Show();
            this.Hide();
        }

        }
    }
