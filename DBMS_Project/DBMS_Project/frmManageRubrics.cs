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
    public partial class frmManageRubrics : Form
    {
        private int selectedId;
        public frmManageRubrics()
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            InitializeComponent();
            ShowRubricsData();
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
            dataGridViewRubrics.Columns.Add(btnUpdate);
            dataGridViewRubrics.Columns.Add(btnDelete);
        }

        

        private void dataGridViewRubrics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewRubrics.Columns["ID"].Index;
            selectedId = Convert.ToInt32(dataGridViewRubrics.Rows[e.RowIndex].Cells[index].Value);
            if (e.ColumnIndex == dataGridViewRubrics.Columns["btnDelete"].Index)
            {
                string query = "DELETE FROM dbo.Rubric WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowRubricsData();
                MessageBox.Show("Rubric Deleted!");
                query = "UPDATE dbo.Clo SET DateUpdated ='" + DateTime.Now + "' Where Id ='" + txtCLOId.Text + "'";
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (e.ColumnIndex == dataGridViewRubrics.Columns["btnUpdate"].Index)
            {
                string qeury = "SELECT * FROM dbo.Rubric WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        txtRubricDetail.Text = oReader["Details"].ToString();
                    }

                }
                con.Close();
                btnAddRubric.Text = "Update Rubric";
                groupBoxAddRubric.Text = "Update Rubric";
                btnCancel.Enabled = true;
                btnCancel.Visible = true;
            }
        }

        private void btnAddRubric_Click(object sender, EventArgs e)
        {
            if(!validateForm())
            {
                MessageBox.Show("Please Enter Details!");
                return;
            }
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            if (btnAddRubric.Text == "Add Rubric")
            {
                Random r = new Random();
                string query = "INSERT INTO dbo.Rubric(Id, Details, CloId) values('"+ r.Next() + "','" + this.txtRubricDetail.Text + "','" + Convert.ToInt32(this.txtCLOId.Text) + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                ShowRubricsData();
                if (i != 0)
                {
                    MessageBox.Show("Rubric Added!");
                    query = "UPDATE dbo.Clo SET DateUpdated ='" + DateTime.Now + "' Where Id ='" + txtCLOId.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    resetForm();
                }
            }
            else if (btnAddRubric.Text == "Update Rubric")
            {
                string query = "UPDATE dbo.Rubric SET Details ='" + txtRubricDetail.Text + "' Where Id ='" + selectedId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    ShowRubricsData();
                    MessageBox.Show("Rubric Updated!");
                    query = "UPDATE dbo.Clo SET DateUpdated ='" + DateTime.Now + "' Where Id ='" + txtCLOId.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    resetForm();
                }
            }
        }

        

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageCLOs temp = new frmManageCLOs();
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
            ShowRubricsData();
        }

        private void txtRubricDetail_Validating(object sender, CancelEventArgs e)
        {
            validateForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        //
        // Helper Functions
        //

        public void ShowRubricsData()
        {
            string query = "SELECT * FROM dbo.Rubric WHERE CloId = '" + txtCLOId.Text + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRubrics.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool validateForm()
        {
            if (txtRubricDetail.Text == "")
            {
                errorProvider1.SetError(txtRubricDetail, "Please Enter Details Of CLO!");
                return false;
            }
            errorProvider1.SetError(txtRubricDetail, "");
            return true;
        }

        private void resetForm()
        {
            txtRubricDetail.Text = "";
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnAddRubric.Text = "Add Rubric";
            groupBoxAddRubric.Text = "Add Rubric";
        }

        
    }
}
