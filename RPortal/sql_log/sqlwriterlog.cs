/*
____________________              __         .__   
\______   \______   \____________/  |______  |  |  
 |       _/|     ___/  _ \_  __ \   __\__  \ |  |  
 |    |   \|    |  (  <_> )  | \/|  |  / __ \|  |__
 |____|_  /|____|   \____/|__|   |__| (____  /____/
        \/                                 \/      
		
(c) 2014 TeleNetwork Inc.
Created by David Trimm
 SQLWRITERLOG.cs - document in db what changes are made.
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
using System.IO;
using System.Runtime.Serialization;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1.sql_log
{
    public partial class sqlwriterlog : Form
    {
        public Form RefToBGE { get; set; }
        public static bool HasUserFiledForm;

        public sqlwriterlog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static DateTime GetNetworkTime()
        {
            //default Windows time server
            const string ntpServer = "time.nist.gov";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.Connect(ipEndPoint);

            //Stops code hang if NTP is blocked
            socket.ReceiveTimeout = 3000;

            socket.Send(ntpData);
            socket.Receive(ntpData);
            socket.Close();

            //Offset to get to the "Transmit Timestamp" field (time at which the reply departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        private void sqlwriterlog_Load(object sender, EventArgs e)
        {
            if (appby.Text.Length == 0) { appby.Text = "SysAdmins"; }
            HasUserFiledForm = false;
            DateTime x;
            x = GetNetworkTime();
            //time.Text = DateTime.Now.ToString();
            time.Text = x.ToString("yyyy-MM-dd HH:mm:ss");     // using network time
            username.Text = auths.WhosLoggedIn;
        }

        private void button1_Click(object sender, EventArgs e)// COMMIT TO THE DB
        {
            SqlConnection con = new SqlConnection("server=itdev.corp.telenetwork.com;Database=dttests;User=sa; PWD=gR!FfiN-;");
            SqlConnection conn = new SqlConnection("server=sql-prod.corp.telenetwork.com;Database=PreHire;User=sa; PWD=qwerty;");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            con.Close();
            // we require these to be filled out before sending them into the database
            if ((reason.Text.Length > 0) && (changed.Text.Length > 0))
            {
                try
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "select username, time, reasonforedit, whatwaschanged, approvedby from dbo.dbuauditor";
                    cmd.Parameters.AddWithValue("@un", username.Text);
                    cmd.Parameters.AddWithValue("@time", time.Text);
                    cmd.Parameters.AddWithValue("@reason", reason.Text);
                    cmd.Parameters.AddWithValue("@wwc", changed.Text);
                    cmd.Parameters.AddWithValue("@approved", appby.Text);
                    cmd.CommandText = "insert into dbo.dbuauditor (username, time, reasonforedit, whatwaschanged, approvedby) values (@un, @time, @reason, @wwc, @approved)";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    HasUserFiledForm = true;
                }

                catch (SqlException)
                {
                    MessageBox.Show("There was a SQL comm error. Contact an Administrator.", "SQL Error");
                    HasUserFiledForm = false;
                }

                finally
                {
                    if (sql_log.sqlwriterlog.HasUserFiledForm == true)
                    {
                        try
                        {/*
                            // Using update cmds I will insert the strings into sql. Update Soon. 
                            // Note to self. I need to update the db instead of inserting. My early attempt here resulted in a few dupes in the recruiting db.
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "select bgid, fname, mname, lname, addr, city, st, zip, phone, ssn, dob, signed, appid, rundate, result, suffix, maidenName from dbo.Background_Check";
                            //cmd.Parameters.AddWithValue("@BGID", bge.BGID);
                            cmd.Parameters.AddWithValue("@FN", ast.FN);
                            cmd.Parameters.AddWithValue("@MN", ast.MN);
                            cmd.Parameters.AddWithValue("@LN", ast.LN);
                            cmd.Parameters.AddWithValue("@ADDR", ast.ADD);
                            cmd.Parameters.AddWithValue("@CTY", ast.CTY);
                            cmd.Parameters.AddWithValue("@STA", ast.STA);
                            cmd.Parameters.AddWithValue("@ZIPC", ast.ZIPC);
                            cmd.Parameters.AddWithValue("@PHONENUM", ast.PHONENUM);
                            cmd.Parameters.AddWithValue("@SSN", ast.SSN);
                            cmd.Parameters.AddWithValue("@DOB", ast.DTDOB);
                            cmd.Parameters.AddWithValue("@SIGNED", ast.SIGNED);
                            cmd.Parameters.AddWithValue("@APPID", ast.APPID);
                            cmd.Parameters.AddWithValue("@RUNDATE", ast.RUNDATE);
                            cmd.Parameters.AddWithValue("@RESULT", ast.RESULT);
                            cmd.Parameters.AddWithValue("@SUFFIX", ast.SUFFIX);
                            cmd.Parameters.AddWithValue("@MAIDENNAME", ast.MAIDENNAME);
                            cmd.CommandText = "insert into dbo.Background_Check (fname, mname, lname, addr, city, st, zip, phone, ssn, dob, signed, appid, rundate, result, suffix, maidenName) values (@FN, @MN, @LN, @ADDR, @CTY, @STA, @ZIPC, @PHONENUM, @SSN, @DOB, @SIGNED, @APPID, @RUNDATE, @RESULT, @SUFFIX, @MAIDENNAME )";
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            */
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("There was a SQL comm error. Contact an Administrator.", "SQL Error");
                            this.Close();
                            var myForm = new main();
                            myForm.Show();
                        }
                        finally
                        {
                            // goto new bge
                            this.Close();
                            var myForm = new ast();
                            myForm.Show();
                            //this.RefToBGE.Show();
                            //this.Close();
                            MessageBox.Show("Background Check Database Updated!", "Update Complete");
                            if (sql_log.sqlwriterlog.HasUserFiledForm == true)
                            {
                                ast.BGID = 0;
                                ast.FN = null;
                                ast.MN = null;
                                ast.LN = null;
                                ast.ADD = null;
                                ast.CTY = null;
                                ast.STA = null;
                                ast.ZIPC = null;
                                ast.PHONENUM = null;
                                ast.SSN = null;
                                ast.DOB = null;
                                ast.APPID = 0;
                                ast.RESULT = null;
                                ast.SUFFIX = null;
                                ast.MAIDENNAME = null;
                            }

                        }
                    }
                }

            }
            else { MessageBox.Show("You have not filled out the required fields.", "ERROR"); }



        }

        private void appby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
