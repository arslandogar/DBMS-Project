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
    public partial class frmManageStudents : Form
    {
        public string conString = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog = ProjectB; Integrated Security = True";
        public frmManageStudents()
        {
            InitializeComponent();
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            ShowStudentData();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string qeury = "insert into dbo.Student( FirstName,LastName,Contact,Email,RegistrationNumber,Status) values('" + this.txtFirstName.Text + "','" + this.txtLastName.Text + "','" + this.txtContact.Text + "','" + this.txtEmail.Text + "','" + this.txtRegNo.Text + "','" + 2 + "')";
            SqlConnection con = new SqlConnection(@conString);
            SqlCommand cmd = new SqlCommand(qeury, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            ShowStudentData();
            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }

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
    }
}
