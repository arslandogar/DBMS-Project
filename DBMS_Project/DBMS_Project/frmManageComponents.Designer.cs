namespace DBMS_Project
{
    partial class frmManageComponents
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
            this.groupBoxAddComponent = new System.Windows.Forms.GroupBox();
            this.txtRubric = new System.Windows.Forms.ComboBox();
            this.txtMarks = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkMain = new System.Windows.Forms.LinkLabel();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelComponentDetails = new System.Windows.Forms.Label();
            this.groupBoxComponents = new System.Windows.Forms.GroupBox();
            this.dataGridViewComponents = new System.Windows.Forms.DataGridView();
            this.txtAssessmentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxAddComponent.SuspendLayout();
            this.groupBoxComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddComponent
            // 
            this.groupBoxAddComponent.Controls.Add(this.txtRubric);
            this.groupBoxAddComponent.Controls.Add(this.txtMarks);
            this.groupBoxAddComponent.Controls.Add(this.label4);
            this.groupBoxAddComponent.Controls.Add(this.label3);
            this.groupBoxAddComponent.Controls.Add(this.linkMain);
            this.groupBoxAddComponent.Controls.Add(this.linkBack);
            this.groupBoxAddComponent.Controls.Add(this.btnCancel);
            this.groupBoxAddComponent.Controls.Add(this.btnAddComponent);
            this.groupBoxAddComponent.Controls.Add(this.label1);
            this.groupBoxAddComponent.Controls.Add(this.txtName);
            this.groupBoxAddComponent.Location = new System.Drawing.Point(12, 73);
            this.groupBoxAddComponent.Name = "groupBoxAddComponent";
            this.groupBoxAddComponent.Size = new System.Drawing.Size(776, 160);
            this.groupBoxAddComponent.TabIndex = 0;
            this.groupBoxAddComponent.TabStop = false;
            this.groupBoxAddComponent.Text = "Add Component";
            // 
            // txtRubric
            // 
            this.txtRubric.FormattingEnabled = true;
            this.txtRubric.Location = new System.Drawing.Point(47, 93);
            this.txtRubric.Name = "txtRubric";
            this.txtRubric.Size = new System.Drawing.Size(121, 21);
            this.txtRubric.TabIndex = 2;
            this.txtRubric.Text = "Select Rubric";
            this.txtRubric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRubric_KeyPress);
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(47, 57);
            this.txtMarks.Mask = "00";
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.PromptChar = '.';
            this.txtMarks.Size = new System.Drawing.Size(121, 20);
            this.txtMarks.TabIndex = 1;
            this.txtMarks.ValidatingType = typeof(int);
            this.txtMarks.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarks_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rubric";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marks";
            // 
            // linkMain
            // 
            this.linkMain.AutoSize = true;
            this.linkMain.Location = new System.Drawing.Point(712, 135);
            this.linkMain.Name = "linkMain";
            this.linkMain.Size = new System.Drawing.Size(58, 13);
            this.linkMain.TabIndex = 6;
            this.linkMain.TabStop = true;
            this.linkMain.Text = "Main Page";
            this.linkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMain_LinkClicked);
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Location = new System.Drawing.Point(598, 135);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(108, 13);
            this.linkBack.TabIndex = 5;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back to Assessments";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(169, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Location = new System.Drawing.Point(43, 125);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(104, 23);
            this.btnAddComponent.TabIndex = 3;
            this.btnAddComponent.Text = "AddComponent";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(47, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // labelComponentDetails
            // 
            this.labelComponentDetails.AutoSize = true;
            this.labelComponentDetails.Location = new System.Drawing.Point(21, 13);
            this.labelComponentDetails.Name = "labelComponentDetails";
            this.labelComponentDetails.Size = new System.Drawing.Size(98, 13);
            this.labelComponentDetails.TabIndex = 1;
            this.labelComponentDetails.Text = "Add Component for";
            // 
            // groupBoxComponents
            // 
            this.groupBoxComponents.Controls.Add(this.dataGridViewComponents);
            this.groupBoxComponents.Location = new System.Drawing.Point(12, 239);
            this.groupBoxComponents.Name = "groupBoxComponents";
            this.groupBoxComponents.Size = new System.Drawing.Size(776, 199);
            this.groupBoxComponents.TabIndex = 2;
            this.groupBoxComponents.TabStop = false;
            this.groupBoxComponents.Text = "View Components For";
            // 
            // dataGridViewComponents
            // 
            this.dataGridViewComponents.AllowUserToAddRows = false;
            this.dataGridViewComponents.AllowUserToDeleteRows = false;
            this.dataGridViewComponents.AllowUserToResizeColumns = false;
            this.dataGridViewComponents.AllowUserToResizeRows = false;
            this.dataGridViewComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponents.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewComponents.Name = "dataGridViewComponents";
            this.dataGridViewComponents.Size = new System.Drawing.Size(754, 164);
            this.dataGridViewComponents.TabIndex = 0;
            this.dataGridViewComponents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComponents_CellContentClick);
            // 
            // txtAssessmentId
            // 
            this.txtAssessmentId.Enabled = false;
            this.txtAssessmentId.Location = new System.Drawing.Point(103, 37);
            this.txtAssessmentId.Name = "txtAssessmentId";
            this.txtAssessmentId.ReadOnly = true;
            this.txtAssessmentId.Size = new System.Drawing.Size(100, 20);
            this.txtAssessmentId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assessment Id";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAssessmentId);
            this.Controls.Add(this.groupBoxComponents);
            this.Controls.Add(this.labelComponentDetails);
            this.Controls.Add(this.groupBoxAddComponent);
            this.Name = "frmManageComponents";
            this.Text = "Manage Components";
            this.Load += new System.EventHandler(this.frmManageRubrics_Load);
            this.groupBoxAddComponent.ResumeLayout(false);
            this.groupBoxAddComponent.PerformLayout();
            this.groupBoxComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddComponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddComponent;
        public System.Windows.Forms.Label labelComponentDetails;
        public System.Windows.Forms.GroupBox groupBoxComponents;
        public System.Windows.Forms.DataGridView dataGridViewComponents;
        private System.Windows.Forms.LinkLabel linkMain;
        private System.Windows.Forms.LinkLabel linkBack;
        public System.Windows.Forms.TextBox txtAssessmentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtMarks;
        private System.Windows.Forms.ComboBox txtRubric;
    }
}