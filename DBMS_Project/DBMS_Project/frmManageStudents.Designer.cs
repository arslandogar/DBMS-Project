namespace DBMS_Project
{
    partial class frmManageStudents
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBoxViewStudenst = new System.Windows.Forms.GroupBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.groupBoxAddStudent.SuspendLayout();
            this.groupBoxViewStudenst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registration Number";
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Controls.Add(this.btnAddStudent);
            this.groupBoxAddStudent.Controls.Add(this.txtRegNo);
            this.groupBoxAddStudent.Controls.Add(this.txtEmail);
            this.groupBoxAddStudent.Controls.Add(this.txtContact);
            this.groupBoxAddStudent.Controls.Add(this.txtLastName);
            this.groupBoxAddStudent.Controls.Add(this.txtFirstName);
            this.groupBoxAddStudent.Controls.Add(this.label1);
            this.groupBoxAddStudent.Controls.Add(this.label5);
            this.groupBoxAddStudent.Controls.Add(this.label2);
            this.groupBoxAddStudent.Controls.Add(this.label4);
            this.groupBoxAddStudent.Controls.Add(this.label3);
            this.groupBoxAddStudent.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(776, 182);
            this.groupBoxAddStudent.TabIndex = 6;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "Add Student";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(348, 30);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(115, 73);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(348, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(115, 113);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(100, 20);
            this.txtRegNo.TabIndex = 10;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(225, 153);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupBoxViewStudenst
            // 
            this.groupBoxViewStudenst.Controls.Add(this.dataGridViewStudents);
            this.groupBoxViewStudenst.Location = new System.Drawing.Point(12, 224);
            this.groupBoxViewStudenst.Name = "groupBoxViewStudenst";
            this.groupBoxViewStudenst.Size = new System.Drawing.Size(776, 214);
            this.groupBoxViewStudenst.TabIndex = 7;
            this.groupBoxViewStudenst.TabStop = false;
            this.groupBoxViewStudenst.Text = "View Students";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(761, 189);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // frmManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxViewStudenst);
            this.Controls.Add(this.groupBoxAddStudent);
            this.Name = "frmManageStudents";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.frmManageStudents_Load);
            this.groupBoxAddStudent.ResumeLayout(false);
            this.groupBoxAddStudent.PerformLayout();
            this.groupBoxViewStudenst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBoxViewStudenst;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
}