namespace WindowsFormsApplication1.sql_log
{
    partial class sqlwriterlog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changed = new System.Windows.Forms.RichTextBox();
            this.reason = new System.Windows.Forms.RichTextBox();
            this.appby = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Red_Exclamation_Mark;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 211);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(178, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Who Authorized this update:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "Explain in detail what you changed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(43, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reason for this update:";
            // 
            // changed
            // 
            this.changed.Location = new System.Drawing.Point(191, 273);
            this.changed.Name = "changed";
            this.changed.Size = new System.Drawing.Size(408, 39);
            this.changed.TabIndex = 14;
            this.changed.Text = "";
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(172, 219);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(427, 48);
            this.reason.TabIndex = 12;
            this.reason.Text = "";
            // 
            // appby
            // 
            this.appby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appby.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appby.FormattingEnabled = true;
            this.appby.Items.AddRange(new object[] {
            "Epowers",
            "SysAdmins"});
            this.appby.Location = new System.Drawing.Point(332, 320);
            this.appby.MaxDropDownItems = 2;
            this.appby.Name = "appby";
            this.appby.Size = new System.Drawing.Size(122, 21);
            this.appby.Sorted = true;
            this.appby.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time Stamp:";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(469, 191);
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(130, 20);
            this.time.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(525, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "COMMIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "User ID:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(325, 191);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(122, 20);
            this.username.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "An outgoing BG Check database update is pending.\r\nPlease provide the requested in" +
    "formation below.";
            // 
            // sqlwriterlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changed);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.appby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sqlwriterlog";
            this.Text = "Outgoing Update";
            this.Load += new System.EventHandler(this.sqlwriterlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox changed;
        private System.Windows.Forms.RichTextBox reason;
        private System.Windows.Forms.ComboBox appby;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;

    }
}