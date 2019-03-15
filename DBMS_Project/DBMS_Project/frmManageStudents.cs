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
using System.Text.RegularExpressions;

namespace DBMS_Project
{
    public partial class frmManageStudents : Form
    {

        public int selectedId;

        public frmManageStudents()
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            InitializeComponent();
            ShowStudentData();
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
            dataGridViewStudents.Columns.Add(btnUpdate);
            dataGridViewStudents.Columns.Add(btnDelete);
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            ShowStudentData();
            resetForm();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                MessageBox.Show("Please Enter Valid Values!");
                return;
            }
            int status = 1;
            
            if (btnAddStudent.Text == "Add Student")
            {
                if(!isUniqueEmail())
                {
                    MessageBox.Show("This Email Already Exists!");
                    return;
                }
                if(!isUniqueRegNo())
                {
                    MessageBox.Show("This Registration Number Already Exists!");
                    return;
                }
                if(!checkBoxActive.Checked)
                {
                    status = 0;
                }
                string query = "insert into dbo.Student( FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + this.txtFirstName.Text + "','" + this.txtLastName.Text + "','" + this.txtContact.Text + "','" + this.txtEmail.Text + "','" + this.txtRegNo.Text + "','" + status + "')";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                ShowStudentData();
                if (i != 0)
                {
                    MessageBox.Show("Student Added!");
                    resetForm();
                }
            }
            else if (btnAddStudent.Text == "Update Student")
            {

                string query = "select * from dbo.Student where ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        if (txtEmail.Text != oReader["Email"].ToString())
                        {
                            if (!isUniqueEmail())
                            {
                                MessageBox.Show("This Email Already Exists!");
                                return;
                            }
                        }
                        if (txtRegNo.Text != oReader["RegistrationNumber"].ToString())
                        {
                            if (!isUniqueRegNo())
                            {
                                MessageBox.Show("This Registration Number Already Exists!");
                                return;
                            }
                        }
                    }
                }
                query = "update dbo.Student set FirstName ='" + txtFirstName.Text + "', LastName ='" + txtLastName.Text + "', Contact ='" + txtContact.Text + "', Email ='" + txtEmail.Text + "', RegistrationNumber ='" + txtRegNo.Text +  "' Where Id ='" + selectedId + "' ";
                cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    ShowStudentData();
                    MessageBox.Show("Student Updated!");
                    resetForm();
                }
            }
        }

        
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            validateFirstName();
            
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            validateLastName();
        }

        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            validateContact();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            validateEmail();
        }

        private void txtRegNo_Validating(object sender, CancelEventArgs e)
        {
            validateRegNo();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewStudents.Columns["ID"].Index;
            selectedId = Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[index].Value);
            if (e.ColumnIndex == dataGridViewStudents.Columns["btnDelete"].Index)
            {
                string qeury = "delete from dbo.Student where ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowStudentData();
                MessageBox.Show("Student Deleted!");
            }
            else if(e.ColumnIndex == dataGridViewStudents.Columns["btnUpdate"].Index)
            {
                string qeury = "select * from dbo.Student where ID = '" + selectedId + "'";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while(oReader.Read())
                    {
                        txtFirstName.Text = oReader["FirstName"].ToString();
                        txtLastName.Text = oReader["LastName"].ToString();
                        txtContact.Text = oReader["Contact"].ToString();
                        txtEmail.Text = oReader["Email"].ToString();
                        txtRegNo.Text = oReader["RegistrationNumber"].ToString();
                        if(Convert.ToInt32(oReader["Status"]) == 0)
                        {
                            checkBoxActive.Checked = false;
                        }
                        else
                        {
                            checkBoxActive.Checked = true;
                        }
                        
                    }
                    
                }
                con.Close();
                btnAddStudent.Text = "Update Student";
                groupBoxAddStudent.Text = "Update Student";
                btnCancel.Enabled = true;
                btnCancel.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void linkMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain temp = frmMain.getObject();
            temp.Show();
            this.Close();
        }

        //
        // Helper Functions
        //

        private bool validateFirstName()
        {
            if (txtFirstName.Text == "")
            {
                errorProvider1.SetError(txtFirstName, "Please Enter First Name!");
                return false;
            }
            foreach (char c in txtFirstName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    errorProvider1.SetError(txtFirstName, "Please Enter a valid First Name!");
                    return false;
                }
            }
            errorProvider1.SetError(txtFirstName, "");
            return true;
        }

        private bool validateLastName()
        {
            foreach (char c in txtLastName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    errorProvider1.SetError(txtLastName, "Please Enter a valid Last Name!");
                    return false;
                }
            }
            errorProvider1.SetError(txtLastName, "");
            return true;
        }

        private bool validateContact()
        {
            if(txtContact.Text != "" && txtContact.Text.Length != 11)
            {
                errorProvider1.SetError(txtContact, "Please Enter a valid Contact Number!");
                return false;
            }
            foreach (char c in txtContact.Text)
            {
                if (!char.IsDigit(c))
                {
                    errorProvider1.SetError(txtContact, "Please Enter a valid Contact Number!");
                    return false;
                }
            }
            errorProvider1.SetError(txtContact, "");
            return true;
        }

        private bool validateEmail()
        {
            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Please Enter Email Address!");
                return false;
            }
            Regex rEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if(!rEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Please Enter a valid Email Address!");
                return false;
            }
            errorProvider1.SetError(txtEmail, "");
            return true;
        }

        private bool validateRegNo()
        {
            if (txtRegNo.Text == "")
            {
                errorProvider1.SetError(txtRegNo, "Please Enter Registration Number!");
                return false;
            }
            Regex rRegNo = new Regex(@"^[0-9]{4}-(([A-Z]{3})|([A-Z]{2}))-[0-9]{3}$");
            if (!rRegNo.IsMatch(txtRegNo.Text))
            {
                errorProvider1.SetError(txtRegNo, "Please Enter a valid Registration Number!");
                return false;
            }
            
            errorProvider1.SetError(txtRegNo, "");
            return true;
        }

        private bool isUniqueEmail()
        {
            string query = "select count(*) from dbo.Student where Email = '" + txtEmail.Text + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int records = (int)cmd.ExecuteScalar();
            con.Close();
            if (records > 0)
            {
                errorProvider1.SetError(txtEmail, "This Email Address Already Exists!");
                return false;
            }
            errorProvider1.SetError(txtEmail, "");
            return true;
        }

        private bool isUniqueRegNo()
        {
            string query = "select count(*) from dbo.Student where RegistrationNumber = '" + txtRegNo.Text + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int records = (int)cmd.ExecuteScalar();
            con.Close();
            if (records > 0)
            {
                errorProvider1.SetError(txtRegNo, "This Registration Number Already Exists!");
                return false;
            }
            errorProvider1.SetError(txtRegNo, "");
            return true;
        }

        private void ShowStudentData()
        {
            string query = "select * from dbo.Student";
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewStudents.DataSource = ds.Tables[0];
            con.Close();
        }

        private void resetForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNo.Text = "";
            btnCancel.Enabled = false;
            btnCancel.Visible = false;
            btnAddStudent.Text = "Add Student";
            groupBoxAddStudent.Text = "Add Student";
            checkBoxActive.Checked = true;
        }

        private bool validateForm()
        {
            return validateFirstName() && validateLastName() && validateContact() &&
                    validateEmail() && validateRegNo();
        }
    }
}
