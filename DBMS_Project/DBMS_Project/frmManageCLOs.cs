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
    public partial class frmManageCLOs : Form
    {
        public int selectedId;
        public frmManageCLOs()
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnRubrics = new DataGridViewButtonColumn();
            InitializeComponent();
            ShowCLOData();
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
            btnRubrics.HeaderText = "Modify Rubrics";
            btnRubrics.Name = "btnRubrics";
            btnRubrics.ReadOnly = true;
            btnRubrics.Text = "Modify Rubrics";
            btnRubrics.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;

            dataGridViewCLOs.Columns.Add(btnUpdate);
            dataGridViewCLOs.Columns.AddRange(btnRubrics);
            dataGridViewCLOs.Columns.Add(btnDelete);
        }

        private void btnAddCLO_Click(object sender, EventArgs e)
        {
            if(!validateForm())
            {
                MessageBox.Show("Please Enter Valid Name!");
                return;
            }
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            if (btnAddCLO.Text == "Add CLO")
            {
                string query = "INSERT INTO dbo.Clo( Name, DateCreated, DateUpdated) values('" + this.txtCLOName.Text + "','" + DateTime.Now + "','" + DateTime.Now + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                ShowCLOData();
                if (i != 0)
                {
                    MessageBox.Show("CLO Added!");
                    resetForm();
                }
            }
            else if(btnAddCLO.Text == "Update CLO")
            {
                string query = "UPDATE dbo.Clo SET Name ='" + txtCLOName.Text + "', DateUpdated ='" + DateTime.Now + "' Where Id ='" + selectedId + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    ShowCLOData();
                    MessageBox.Show("CLO Updated!");
                    resetForm();
                }
            }


        }

        private void dataGridViewCLOs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewCLOs.Columns["ID"].Index;
            selectedId = Convert.ToInt32(dataGridViewCLOs.Rows[e.RowIndex].Cells[index].Value);
            if (e.ColumnIndex == dataGridViewCLOs.Columns["btnDelete"].Index)
            {
                string qeury = "DELETE FROM dbo.Clo WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowCLOData();
                MessageBox.Show("CLO Deleted!");
            }
            else if (e.ColumnIndex == dataGridViewCLOs.Columns["btnUpdate"].Index)
            {
                string qeury = "SELECT * FROM dbo.Clo WHERE ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        txtCLOName.Text = oReader["Name"].ToString();
                    }

                }
                con.Close();
                btnAddCLO.Text = "Update CLO";
                groupBoxAddCLO.Text = "Update CLO";
                btnCancel.Enabled = true;
                btnCancel.Visible = true;
            }
            else if (e.ColumnIndex == dataGridViewCLOs.Columns["btnRubrics"].Index)
            {
                openRubricsForm();
            }
        }

        private void linkMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain temp = frmMain.getObject();
            temp.Show();
            this.Close();
        }

        private void frmManageCLOs_Load(object sender, EventArgs e)
        {
            resetForm();
            ShowCLOData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void txtCLOName_Validating(object sender, CancelEventArgs e)
        {
            validateForm();
        }

        //
        // Helper Functions
        //

        private void ShowCLOData()
        {
            string query = "SELECT * FROM dbo.Clo";
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCLOs.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool validateForm()
        {
            if(txtCLOName.Text == "")
            {
                errorProvider1.SetError(txtCLOName, "Please Enter Name For CLO!");
                return false;
            }
            else if(txtCLOName.Text.Length > 50)
            {
                errorProvider1.SetError(txtCLOName, "Maximun 50 Characters Are Allowed!");
                return false;
            }
            errorProvider1.SetError(txtCLOName, "");
            return true;
        }

        private void resetForm()
        {
            txtCLOName.Text = "";
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnAddCLO.Text = "Add CLO";
            groupBoxAddCLO.Text = "Add CLO";
        }

        private void openRubricsForm()
        {
            string name;
            frmManageRubrics temp = new frmManageRubrics();
            string qeury = "SELECT * FROM dbo.Clo WHERE ID = '" + selectedId + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(qeury, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    name = oReader["Name"].ToString();
                    temp.labelCLODetails.Text = "Add Rubric For CLO: " + name;
                    temp.groupBoxRubrics.Text = "View Rubrics For CLO: " + name;
                    temp.txtCLOId.Text = selectedId.ToString();
                }

            }
            con.Close();
            temp.Show();
            this.Close();
        }
    }
}
