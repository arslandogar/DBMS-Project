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
    public partial class frmManageComponents : Form
    {
        private int selectedId;
        public int AssessmentMarks;
        public frmManageComponents()
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            InitializeComponent();
            ShowComponentsData();
            //
            // btnUpdate
            // 
            btnUpdate.HeaderText = "Update";
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ReadOnly = true;
            btnUpdate.Text = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridViewComponents.Columns.Add(btnUpdate);
            dataGridViewComponents.Columns.Add(btnDelete);
        }

        

        private void dataGridViewComponents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewComponents.Columns["ID"].Index;
            selectedId = Convert.ToInt32(dataGridViewComponents.Rows[e.RowIndex].Cells[index].Value);
            if (e.ColumnIndex == dataGridViewComponents.Columns["btnDelete"].Index)
            {
                string query = "DELETE FROM dbo.AssessmentComponent WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowComponentsData();
                MessageBox.Show("Component Deleted!");
                query = "UPDATE dbo.Clo SET DateUpdated ='" + DateTime.Now + "' Where Id ='" + txtAssessmentId.Text + "'";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (e.ColumnIndex == dataGridViewComponents.Columns["btnUpdate"].Index)
            {
                string qeury = "SELECT * FROM dbo.AssessmentComponent WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        txtName.Text = oReader["Name"].ToString();
                        txtMarks.Text = oReader["TotalMarks"].ToString();
                        txtRubric.Text = "Select Rubric";
                    }

                }
                con.Close();
                btnAddComponent.Text = "Update Component";
                groupBoxAddComponent.Text = "Update Component";
                btnCancel.Enabled = true;
                btnCancel.Visible = true;
            }
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            if(!validateForm())
            {
                MessageBox.Show("Please Enter Valid Values!");
                return;
            }
            string rubricId = "";
            foreach (char c in txtRubric.Text)
            {
                if (c == ':')
                {
                    break;
                }
                rubricId += c;
            }
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            if (btnAddComponent.Text == "Add Component")
            {
                string query = "INSERT INTO dbo.AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) values('"+ txtName.Text + "','" + rubricId + "','" + txtMarks.Text + "', '" + DateTime.Now + "', '" + DateTime.Now + "', '" + txtAssessmentId.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                ShowComponentsData();
                if (i != 0)
                {
                    MessageBox.Show("Component Added!");
                    resetForm();
                }
            }
            else if (btnAddComponent.Text == "Update Component")
            {
                string query = "UPDATE dbo.AssessmentComponent SET Name ='" + txtName.Text + "', TotalMarks ='" + txtMarks.Text + "', RubricId ='" + rubricId + "', DateUpdated ='" + DateTime.Now + "' Where Id ='" + selectedId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    ShowComponentsData();
                    MessageBox.Show("Component Updated!");
                    resetForm();
                }
            }
        }

        

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageAssessments temp = new frmManageAssessments();
            temp.Show();
            this.Close();
        }

        private void linkMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain temp = frmMain.getObject();
            temp.Show();
            this.Close();
        }

        private void frmManageRubrics_Load(object sender, EventArgs e)
        {
            
            resetForm();
            ShowComponentsData();
        }

        private void txtRubricDetail_Validating(object sender, CancelEventArgs e)
        {
            validateForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void txtRubric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            validateName();
        }

        private void txtMarks_Validating(object sender, CancelEventArgs e)
        {
            validateMarks();
        }

        //
        // Helper Functions
        //

        public void ShowComponentsData()
        {
            string item;
            string query = "SELECT * FROM dbo.AssessmentComponent WHERE AssessmentId = '" + txtAssessmentId.Text + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewComponents.DataSource = ds.Tables[0];
            con.Close();
            query = "SELECT * FROM dbo.Rubric";
            cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    item = oReader["Id"].ToString() + ": " + oReader["Details"].ToString();
                    txtRubric.Items.Add(item);
                    
                }

            }
            con.Close();

        }

        private bool validateName()
        {
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Please Enter Name Of Component!");
                return false;
            }
            errorProvider1.SetError(txtName, "");
            return true;
        }

        private bool validateMarks()
        {
            if(txtMarks.Text == "")
            {
                errorProvider1.SetError(txtMarks, "Please Enter Marks Of Component!");
                return false;
            }
            foreach(char c in txtMarks.Text)
            {
                if(!char.IsDigit(c))
                {
                    errorProvider1.SetError(txtMarks, "Please Enter Digits Only!");
                    return false;
                }
            }
            int allowedMarks = AssessmentMarks;
            int assignedMarks = 0;
            string query = "SELECT * FROM dbo.AssessmentComponent WHERE AssessmentId = '" + txtAssessmentId.Text + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    assignedMarks += int.Parse(oReader["TotalMarks"].ToString());

                }

            }
            allowedMarks = AssessmentMarks - assignedMarks;
            con.Close();
            if(int.Parse(txtMarks.Text) > allowedMarks)
            {
                errorProvider1.SetError(txtMarks, "Maximum " + allowedMarks.ToString() + " Marks Are Allowed For This Component!");
                return false;
            }



            errorProvider1.SetError(txtMarks, "");
            return true;
        }

        private bool validateRubric()
        {
            if(txtRubric.Text == "Select Rubric")
            {
                return false;
            }
            return true; ;
        }
        private bool validateForm()
        {
            if(!validateName())
            {
                return false;
            }
            if(!validateMarks())
            {
                return false;

            }
            if (!validateRubric())
            {
                return false;

            }
            return true;
        }

        private void resetForm()
        {
            txtName.Text = "";
            txtMarks.Text = "";
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnAddComponent.Text = "Add Component";
            groupBoxAddComponent.Text = "Add Component";
        }

        
    }
}
