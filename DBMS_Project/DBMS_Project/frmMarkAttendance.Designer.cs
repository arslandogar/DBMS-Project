namespace DBMS_Project
{
    partial class frmMarkAttendance
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
            this.txtRegNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAStatus = new System.Windows.Forms.ComboBox();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.linkMain = new System.Windows.Forms.LinkLabel();
            this.groupBoxMarkAttendance = new System.Windows.Forms.GroupBox();
            this.groupBoxViewAttendance = new System.Windows.Forms.GroupBox();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.groupBoxMarkAttendance.SuspendLayout();
            this.groupBoxViewAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Number";
            // 
            // txtRegNo
            // 
            this.txtRegNo.FormattingEnabled = true;
            this.txtRegNo.Location = new System.Drawing.Point(115, 36);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(121, 21);
            this.txtRegNo.TabIndex = 1;
            this.txtRegNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attendance Status";
            // 
            // txtAStatus
            // 
            this.txtAStatus.FormattingEnabled = true;
            this.txtAStatus.Location = new System.Drawing.Point(115, 75);
            this.txtAStatus.Name = "txtAStatus";
            this.txtAStatus.Size = new System.Drawing.Size(121, 21);
            this.txtAStatus.TabIndex = 3;
            this.txtAStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAStatus_KeyPress);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Location = new System.Drawing.Point(124, 102);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(98, 23);
            this.btnMarkAttendance.TabIndex = 4;
            this.btnMarkAttendance.Text = "Mark Attendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // linkMain
            // 
            this.linkMain.AutoSize = true;
            this.linkMain.Location = new System.Drawing.Point(712, 128);
            this.linkMain.Name = "linkMain";
            this.linkMain.Size = new System.Drawing.Size(58, 13);
            this.linkMain.TabIndex = 9;
            this.linkMain.TabStop = true;
            this.linkMain.Text = "Main Page";
            this.linkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMain_LinkClicked);
            // 
            // groupBoxMarkAttendance
            // 
            this.groupBoxMarkAttendance.Controls.Add(this.label1);
            this.groupBoxMarkAttendance.Controls.Add(this.linkMain);
            this.groupBoxMarkAttendance.Controls.Add(this.txtRegNo);
            this.groupBoxMarkAttendance.Controls.Add(this.btnMarkAttendance);
            this.groupBoxMarkAttendance.Controls.Add(this.label2);
            this.groupBoxMarkAttendance.Controls.Add(this.txtAStatus);
            this.groupBoxMarkAttendance.Location = new System.Drawing.Point(12, 27);
            this.groupBoxMarkAttendance.Name = "groupBoxMarkAttendance";
            this.groupBoxMarkAttendance.Size = new System.Drawing.Size(776, 144);
            this.groupBoxMarkAttendance.TabIndex = 10;
            this.groupBoxMarkAttendance.TabStop = false;
            this.groupBoxMarkAttendance.Text = "Mark Attendance";
            // 
            // groupBoxViewAttendance
            // 
            this.groupBoxViewAttendance.Controls.Add(this.dataGridViewAttendance);
            this.groupBoxViewAttendance.Location = new System.Drawing.Point(12, 187);
            this.groupBoxViewAttendance.Name = "groupBoxViewAttendance";
            this.groupBoxViewAttendance.Size = new System.Drawing.Size(776, 251);
            this.groupBoxViewAttendance.TabIndex = 11;
            this.groupBoxViewAttendance.TabStop = false;
            this.groupBoxViewAttendance.Text = "View Attendance";
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.AllowUserToAddRows = false;
            this.dataGridViewAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewAttendance.AllowUserToResizeRows = false;
            this.dataGridViewAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(9, 17);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.ReadOnly = true;
            this.dataGridViewAttendance.Size = new System.Drawing.Size(761, 228);
            this.dataGridViewAttendance.TabIndex = 3;
            // 
            // frmMarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxViewAttendance);
            this.Controls.Add(this.groupBoxMarkAttendance);
            this.Name = "frmMarkAttendance";
            this.Text = "Mark Attendance";
            this.Load += new System.EventHandler(this.frmMarkAttendance_Load);
            this.groupBoxMarkAttendance.ResumeLayout(false);
            this.groupBoxMarkAttendance.PerformLayout();
            this.groupBoxViewAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtRegNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtAStatus;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.LinkLabel linkMain;
        private System.Windows.Forms.GroupBox groupBoxMarkAttendance;
        private System.Windows.Forms.GroupBox groupBoxViewAttendance;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
    }
}