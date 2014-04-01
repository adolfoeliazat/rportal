namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.iD = new System.Windows.Forms.TextBox();
            this.search1 = new System.Windows.Forms.Button();
            this.pnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.write = new System.Windows.Forms.Button();
            this.addy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.callcenter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.ptft = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.shift = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search2 = new System.Windows.Forms.Button();
            this.search3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(143, 154);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(249, 154);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 1;
            // 
            // iD
            // 
            this.iD.Enabled = false;
            this.iD.Location = new System.Drawing.Point(355, 154);
            this.iD.Name = "iD";
            this.iD.Size = new System.Drawing.Size(100, 20);
            this.iD.TabIndex = 2;
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(509, 359);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(117, 23);
            this.search1.TabIndex = 3;
            this.search1.Text = "Search by First + Last";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.read_Click);
            // 
            // pnumber
            // 
            this.pnumber.Enabled = false;
            this.pnumber.Location = new System.Drawing.Point(143, 180);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(100, 20);
            this.pnumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "App ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number:";
            // 
            // write
            // 
            this.write.Enabled = false;
            this.write.Location = new System.Drawing.Point(551, 510);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(75, 23);
            this.write.TabIndex = 9;
            this.write.Text = "Write";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // addy
            // 
            this.addy.Enabled = false;
            this.addy.Location = new System.Drawing.Point(144, 205);
            this.addy.Name = "addy";
            this.addy.Size = new System.Drawing.Size(194, 20);
            this.addy.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address:";
            // 
            // city
            // 
            this.city.Enabled = false;
            this.city.Location = new System.Drawing.Point(344, 205);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(111, 20);
            this.city.TabIndex = 12;
            this.city.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // state
            // 
            this.state.Enabled = false;
            this.state.Location = new System.Drawing.Point(461, 205);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(40, 20);
            this.state.TabIndex = 13;
            this.state.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // zip
            // 
            this.zip.Enabled = false;
            this.zip.Location = new System.Drawing.Point(507, 205);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(65, 20);
            this.zip.TabIndex = 14;
            // 
            // callcenter
            // 
            this.callcenter.Enabled = false;
            this.callcenter.Location = new System.Drawing.Point(417, 271);
            this.callcenter.Name = "callcenter";
            this.callcenter.Size = new System.Drawing.Size(66, 20);
            this.callcenter.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Call Center:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email:";
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(142, 237);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 20);
            this.email.TabIndex = 17;
            // 
            // ptft
            // 
            this.ptft.Enabled = false;
            this.ptft.Location = new System.Drawing.Point(142, 263);
            this.ptft.Name = "ptft";
            this.ptft.Size = new System.Drawing.Size(40, 20);
            this.ptft.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "PT/FT:";
            // 
            // shift
            // 
            this.shift.Enabled = false;
            this.shift.Location = new System.Drawing.Point(281, 267);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(40, 20);
            this.shift.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Shift:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.telenetwork_265x42;
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(509, 388);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(117, 23);
            this.search2.TabIndex = 4;
            this.search2.Text = "Search by AppID";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.button1_Click);
            // 
            // search3
            // 
            this.search3.Location = new System.Drawing.Point(509, 417);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(117, 23);
            this.search3.TabIndex = 24;
            this.search3.Text = "Search by Email";
            this.search3.UseVisualStyleBackColor = true;
            this.search3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 545);
            this.Controls.Add(this.search3);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ptft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.callcenter);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addy);
            this.Controls.Add(this.write);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.iD);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox iD;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.TextBox pnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.TextBox addy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox callcenter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox ptft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox shift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Button search3;
    }
}

