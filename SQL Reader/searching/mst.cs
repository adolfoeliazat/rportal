/*
____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		
(c) 2014 TeleNetwork Inc.
Created by David Trimm
 MST.cs - Mass Search Tool == 
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
    // 

    public partial class mst : Form
    {
        public mst()
        {
            InitializeComponent();
        }

    private void mst_Load(object sender, EventArgs e) // this will populate the mass listing on load
    {
        DataSet ds = new DataSet();
       // dataGridView.DataSource = table.DefaultView;
        string select = "SELECT TOP 25 * FROM PreHire.dbo.Applicants ORDER BY appid desc";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter); 
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void shift_TextChanged(object sender, EventArgs e)
    {

    }

    private void search1_Click(object sender, EventArgs e)//search by first + last name
    {
        // Lets search based off either first, last, or both..
     string select2;
         if ((firstname.Text)==(null))
         {
             string select = "select * from PreHire.dbo.Applicants where lname='" + lastname.Text.Trim() + "'";
             select2 = select;
         }
         if ((lastname.Text) == (null))
         {
             string select = "select * from PreHire.dbo.Applicants where fname='" + firstname.Text.Trim() + "'";
             select2 = select;
         }
         else 
         {
             string select = "select * from PreHire.dbo.Applicants where fname='" + firstname.Text.Trim() + "' AND lname='" + lastname.Text.Trim() + "'";
             select2 = select;
         }
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select2, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void button1_Click(object sender, EventArgs e)//search by last name
    {
        DataSet ds = new DataSet();
        // dataGridView.DataSource = table.DefaultView;
        string select = "select * from PreHire.dbo.Applicants where lname='" + lastname.Text.Trim() + "'";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void search3_Click(object sender, EventArgs e)//search by email
    {
        DataSet ds = new DataSet();
        // dataGridView.DataSource = table.DefaultView;
        string select = "select * from PreHire.dbo.Applicants where email='" + email.Text.Trim() + "'";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void button5_Click(object sender, EventArgs e)//search by reference
    {
        DataSet ds = new DataSet();
        // dataGridView.DataSource = table.DefaultView;
        string select = "select * from PreHire.dbo.Applicants where howheard='" + reference.Text.Trim() + "'";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void button3_Click(object sender, EventArgs e)// search by pt/ft
    {
        DataSet ds = new DataSet();
        // dataGridView.DataSource = table.DefaultView;
        string select = "select * from PreHire.dbo.Applicants where ptft='" + ptft.Text.Trim() + "'";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void button4_Click(object sender, EventArgs e)// search by shift
    {
        DataSet ds = new DataSet();
        string select = "select * from PreHire.dbo.Applicants where shift='" + shift.Text.Trim() + "'";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Fill(ds);
        dataGridView.ReadOnly = true;
        dataGridView.DataSource = ds.Tables[0];
    }

    private void back_Click(object sender, EventArgs e)// return to main
    {
        var myForm = new main();
        myForm.Show();
        this.Hide();
    }





    }
}
