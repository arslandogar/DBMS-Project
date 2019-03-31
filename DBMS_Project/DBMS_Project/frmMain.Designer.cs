namespace DBMS_Project
{
    partial class frmMain
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
            this.linkManageStudents = new System.Windows.Forms.LinkLabel();
            this.linkManageCLOR = new System.Windows.Forms.LinkLabel();
            this.linkManageAssessments = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkManageStudents
            // 
            this.linkManageStudents.AutoSize = true;
            this.linkManageStudents.Location = new System.Drawing.Point(357, 176);
            this.linkManageStudents.Name = "linkManageStudents";
            this.linkManageStudents.Size = new System.Drawing.Size(91, 13);
            this.linkManageStudents.TabIndex = 0;
            this.linkManageStudents.TabStop = true;
            this.linkManageStudents.Text = "Manage Students";
            this.linkManageStudents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManageStudents_LinkClicked);
            // 
            // linkManageCLOR
            // 
            this.linkManageCLOR.AutoSize = true;
            this.linkManageCLOR.Location = new System.Drawing.Point(357, 245);
            this.linkManageCLOR.Name = "linkManageCLOR";
            this.linkManageCLOR.Size = new System.Drawing.Size(135, 13);
            this.linkManageCLOR.TabIndex = 2;
            this.linkManageCLOR.TabStop = true;
            this.linkManageCLOR.Text = "Manage CLOs and Rubrics";
            this.linkManageCLOR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManageCLOR_LinkClicked);
            // 
            // linkManageAssessments
            // 
            this.linkManageAssessments.AutoSize = true;
            this.linkManageAssessments.Location = new System.Drawing.Point(357, 211);
            this.linkManageAssessments.Name = "linkManageAssessments";
            this.linkManageAssessments.Size = new System.Drawing.Size(110, 13);
            this.linkManageAssessments.TabIndex = 1;
            this.linkManageAssessments.TabStop = true;
            this.linkManageAssessments.Text = "Manage Assessments";
            this.linkManageAssessments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManageAssessments_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkManageAssessments);
            this.Controls.Add(this.linkManageCLOR);
            this.Controls.Add(this.linkManageStudents);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkManageStudents;
        private System.Windows.Forms.LinkLabel linkManageCLOR;
        private System.Windows.Forms.LinkLabel linkManageAssessments;
    }
}

