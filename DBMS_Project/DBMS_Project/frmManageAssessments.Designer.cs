namespace DBMS_Project
{
    partial class frmManageAssessments
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxAddAssessment = new System.Windows.Forms.GroupBox();
            this.txtWeightage = new System.Windows.Forms.MaskedTextBox();
            this.txtMarks = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkMain = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAssessments = new System.Windows.Forms.GroupBox();
            this.dataGridViewAssessments = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxAddAssessment.SuspendLayout();
            this.groupBoxAssessments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssessments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddAssessment
            // 
            this.groupBoxAddAssessment.Controls.Add(this.txtWeightage);
            this.groupBoxAddAssessment.Controls.Add(this.txtMarks);
            this.groupBoxAddAssessment.Controls.Add(this.label3);
            this.groupBoxAddAssessment.Controls.Add(this.label2);
            this.groupBoxAddAssessment.Controls.Add(this.linkMain);
            this.groupBoxAddAssessment.Controls.Add(this.btnCancel);
            this.groupBoxAddAssessment.Controls.Add(this.txtTitle);
            this.groupBoxAddAssessment.Controls.Add(this.btnAddAssessment);
            this.groupBoxAddAssessment.Controls.Add(this.label1);
            this.groupBoxAddAssessment.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAddAssessment.Name = "groupBoxAddAssessment";
            this.groupBoxAddAssessment.Size = new System.Drawing.Size(776, 167);
            this.groupBoxAddAssessment.TabIndex = 0;
            this.groupBoxAddAssessment.TabStop = false;
            this.groupBoxAddAssessment.Text = "Add Assessment";
            // 
            // txtWeightage
            // 
            this.txtWeightage.Location = new System.Drawing.Point(98, 100);
            this.txtWeightage.Mask = "000";
            this.txtWeightage.Name = "txtWeightage";
            this.txtWeightage.PromptChar = '.';
            this.txtWeightage.Size = new System.Drawing.Size(111, 20);
            this.txtWeightage.TabIndex = 5;
            this.txtWeightage.ValidatingType = typeof(int);
            this.txtWeightage.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeightage_Validating);
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(98, 71);
            this.txtMarks.Mask = "00";
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.PromptChar = '.';
            this.txtMarks.Size = new System.Drawing.Size(111, 20);
            this.txtMarks.TabIndex = 4;
            this.txtMarks.ValidatingType = typeof(int);
            this.txtMarks.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarks_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Weightage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Marks";
            // 
            // linkMain
            // 
            this.linkMain.AutoSize = true;
            this.linkMain.Location = new System.Drawing.Point(712, 140);
            this.linkMain.Name = "linkMain";
            this.linkMain.Size = new System.Drawing.Size(58, 13);
            this.linkMain.TabIndex = 8;
            this.linkMain.TabStop = true;
            this.linkMain.Text = "Main Page";
            this.linkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMain_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(223, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(98, 37);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(111, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Location = new System.Drawing.Point(98, 130);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(104, 23);
            this.btnAddAssessment.TabIndex = 6;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // groupBoxAssessments
            // 
            this.groupBoxAssessments.Controls.Add(this.dataGridViewAssessments);
            this.groupBoxAssessments.Location = new System.Drawing.Point(12, 200);
            this.groupBoxAssessments.Name = "groupBoxAssessments";
            this.groupBoxAssessments.Size = new System.Drawing.Size(776, 238);
            this.groupBoxAssessments.TabIndex = 1;
            this.groupBoxAssessments.TabStop = false;
            this.groupBoxAssessments.Text = "View Assessment";
            // 
            // dataGridViewAssessments
            // 
            this.dataGridViewAssessments.AllowUserToAddRows = false;
            this.dataGridViewAssessments.AllowUserToDeleteRows = false;
            this.dataGridViewAssessments.AllowUserToResizeColumns = false;
            this.dataGridViewAssessments.AllowUserToResizeRows = false;
            this.dataGridViewAssessments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssessments.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewAssessments.Name = "dataGridViewAssessments";
            this.dataGridViewAssessments.ReadOnly = true;
            this.dataGridViewAssessments.Size = new System.Drawing.Size(751, 228);
            this.dataGridViewAssessments.TabIndex = 2;
            this.dataGridViewAssessments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAssessments_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAssessments);
            this.Controls.Add(this.groupBoxAddAssessment);
            this.Name = "frmManageAssessments";
            this.Text = "Manage Assessments";
            this.Load += new System.EventHandler(this.frmManageAssessments_Load);
            this.groupBoxAddAssessment.ResumeLayout(false);
            this.groupBoxAddAssessment.PerformLayout();
            this.groupBoxAssessments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssessments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddAssessment;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAssessments;
        private System.Windows.Forms.DataGridView dataGridViewAssessments;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel linkMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtWeightage;
        private System.Windows.Forms.MaskedTextBox txtMarks;
    }
}