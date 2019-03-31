using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmManageAssessments : Form
    {
        public int selectedId;
        public frmManageAssessments()
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnComponents = new DataGridViewButtonColumn();
            InitializeComponent();
            ShowAssessmentData();
            //
            // btnUpdate
            // 
            btnUpdate.HeaderText = "Update";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ReadOnly = true;
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            // 
            // btnRubrics
            // 
            btnComponents.HeaderText = "Modify Components";
            btnComponents.Name = "btnComponents";
            btnComponents.ReadOnly = true;
            btnComponents.Text = "Modify Components";
            btnComponents.UseColumnTextForButtonValue = true;
            btnComponents.MinimumWidth = 104;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            dataGridViewAssessments.Columns.Add(btnUpdate);
            dataGridViewAssessments.Columns.AddRange(btnComponents);
            dataGridViewAssessments.Columns.Add(btnDelete);
        }

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            if(!validateForm())
            {
                MessageBox.Show("Please Enter Valid Values!");
                return;
            }
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            if (btnAddAssessment.Text == "Add Assessment")
            {
                string query = "INSERT INTO dbo.Assessment( Title, DateCreated, TotalMarks, TotalWeightage) values('" + this.txtTitle.Text + "','" + DateTime.Now + "','" + txtMarks.Text + "' , '" + txtWeightage.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                ShowAssessmentData();
                if (i != 0)
                {
                    MessageBox.Show("Assessment Added!");
                    resetForm();
                }
            }
            else if(btnAddAssessment.Text == "Update Assessment")
            {
                string query = "UPDATE dbo.Assessment SET Title ='" + txtTitle.Text + "', TotalMarks ='" + txtMarks.Text + "', TotalWeightage ='" + txtWeightage.Text + "' Where Id ='" + selectedId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    ShowAssessmentData();
                    MessageBox.Show("Assessment Updated!");
                    resetForm();
                }
            }


        }

        private void dataGridViewAssessments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewAssessments.Columns["ID"].Index;
            selectedId = Convert.ToInt32(dataGridViewAssessments.Rows[e.RowIndex].Cells[index].Value);
            if (e.ColumnIndex == dataGridViewAssessments.Columns["btnDelete"].Index)
            {
                string qeury = "DELETE FROM dbo.Assessment WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowAssessmentData();
                MessageBox.Show("Assessment Deleted!");
            }
            else if (e.ColumnIndex == dataGridViewAssessments.Columns["btnUpdate"].Index)
            {
                string qeury = "SELECT * FROM dbo.Assessment WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        txtTitle.Text = oReader["Title"].ToString();
                        txtMarks.Text = oReader["TotalMarks"].ToString();
                        txtWeightage.Text = oReader["TotalWeightage"].ToString();
                    }

                }
                con.Close();
                btnAddAssessment.Text = "Update Assessment";
                groupBoxAddAssessment.Text = "Update Assessment";
                btnCancel.Enabled = true;
                btnCancel.Visible = true;
            }
            else if (e.ColumnIndex == dataGridViewAssessments.Columns["btnComponents"].Index)
            {
                openComponentsForm();
            }
        }

        private void linkMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain temp = frmMain.getObject();
            temp.Show();
            this.Close();
        }

        private void frmManageAssessments_Load(object sender, EventArgs e)
        {
            resetForm();
            ShowAssessmentData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            validateTitle();
        }

        private void txtMarks_Validating(object sender, CancelEventArgs e)
        {
            validateMarks();
        }

        private void txtWeightage_Validating(object sender, CancelEventArgs e)
        {
            validateWeightage();
        }



        //
        // Helper Functions
        //

        private void ShowAssessmentData()
        {
            string query = "SELECT * FROM dbo.Assessment";
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAssessments.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool validateTitle()
        {
            if (txtTitle.Text == "")
            {
                errorProvider1.SetError(txtTitle, "Please Enter Name For Assessment!");
                return false;
            }


            else if (txtTitle.Text.Length > 50)
            {
                errorProvider1.SetError(txtTitle, "Maximun 50 Characters Are Allowed!");
                return false;
            }
            errorProvider1.SetError(txtTitle, "");
            return true;

        }

        private bool validateMarks()
        {
            if (txtMarks.Text == "")
            {
                errorProvider1.SetError(txtMarks, "Please Enter Valid Value For Marks!");
                return false;
            }
            foreach(char c in txtMarks.Text)
            {
                if(!char.IsDigit(c))
                {
                    errorProvider1.SetError(txtMarks, "Please Enter Valid Value For Marks!");
                    return false;
                }
            }
            errorProvider1.SetError(txtMarks, "");
            return true;
        }

        private bool validateWeightage()
        {
            if (txtWeightage.Text == "")
            {
                errorProvider1.SetError(txtWeightage, "Please Enter Valid Value For Marks!");
                return false;
            }
            foreach (char c in txtWeightage.Text)
            {
                if (!char.IsDigit(c))
                {
                    errorProvider1.SetError(txtWeightage, "Please Enter Valid Value For Marks!");
                    return false;
                }
            }
            errorProvider1.SetError(txtWeightage, "");
            return true;
        }

        private bool validateForm()
        {
            if(!validateTitle())
            {
                return false;
            }
            if(!validateMarks())
            {
                return false;
            }
            if(!validateWeightage())
            {
                return false;
            }
            return true;
            
        }

        private void resetForm()
        {
            txtTitle.Text = "";
            txtMarks.Text = "";
            txtWeightage.Text = "";
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnAddAssessment.Text = "Add Assessment";
            groupBoxAddAssessment.Text = "Add Assessment";
        }

        private void openComponentsForm()
        {
            string title;
            frmManageComponents temp = new frmManageComponents();
            string qeury = "SELECT * FROM dbo.Assessment WHERE ID = '" + selectedId + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(qeury, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    title = oReader["Title"].ToString();
                    temp.AssessmentMarks = int.Parse(oReader["TotalMarks"].ToString());
                    temp.labelComponentDetails.Text = "Add Component For Assessment: " + title;
                    temp.groupBoxComponents.Text = "View Components For Assessment: " + title;
                    temp.txtAssessmentId.Text = selectedId.ToString();
                }

            }
            con.Close();
            temp.Show();
            this.Close();
        }

        
    }
}
