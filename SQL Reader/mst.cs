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
        DataSet ds = new DataSet();
        // dataGridView.DataSource = table.DefaultView;
        string select = "select * from PreHire.dbo.Applicants where fname='" + firstname.Text.Trim() + "' AND lname='" + lastname.Text.Trim() + "'";
        SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
        SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conn);
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

    private void button3_Click(object sender, EventArgs e)
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



    }
}
