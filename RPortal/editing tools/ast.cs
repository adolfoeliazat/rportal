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
        //this is our xport table
        public static int BGID;
        public static string FN;
        public static string MN;
        public static string LN;
        public static string ADD;
        public static string CTY;
        public static string STA;
        public static string ZIPC;
        public static string PHONENUM;
        public static string SSN;
        public static string DOB;// = DateTime.ParseExact("2014-04-05 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",System.Globalization.CultureInfo.InvariantCulture);
        public static DateTime DTDOB;
        public static DateTime SIGNED;
        public static int APPID;
        public static DateTime RUNDATE;
        public static string RESULT;
        public static string SUFFIX;
        public static string MAIDENNAME;

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

        private void write_Click(object sender, EventArgs e)// write to table - disabled for now
        {
            SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            conn.Close();
            try
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@id", iD.Text.Trim());
                cmd.Parameters.AddWithValue("@Fname", firstname.Text);
                cmd.Parameters.AddWithValue("@Mname", middlename.Text);
                cmd.Parameters.AddWithValue("@Lname", lastname.Text);
                cmd.Parameters.AddWithValue("@Addy", addy.Text);
                cmd.Parameters.AddWithValue("@City", city.Text);
                cmd.Parameters.AddWithValue("@State", state.Text);
                cmd.Parameters.AddWithValue("@Zip", zip.Text);
                cmd.Parameters.AddWithValue("@Phone", pnumber.Text);
                cmd.Parameters.AddWithValue("@SSN", ssn.Text);
                cmd.Parameters.AddWithValue("@DOB", dob.Text);
                cmd.CommandText = "UPDATE PreHire.dbo.Background_Check SET fname=@Fname, mname=@Mname, lname=@Lname, addr=@Addy, city=@City, st=@State, zip=@Zip, phone=@Phone, ssn=@SSN, dob=@DOB WHERE appid=@id";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Database Updated.", "Success");
            }
            catch (SqlException)
            {
                MessageBox.Show("There was a SQL comm error.", "SQL Error");
            }
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
            conn.Close();
            conn.Open();
            cmd.CommandText = "select * from PreHire.dbo.Background_Check where appid='" + iD.Text.Trim() + "'";
            cmd.Connection = conn;
            rdr = cmd.ExecuteReader();
            bool temp = false;
            while (rdr.Read())
            {
                int x;
                string dobTime = rdr["dob"].ToString();
                x = rdr.GetInt32(12);
                firstname.Text = rdr.GetString(1);
                middlename.Text = rdr.GetString(2);
                lastname.Text = rdr.GetString(3);
                addy.Text = rdr.GetString(4);
                city.Text = rdr.GetString(5);
                state.Text = rdr.GetString(6);
                zip.Text = rdr.GetString(7);
                pnumber.Text = rdr.GetString(8);
                ssn.Text = rdr.GetString(9);
                dob.Text = dobTime.ToString();
                iD.Text = x.ToString();
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("NO ENTRY FOUND", "SQL ERROR");
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
            /*
            if ((auths.IsAdmin) == (1)) 
            {
                try { addy.Enabled = true; state.Enabled = true; city.Enabled = true; zip.Enabled = true; pnumber.Enabled = true; write.Enabled = true; ptft.Enabled = true; shift.Enabled = true; callcenter.Enabled = true; }
                finally { MessageBox.Show("ADMIN POOOOOWER!", "DEBUG INFO"); }
            }
            */
        }

        private void back_Click(object sender, EventArgs e)
        {
            var myForm = new main();
            myForm.Show();
            this.Hide();
        }

        }
    }
