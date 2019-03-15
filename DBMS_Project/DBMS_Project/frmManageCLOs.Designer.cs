namespace DBMS_Project
{
    partial class frmManageCLOs
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
            this.groupBoxAddCLO = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.btnAddCLO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCLOs = new System.Windows.Forms.GroupBox();
            this.dataGridViewCLOs = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.linkMain = new System.Windows.Forms.LinkLabel();
            this.groupBoxAddCLO.SuspendLayout();
            this.groupBoxCLOs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLOs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddCLO
            // 
            this.groupBoxAddCLO.Controls.Add(this.linkMain);
            this.groupBoxAddCLO.Controls.Add(this.btnCancel);
            this.groupBoxAddCLO.Controls.Add(this.txtCLOName);
            this.groupBoxAddCLO.Controls.Add(this.btnAddCLO);
            this.groupBoxAddCLO.Controls.Add(this.label1);
            this.groupBoxAddCLO.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAddCLO.Name = "groupBoxAddCLO";
            this.groupBoxAddCLO.Size = new System.Drawing.Size(776, 120);
            this.groupBoxAddCLO.TabIndex = 0;
            this.groupBoxAddCLO.TabStop = false;
            this.groupBoxAddCLO.Text = "Add CLO";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(208, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCLOName
            // 
            this.txtCLOName.Location = new System.Drawing.Point(80, 37);
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(111, 20);
            this.txtCLOName.TabIndex = 3;
            this.txtCLOName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCLOName_Validating);
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.Location = new System.Drawing.Point(92, 63);
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.Size = new System.Drawing.Size(75, 23);
            this.btnAddCLO.TabIndex = 2;
            this.btnAddCLO.Text = "Add CLO";
            this.btnAddCLO.UseVisualStyleBackColor = true;
            this.btnAddCLO.Click += new System.EventHandler(this.btnAddCLO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLOName";
            // 
            // groupBoxCLOs
            // 
            this.groupBoxCLOs.Controls.Add(this.dataGridViewCLOs);
            this.groupBoxCLOs.Location = new System.Drawing.Point(12, 164);
            this.groupBoxCLOs.Name = "groupBoxCLOs";
            this.groupBoxCLOs.Size = new System.Drawing.Size(776, 274);
            this.groupBoxCLOs.TabIndex = 1;
            this.groupBoxCLOs.TabStop = false;
            this.groupBoxCLOs.Text = "View CLOs";
            // 
            // dataGridViewCLOs
            // 
            this.dataGridViewCLOs.AllowUserToAddRows = false;
            this.dataGridViewCLOs.AllowUserToDeleteRows = false;
            this.dataGridViewCLOs.AllowUserToResizeColumns = false;
            this.dataGridViewCLOs.AllowUserToResizeRows = false;
            this.dataGridViewCLOs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCLOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCLOs.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewCLOs.Name = "dataGridViewCLOs";
            this.dataGridViewCLOs.ReadOnly = true;
            this.dataGridViewCLOs.Size = new System.Drawing.Size(751, 228);
            this.dataGridViewCLOs.TabIndex = 2;
            this.dataGridViewCLOs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCLOs_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // linkMain
            // 
            this.linkMain.AutoSize = true;
            this.linkMain.Location = new System.Drawing.Point(712, 104);
            this.linkMain.Name = "linkMain";
            this.linkMain.Size = new System.Drawing.Size(58, 13);
            this.linkMain.TabIndex = 14;
            this.linkMain.TabStop = true;
            this.linkMain.Text = "Main Page";
            this.linkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMain_LinkClicked);
            // 
            // frmManageCLOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCLOs);
            this.Controls.Add(this.groupBoxAddCLO);
            this.Name = "frmManageCLOs";
            this.Text = "ManageCLOs";
            this.Load += new System.EventHandler(this.frmManageCLOs_Load);
            this.groupBoxAddCLO.ResumeLayout(false);
            this.groupBoxAddCLO.PerformLayout();
            this.groupBoxCLOs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLOs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddCLO;
        private System.Windows.Forms.Button btnAddCLO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCLOs;
        private System.Windows.Forms.DataGridView dataGridViewCLOs;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel linkMain;
    }
}