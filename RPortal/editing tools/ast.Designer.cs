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
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.iD = new System.Windows.Forms.TextBox();
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
            this.search2 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(143, 185);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(249, 185);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 1;
            // 
            // iD
            // 
            this.iD.Location = new System.Drawing.Point(219, 95);
            this.iD.Name = "iD";
            this.iD.Size = new System.Drawing.Size(100, 20);
            this.iD.TabIndex = 2;
            // 
            // pnumber
            // 
            this.pnumber.Enabled = false;
            this.pnumber.Location = new System.Drawing.Point(143, 211);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(100, 20);
            this.pnumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "App ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number:";
            // 
            // write
            // 
            this.write.Enabled = false;
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.addy.Location = new System.Drawing.Point(144, 236);
            this.addy.Name = "addy";
            this.addy.Size = new System.Drawing.Size(194, 20);
            this.addy.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address:";
            // 
            // city
            // 
            this.city.Enabled = false;
            this.city.Location = new System.Drawing.Point(344, 236);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(111, 20);
            this.city.TabIndex = 12;
            this.city.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // state
            // 
            this.state.Enabled = false;
            this.state.Location = new System.Drawing.Point(461, 236);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(40, 20);
            this.state.TabIndex = 13;
            this.state.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // zip
            // 
            this.zip.Enabled = false;
            this.zip.Location = new System.Drawing.Point(507, 236);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(65, 20);
            this.zip.TabIndex = 14;
            // 
            // callcenter
            // 
            this.callcenter.Enabled = false;
            this.callcenter.Location = new System.Drawing.Point(338, 294);
            this.callcenter.Name = "callcenter";
            this.callcenter.Size = new System.Drawing.Size(66, 20);
            this.callcenter.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Call Center:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(142, 268);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 20);
            this.email.TabIndex = 17;
            // 
            // ptft
            // 
            this.ptft.Enabled = false;
            this.ptft.Location = new System.Drawing.Point(142, 294);
            this.ptft.Name = "ptft";
            this.ptft.Size = new System.Drawing.Size(40, 20);
            this.ptft.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "PT/FT:";
            // 
            // shift
            // 
            this.shift.Enabled = false;
            this.shift.Location = new System.Drawing.Point(225, 294);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(40, 20);
            this.shift.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Shift:";
            // 
            // search2
            // 
            this.search2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search2.Location = new System.Drawing.Point(325, 95);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(117, 23);
            this.search2.TabIndex = 4;
            this.search2.Text = "Search by AppID";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset
            // 
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(289, 510);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(39, 23);
            this.reset.TabIndex = 25;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 39);
            this.label10.TabIndex = 26;
            this.label10.Text = "Applicant Editor";
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
            // ast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 545);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.logo);
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
            this.Controls.Add(this.iD);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Name = "ast";
            this.Text = "RPortal - Applicant Editor Tool";
            this.Load += new System.EventHandler(this.ast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox iD;
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
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button back;
    }
}

