namespace WindowsFormsApplication1
{
    partial class main
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
            this.mst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.telenetwork_265x42;
            this.pictureBox1.Location = new System.Drawing.Point(189, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mst
            // 
            this.mst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mst.Location = new System.Drawing.Point(257, 251);
            this.mst.Name = "mst";
            this.mst.Size = new System.Drawing.Size(117, 23);
            this.mst.TabIndex = 5;
            this.mst.Text = "Applicant Search";
            this.mst.UseVisualStyleBackColor = true;
            this.mst.Click += new System.EventHandler(this.mst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "RPortal";
            // 
            // ast
            // 
            this.ast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ast.Location = new System.Drawing.Point(257, 280);
            this.ast.Name = "ast";
            this.ast.Size = new System.Drawing.Size(117, 23);
            this.ast.TabIndex = 7;
            this.ast.Text = "Applicant Editor";
            this.ast.UseVisualStyleBackColor = true;
            this.ast.Click += new System.EventHandler(this.ast_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "This software contains confidential information. Unauthorized access to these dat" +
    "abases and systems will be punished by law.";
            // 
            // close
            // 
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(277, 482);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 538);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mst);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "RPortal";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
    }
}