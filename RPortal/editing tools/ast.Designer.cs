namespace WindowsFormsApplication1
{
    partial class ast
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
            this.iD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search2 = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ssn = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnumber = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // iD
            // 
            this.iD.Location = new System.Drawing.Point(219, 146);
            this.iD.Name = "iD";
            this.iD.Size = new System.Drawing.Size(100, 20);
            this.iD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "App ID:";
            // 
            // search2
            // 
            this.search2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search2.Location = new System.Drawing.Point(325, 146);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(117, 23);
            this.search2.TabIndex = 4;
            this.search2.Text = "Search by AppID";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApplication1.Properties.Resources.telenetwork_265x42;
            this.logo.Location = new System.Drawing.Point(173, 1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(268, 50);
            this.logo.TabIndex = 23;
            this.logo.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 42);
            this.label11.TabIndex = 27;
            this.label11.Text = "*";
            this.label11.Visible = false;
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(2, 521);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 23);
            this.back.TabIndex = 58;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Middle Name:";
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(257, 227);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(100, 20);
            this.middlename.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "DOB:";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(152, 330);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(193, 20);
            this.dob.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "SSN:";
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(152, 304);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(193, 20);
            this.ssn.TabIndex = 70;
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(515, 278);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(65, 20);
            this.zip.TabIndex = 69;
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(469, 278);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(40, 20);
            this.state.TabIndex = 68;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(352, 278);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(111, 20);
            this.city.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Address:";
            // 
            // addy
            // 
            this.addy.Location = new System.Drawing.Point(152, 278);
            this.addy.Name = "addy";
            this.addy.Size = new System.Drawing.Size(194, 20);
            this.addy.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "First Name:";
            // 
            // pnumber
            // 
            this.pnumber.Location = new System.Drawing.Point(152, 253);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(99, 20);
            this.pnumber.TabIndex = 61;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(363, 227);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 60;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(152, 227);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(99, 20);
            this.firstname.TabIndex = 59;
            // 
            // write
            // 
            this.write.BackColor = System.Drawing.Color.Red;
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.write.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write.ForeColor = System.Drawing.Color.Black;
            this.write.Location = new System.Drawing.Point(334, 510);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(97, 23);
            this.write.TabIndex = 76;
            this.write.Text = "UPDATE";
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // reset
            // 
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(231, 510);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(97, 23);
            this.reset.TabIndex = 77;
            this.reset.Text = "Reset Forms";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(410, 39);
            this.label10.TabIndex = 78;
            this.label10.Text = "Background Check Editor";
            // 
            // ast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 545);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.write);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iD);
            this.Name = "ast";
            this.Text = "RPortal - Applicant Editor Tool";
            this.Load += new System.EventHandler(this.ast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox middlename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pnumber;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label10;
    }
}

