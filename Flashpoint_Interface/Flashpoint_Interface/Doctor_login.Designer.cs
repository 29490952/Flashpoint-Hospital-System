namespace Flashpoint_Interface
    {
    partial class Doctor_login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor_login));
			this.label1 = new System.Windows.Forms.Label();
			this.txtDocID = new System.Windows.Forms.TextBox();
			this.lblDocID = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbDepart = new System.Windows.Forms.ComboBox();
			this.cmbOnCall = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtPassCode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(137, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Doctor Department:";
			// 
			// txtDocID
			// 
			this.txtDocID.Location = new System.Drawing.Point(241, 192);
			this.txtDocID.Name = "txtDocID";
			this.txtDocID.Size = new System.Drawing.Size(214, 20);
			this.txtDocID.TabIndex = 2;
			// 
			// lblDocID
			// 
			this.lblDocID.AutoSize = true;
			this.lblDocID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDocID.ForeColor = System.Drawing.Color.White;
			this.lblDocID.Location = new System.Drawing.Point(137, 189);
			this.lblDocID.Name = "lblDocID";
			this.lblDocID.Size = new System.Drawing.Size(100, 26);
			this.lblDocID.TabIndex = 3;
			this.lblDocID.Text = "Doctor ID:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 126);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(137, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "On-Call Doctor (Yes/No):";
			// 
			// cmbDepart
			// 
			this.cmbDepart.FormattingEnabled = true;
			this.cmbDepart.Location = new System.Drawing.Point(310, 265);
			this.cmbDepart.Name = "cmbDepart";
			this.cmbDepart.Size = new System.Drawing.Size(145, 21);
			this.cmbDepart.TabIndex = 7;
			// 
			// cmbOnCall
			// 
			this.cmbOnCall.FormattingEnabled = true;
			this.cmbOnCall.Items.AddRange(new object[] {
            "Yes",
            "No"});
			this.cmbOnCall.Location = new System.Drawing.Point(351, 306);
			this.cmbOnCall.Name = "cmbOnCall";
			this.cmbOnCall.Size = new System.Drawing.Size(104, 21);
			this.cmbOnCall.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(137, 345);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 26);
			this.label5.TabIndex = 10;
			this.label5.Text = "Hospital From:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(271, 345);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 20);
			this.textBox1.TabIndex = 11;
			// 
			// txtPassCode
			// 
			this.txtPassCode.Location = new System.Drawing.Point(243, 230);
			this.txtPassCode.Name = "txtPassCode";
			this.txtPassCode.Size = new System.Drawing.Size(214, 20);
			this.txtPassCode.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(137, 230);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 26);
			this.label6.TabIndex = 13;
			this.label6.Text = "Pass Code:";
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.Color.Maroon;
			this.btnNext.Location = new System.Drawing.Point(592, 453);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(87, 35);
			this.btnNext.TabIndex = 14;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
			this.groupBox1.Location = new System.Drawing.Point(243, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 143);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			// 
			// Doctor_login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(682, 489);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPassCode);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbOnCall);
			this.Controls.Add(this.cmbDepart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblDocID);
			this.Controls.Add(this.txtDocID);
			this.Controls.Add(this.label1);
			this.Name = "Doctor_login";
			this.Text = "Doctor_login";
			this.Load += new System.EventHandler(this.Doctor_login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocID;
        private System.Windows.Forms.Label lblDocID;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbDepart;
		private System.Windows.Forms.ComboBox cmbOnCall;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtPassCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.GroupBox groupBox1;
	}
    }