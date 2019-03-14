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
        public string conString = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog = ProjectB; Integrated Security = True";
        public frmManageStudents()
        {
            InitializeComponent();
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
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
            // 
            dataGridViewStudents.ReadOnly = true;
            ShowStudentData();
            dataGridViewStudents.Columns.Add(btnUpdate);
            dataGridViewStudents.Columns.Add(btnDelete);

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(!validateForm())
            {
                MessageBox.Show("Please Enter Valid Values!");
                return;
            }
            string qeury = "insert into dbo.Student( FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + this.txtFirstName.Text + "','" + this.txtLastName.Text + "','" + this.txtContact.Text + "','" + this.txtEmail.Text + "','" + this.txtRegNo.Text + "','" + 1 + "')";
            SqlConnection con = new SqlConnection(@conString);
            SqlCommand cmd = new SqlCommand(qeury, con);
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

        
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(!validateFirstName())
            {
                e.Cancel = true;
            }
            
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if(!validateLastName())
            {
                e.Cancel = true;
            }
        }

        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            if(!validateContact())
            {
                e.Cancel = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!validateEmail())
            {
                e.Cancel = true;
            }
        }

        private void txtRegNo_Validating(object sender, CancelEventArgs e)
        {
            if(!validateRegNo())
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewStudents.Columns["ID"].Index;
            int id = Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells[index].Value);
            if (e.ColumnIndex == dataGridViewStudents.Columns["btnDelete"].Index)
            {
                string qeury = "delete from dbo.Student where ID = '" + id + "'";
                SqlConnection con = new SqlConnection(@conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ShowStudentData();
            }
            else if(e.ColumnIndex == dataGridViewStudents.Columns["btnUpdate"].Index)
            {
                string qeury = "select * from dbo.Student where ID = '" + id + "'";
                SqlConnection con = new SqlConnection(@conString);
                SqlCommand cmd = new SqlCommand(qeury, con);
                con.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        txtFirstName.Text = oReader["FirstName"].ToString();
                    }
                }
                con.Close();
                ShowStudentData();
            }
            
            //if (e.ColumnIndex == dataClo.Columns["delete"].Index)
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

        private void ShowStudentData()
        {
            string query = "select * from dbo.Student";
            SqlConnection con = new SqlConnection(@conString);
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
        }

        private bool validateForm()
        {
            if(txtFirstName.Text == "" || txtEmail.Text == "" || txtRegNo.Text == "")
            {
                return false;
            }
            return true;
        }

        
    }
}
