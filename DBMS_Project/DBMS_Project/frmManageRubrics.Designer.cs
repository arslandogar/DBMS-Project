namespace DBMS_Project
{
    partial class frmManageRubrics
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
            this.groupBoxAddRubric = new System.Windows.Forms.GroupBox();
            this.linkMain = new System.Windows.Forms.LinkLabel();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddRubric = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRubricDetail = new System.Windows.Forms.TextBox();
            this.labelCLODetails = new System.Windows.Forms.Label();
            this.groupBoxRubrics = new System.Windows.Forms.GroupBox();
            this.dataGridViewRubrics = new System.Windows.Forms.DataGridView();
            this.txtCLOId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxAddRubric.SuspendLayout();
            this.groupBoxRubrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRubrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddRubric
            // 
            this.groupBoxAddRubric.Controls.Add(this.linkMain);
            this.groupBoxAddRubric.Controls.Add(this.linkBack);
            this.groupBoxAddRubric.Controls.Add(this.btnCancel);
            this.groupBoxAddRubric.Controls.Add(this.btnAddRubric);
            this.groupBoxAddRubric.Controls.Add(this.label1);
            this.groupBoxAddRubric.Controls.Add(this.txtRubricDetail);
            this.groupBoxAddRubric.Location = new System.Drawing.Point(12, 73);
            this.groupBoxAddRubric.Name = "groupBoxAddRubric";
            this.groupBoxAddRubric.Size = new System.Drawing.Size(776, 120);
            this.groupBoxAddRubric.TabIndex = 0;
            this.groupBoxAddRubric.TabStop = false;
            this.groupBoxAddRubric.Text = "Add Rubric";
            // 
            // linkMain
            // 
            this.linkMain.AutoSize = true;
            this.linkMain.Location = new System.Drawing.Point(712, 101);
            this.linkMain.Name = "linkMain";
            this.linkMain.Size = new System.Drawing.Size(58, 13);
            this.linkMain.TabIndex = 5;
            this.linkMain.TabStop = true;
            this.linkMain.Text = "Main Page";
            this.linkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMain_LinkClicked);
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Location = new System.Drawing.Point(614, 101);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(73, 13);
            this.linkBack.TabIndex = 4;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back to CLOs";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(188, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddRubric
            // 
            this.btnAddRubric.Location = new System.Drawing.Point(68, 63);
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Size = new System.Drawing.Size(104, 23);
            this.btnAddRubric.TabIndex = 2;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.UseVisualStyleBackColor = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details";
            // 
            // txtRubricDetail
            // 
            this.txtRubricDetail.Location = new System.Drawing.Point(72, 37);
            this.txtRubricDetail.Name = "txtRubricDetail";
            this.txtRubricDetail.Size = new System.Drawing.Size(100, 20);
            this.txtRubricDetail.TabIndex = 0;
            // 
            // labelCLODetails
            // 
            this.labelCLODetails.AutoSize = true;
            this.labelCLODetails.Location = new System.Drawing.Point(21, 13);
            this.labelCLODetails.Name = "labelCLODetails";
            this.labelCLODetails.Size = new System.Drawing.Size(75, 13);
            this.labelCLODetails.TabIndex = 1;
            this.labelCLODetails.Text = "Add Rubric for";
            // 
            // groupBoxRubrics
            // 
            this.groupBoxRubrics.Controls.Add(this.dataGridViewRubrics);
            this.groupBoxRubrics.Location = new System.Drawing.Point(12, 239);
            this.groupBoxRubrics.Name = "groupBoxRubrics";
            this.groupBoxRubrics.Size = new System.Drawing.Size(776, 199);
            this.groupBoxRubrics.TabIndex = 2;
            this.groupBoxRubrics.TabStop = false;
            this.groupBoxRubrics.Text = "View Rubrics For";
            // 
            // dataGridViewRubrics
            // 
            this.dataGridViewRubrics.AllowUserToAddRows = false;
            this.dataGridViewRubrics.AllowUserToDeleteRows = false;
            this.dataGridViewRubrics.AllowUserToResizeColumns = false;
            this.dataGridViewRubrics.AllowUserToResizeRows = false;
            this.dataGridViewRubrics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRubrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRubrics.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewRubrics.Name = "dataGridViewRubrics";
            this.dataGridViewRubrics.Size = new System.Drawing.Size(754, 164);
            this.dataGridViewRubrics.TabIndex = 0;
            this.dataGridViewRubrics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRubrics_CellContentClick);
            // 
            // txtCLOId
            // 
            this.txtCLOId.Enabled = false;
            this.txtCLOId.Location = new System.Drawing.Point(68, 37);
            this.txtCLOId.Name = "txtCLOId";
            this.txtCLOId.ReadOnly = true;
            this.txtCLOId.Size = new System.Drawing.Size(100, 20);
            this.txtCLOId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CLO Id";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmManageRubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCLOId);
            this.Controls.Add(this.groupBoxRubrics);
            this.Controls.Add(this.labelCLODetails);
            this.Controls.Add(this.groupBoxAddRubric);
            this.Name = "frmManageRubrics";
            this.Text = "Manage Rubrics";
            this.Load += new System.EventHandler(this.frmManageRubrics_Load);
            this.groupBoxAddRubric.ResumeLayout(false);
            this.groupBoxAddRubric.PerformLayout();
            this.groupBoxRubrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRubrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddRubric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRubricDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddRubric;
        public System.Windows.Forms.Label labelCLODetails;
        public System.Windows.Forms.GroupBox groupBoxRubrics;
        public System.Windows.Forms.DataGridView dataGridViewRubrics;
        private System.Windows.Forms.LinkLabel linkMain;
        private System.Windows.Forms.LinkLabel linkBack;
        public System.Windows.Forms.TextBox txtCLOId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}