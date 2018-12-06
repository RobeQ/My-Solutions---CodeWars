namespace WinDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetEmployee = new System.Windows.Forms.Button();
            this.textBoxEID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDName = new System.Windows.Forms.TextBox();
            this.buttonDeleteLog = new System.Windows.Forms.Button();
            this.linkLabelDeptName = new System.Windows.Forms.LinkLabel();
            this.labelDeptId = new System.Windows.Forms.Label();
            this.dataGridViewWinApplication = new System.Windows.Forms.DataGridView();
            this.buttonUpdateLog = new System.Windows.Forms.Button();
            this.listViewStatistics = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelOldName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWinApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Employee ID:";
            // 
            // buttonGetEmployee
            // 
            this.buttonGetEmployee.Location = new System.Drawing.Point(245, 41);
            this.buttonGetEmployee.Name = "buttonGetEmployee";
            this.buttonGetEmployee.Size = new System.Drawing.Size(53, 23);
            this.buttonGetEmployee.TabIndex = 1;
            this.buttonGetEmployee.Text = "GO";
            this.buttonGetEmployee.UseVisualStyleBackColor = true;
            this.buttonGetEmployee.Click += new System.EventHandler(this.buttonGetEmployee_Click);
            // 
            // textBoxEID
            // 
            this.textBoxEID.Location = new System.Drawing.Point(129, 43);
            this.textBoxEID.Name = "textBoxEID";
            this.textBoxEID.Size = new System.Drawing.Size(100, 20);
            this.textBoxEID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(129, 108);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(129, 20);
            this.textBoxFName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = " Last Name:";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(129, 137);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(129, 20);
            this.textBoxLName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department:";
            // 
            // textBoxDName
            // 
            this.textBoxDName.Location = new System.Drawing.Point(129, 166);
            this.textBoxDName.Name = "textBoxDName";
            this.textBoxDName.Size = new System.Drawing.Size(147, 20);
            this.textBoxDName.TabIndex = 2;
            // 
            // buttonDeleteLog
            // 
            this.buttonDeleteLog.Location = new System.Drawing.Point(36, 339);
            this.buttonDeleteLog.Name = "buttonDeleteLog";
            this.buttonDeleteLog.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteLog.TabIndex = 3;
            this.buttonDeleteLog.Text = "Delete Log";
            this.buttonDeleteLog.UseVisualStyleBackColor = true;
            this.buttonDeleteLog.Click += new System.EventHandler(this.buttonDeleteLog_Click);
            // 
            // linkLabelDeptName
            // 
            this.linkLabelDeptName.AutoSize = true;
            this.linkLabelDeptName.Location = new System.Drawing.Point(282, 173);
            this.linkLabelDeptName.Name = "linkLabelDeptName";
            this.linkLabelDeptName.Size = new System.Drawing.Size(42, 13);
            this.linkLabelDeptName.TabIndex = 4;
            this.linkLabelDeptName.TabStop = true;
            this.linkLabelDeptName.Text = "Update";
            this.linkLabelDeptName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeptName_LinkClicked);
            // 
            // labelDeptId
            // 
            this.labelDeptId.AutoSize = true;
            this.labelDeptId.Location = new System.Drawing.Point(12, 205);
            this.labelDeptId.Name = "labelDeptId";
            this.labelDeptId.Size = new System.Drawing.Size(13, 13);
            this.labelDeptId.TabIndex = 5;
            this.labelDeptId.Text = "0";
            // 
            // dataGridViewWinApplication
            // 
            this.dataGridViewWinApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWinApplication.Location = new System.Drawing.Point(36, 217);
            this.dataGridViewWinApplication.Name = "dataGridViewWinApplication";
            this.dataGridViewWinApplication.Size = new System.Drawing.Size(466, 116);
            this.dataGridViewWinApplication.TabIndex = 6;
            this.dataGridViewWinApplication.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewWinApplication_DataError);
            // 
            // buttonUpdateLog
            // 
            this.buttonUpdateLog.Location = new System.Drawing.Point(138, 339);
            this.buttonUpdateLog.Name = "buttonUpdateLog";
            this.buttonUpdateLog.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateLog.TabIndex = 7;
            this.buttonUpdateLog.Text = "Update Log";
            this.buttonUpdateLog.UseVisualStyleBackColor = true;
            this.buttonUpdateLog.Click += new System.EventHandler(this.buttonUpdateLog_Click);
            // 
            // listViewStatistics
            // 
            this.listViewStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.listViewStatistics.Location = new System.Drawing.Point(513, 12);
            this.listViewStatistics.Name = "listViewStatistics";
            this.listViewStatistics.Size = new System.Drawing.Size(209, 321);
            this.listViewStatistics.TabIndex = 8;
            this.listViewStatistics.UseCompatibleStateImageBehavior = false;
            this.listViewStatistics.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Statistic";
            this.ColumnHeader1.Width = 90;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Value";
            this.ColumnHeader2.Width = 90;
            // 
            // labelOldName
            // 
            this.labelOldName.AutoSize = true;
            this.labelOldName.Location = new System.Drawing.Point(126, 189);
            this.labelOldName.Name = "labelOldName";
            this.labelOldName.Size = new System.Drawing.Size(35, 13);
            this.labelOldName.TabIndex = 9;
            this.labelOldName.Text = "label1";
            this.labelOldName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 374);
            this.Controls.Add(this.labelOldName);
            this.Controls.Add(this.listViewStatistics);
            this.Controls.Add(this.buttonUpdateLog);
            this.Controls.Add(this.dataGridViewWinApplication);
            this.Controls.Add(this.labelDeptId);
            this.Controls.Add(this.linkLabelDeptName);
            this.Controls.Add(this.buttonDeleteLog);
            this.Controls.Add(this.textBoxDName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxEID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGetEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWinApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetEmployee;
        private System.Windows.Forms.TextBox textBoxEID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDName;
        private System.Windows.Forms.Button buttonDeleteLog;
        private System.Windows.Forms.LinkLabel linkLabelDeptName;
        private System.Windows.Forms.Label labelDeptId;
        private System.Windows.Forms.DataGridView dataGridViewWinApplication;
        private System.Windows.Forms.Button buttonUpdateLog;
        private System.Windows.Forms.ListView listViewStatistics;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.Label labelOldName;
    }
}

