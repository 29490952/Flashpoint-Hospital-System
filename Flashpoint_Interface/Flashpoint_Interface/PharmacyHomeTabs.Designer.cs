namespace Flashpoint_Interface
{
    partial class PharmacyHomeTabs
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
            this.DrugsTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridDrugs = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PresTab = new System.Windows.Forms.TabPage();
            this.btnViewPrescription = new System.Windows.Forms.Button();
            this.presDataGridView = new System.Windows.Forms.DataGridView();
            this.btnClearPrescription = new System.Windows.Forms.Button();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.Tabs = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewPres = new System.Windows.Forms.Button();
            this.btnDrugAvail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DrugsTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrugs)).BeginInit();
            this.PresTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presDataGridView)).BeginInit();
            this.HomeTab.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrugsTab
            // 
            this.DrugsTab.BackColor = System.Drawing.Color.Teal;
            this.DrugsTab.Controls.Add(this.groupBox3);
            this.DrugsTab.Controls.Add(this.textBox4);
            this.DrugsTab.Controls.Add(this.dataGridDrugs);
            this.DrugsTab.Controls.Add(this.label7);
            this.DrugsTab.Controls.Add(this.label8);
            this.DrugsTab.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugsTab.Location = new System.Drawing.Point(4, 25);
            this.DrugsTab.Margin = new System.Windows.Forms.Padding(4);
            this.DrugsTab.Name = "DrugsTab";
            this.DrugsTab.Padding = new System.Windows.Forms.Padding(4);
            this.DrugsTab.Size = new System.Drawing.Size(921, 560);
            this.DrugsTab.TabIndex = 3;
            this.DrugsTab.Text = "DRUGS AVAILABLE";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(652, 399);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(259, 111);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option to add new stock";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(33, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add new drugs";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 444);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 29);
            this.textBox4.TabIndex = 13;
            // 
            // dataGridDrugs
            // 
            this.dataGridDrugs.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDrugs.Location = new System.Drawing.Point(79, 102);
            this.dataGridDrugs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDrugs.Name = "dataGridDrugs";
            this.dataGridDrugs.Size = new System.Drawing.Size(753, 289);
            this.dataGridDrugs.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(56, 444);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search drug by name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(136, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(600, 91);
            this.label8.TabIndex = 10;
            this.label8.Text = "Drugs Available";
            // 
            // PresTab
            // 
            this.PresTab.BackColor = System.Drawing.Color.Teal;
            this.PresTab.Controls.Add(this.btnViewPrescription);
            this.PresTab.Controls.Add(this.presDataGridView);
            this.PresTab.Controls.Add(this.btnClearPrescription);
            this.PresTab.Controls.Add(this.txtPatID);
            this.PresTab.Controls.Add(this.label5);
            this.PresTab.Controls.Add(this.label6);
            this.PresTab.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresTab.Location = new System.Drawing.Point(4, 25);
            this.PresTab.Margin = new System.Windows.Forms.Padding(4);
            this.PresTab.Name = "PresTab";
            this.PresTab.Padding = new System.Windows.Forms.Padding(4);
            this.PresTab.Size = new System.Drawing.Size(921, 560);
            this.PresTab.TabIndex = 2;
            this.PresTab.Text = "PRESCRIPTIONS";
            this.PresTab.Click += new System.EventHandler(this.PresTab_Click);
            // 
            // btnViewPrescription
            // 
            this.btnViewPrescription.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewPrescription.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnViewPrescription.Location = new System.Drawing.Point(330, 480);
            this.btnViewPrescription.Name = "btnViewPrescription";
            this.btnViewPrescription.Size = new System.Drawing.Size(191, 54);
            this.btnViewPrescription.TabIndex = 18;
            this.btnViewPrescription.Text = "View Prescriptions";
            this.btnViewPrescription.UseVisualStyleBackColor = false;
            this.btnViewPrescription.Click += new System.EventHandler(this.btnViewPrescription_Click);
            // 
            // presDataGridView
            // 
            this.presDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presDataGridView.Location = new System.Drawing.Point(62, 94);
            this.presDataGridView.Name = "presDataGridView";
            this.presDataGridView.RowTemplate.Height = 24;
            this.presDataGridView.Size = new System.Drawing.Size(795, 321);
            this.presDataGridView.TabIndex = 17;
            // 
            // btnClearPrescription
            // 
            this.btnClearPrescription.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClearPrescription.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPrescription.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClearPrescription.Location = new System.Drawing.Point(724, 483);
            this.btnClearPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPrescription.Name = "btnClearPrescription";
            this.btnClearPrescription.Size = new System.Drawing.Size(189, 51);
            this.btnClearPrescription.TabIndex = 16;
            this.btnClearPrescription.Text = "Clear prescription";
            this.btnClearPrescription.UseVisualStyleBackColor = false;
            // 
            // txtPatID
            // 
            this.txtPatID.Location = new System.Drawing.Point(387, 431);
            this.txtPatID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(281, 29);
            this.txtPatID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(194, 433);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter patient ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(172, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(509, 91);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prescriptions";
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.Teal;
            this.HomeTab.Controls.Add(this.Tabs);
            this.HomeTab.Controls.Add(this.label4);
            this.HomeTab.Controls.Add(this.btnExit);
            this.HomeTab.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.Location = new System.Drawing.Point(4, 25);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(4);
            this.HomeTab.Size = new System.Drawing.Size(921, 560);
            this.HomeTab.TabIndex = 1;
            this.HomeTab.Text = "HOME";
            this.HomeTab.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // Tabs
            // 
            this.Tabs.BackColor = System.Drawing.Color.Transparent;
            this.Tabs.Controls.Add(this.btnAdd);
            this.Tabs.Controls.Add(this.btnViewPres);
            this.Tabs.Controls.Add(this.btnDrugAvail);
            this.Tabs.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Tabs.Location = new System.Drawing.Point(192, 217);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Windows.Forms.Padding(4);
            this.Tabs.Size = new System.Drawing.Size(537, 312);
            this.Tabs.TabIndex = 7;
            this.Tabs.TabStop = false;
            this.Tabs.Text = "Tabs";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(133, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 82);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Drugs";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnViewPres
            // 
            this.btnViewPres.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewPres.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPres.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnViewPres.Location = new System.Drawing.Point(133, 39);
            this.btnViewPres.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPres.Name = "btnViewPres";
            this.btnViewPres.Size = new System.Drawing.Size(267, 79);
            this.btnViewPres.TabIndex = 0;
            this.btnViewPres.Text = "View Prescriptions";
            this.btnViewPres.UseVisualStyleBackColor = false;
            this.btnViewPres.Click += new System.EventHandler(this.btnViewPres_Click);
            // 
            // btnDrugAvail
            // 
            this.btnDrugAvail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDrugAvail.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrugAvail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDrugAvail.Location = new System.Drawing.Point(133, 126);
            this.btnDrugAvail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrugAvail.Name = "btnDrugAvail";
            this.btnDrugAvail.Size = new System.Drawing.Size(267, 78);
            this.btnDrugAvail.TabIndex = 1;
            this.btnDrugAvail.Text = "Drugs Available";
            this.btnDrugAvail.UseVisualStyleBackColor = false;
            this.btnDrugAvail.Click += new System.EventHandler(this.btnDrugAvail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(57, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(736, 136);
            this.label4.TabIndex = 6;
            this.label4.Text = "PHARMACY";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(811, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.PresTab);
            this.tabControl1.Controls.Add(this.DrugsTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // PharmacyHomeTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 564);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PharmacyHomeTabs";
            this.Text = "PharmacyHomeTabs";
            this.Load += new System.EventHandler(this.PharmacyHomeTabs_Load);
            this.DrugsTab.ResumeLayout(false);
            this.DrugsTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDrugs)).EndInit();
            this.PresTab.ResumeLayout(false);
            this.PresTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presDataGridView)).EndInit();
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage DrugsTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridDrugs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage PresTab;
        private System.Windows.Forms.Button btnClearPrescription;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.GroupBox Tabs;
        private System.Windows.Forms.Button btnViewPres;
        private System.Windows.Forms.Button btnDrugAvail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView presDataGridView;
        private System.Windows.Forms.Button btnViewPrescription;
        private System.Windows.Forms.Button btnAdd;
    }
}