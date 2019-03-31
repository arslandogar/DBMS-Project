using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_Project
{
    public partial class frmMarkAttendance : Form
    {
        public frmMarkAttendance()
        {
            InitializeComponent();
        }

        private void frmMarkAttendance_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Student WHERE Status = '" + Lookup.Active + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    txtRegNo.Items.Add(oReader["RegistrationNumber"].ToString());
                }

                con.Close();
            }
            txtAStatus.Items.Add("Present");
            txtAStatus.Items.Add("Absent");
            txtAStatus.Items.Add("Leave");
            txtAStatus.Items.Add("Late");
            txtAStatus.Text = "Select";
            txtRegNo.Text = "Select";
            showData();
        }

        

        private void txtRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void linkMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain temp = frmMain.getObject();
            temp.Show();
            this.Close();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            if(!validateForm())
            {
                return;
            }
            if(!isClassAttendanceExists())
            {
                addClassAttendance();
            }
            if(isStudentAttendanceExists())
            {
                MessageBox.Show("Attendance Of Selected Student Is Already Marked!");
                return;
            }
            else
            {
                string query = "INSERT INTO dbo.StudentAttendance( AttendanceId, StudentId, AttendanceStatus) values('" + getAttendanceId() + "','" + getStudentId() + "','" + getStatus() + "')";
                SqlConnection con = new SqlConnection(DBClass.conString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Attendance Marked!");
            showData();

        }

        //
        // Helper Functions
        //

        private void showData()
        {
            
            string query = "SELECT * FROM dbo.StudentAttendance";
            SqlConnection con = new SqlConnection(DBClass.conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAttendance.DataSource = ds.Tables[0];
            con.Close();
        }

        private bool isClassAttendanceExists()
        {
            string query = "SELECT COUNT(*) FROM dbo.ClassAttendance WHERE AttendanceDate = '" + DateTime.Now.Date + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int records = (int)cmd.ExecuteScalar();
            con.Close();
            if (records > 0)
            {
                return true;
            }
            return false ;
        }

        private void addClassAttendance()
        {
            string query = "INSERT INTO dbo.ClassAttendance( AttendanceDate) values('" + DateTime.Now.Date +  "')";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

        private int getAttendanceId()
        {
            int id = 0;
            string query = "SELECT * FROM dbo.ClassAttendance WHERE AttendanceDate = '" + DateTime.Now.Date + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                   id =  int.Parse(oReader["Id"].ToString());
                }
                con.Close();
            }
            return id;
        }

        private int getStudentId()
        {
            int id = 0;
            string query = "SELECT * FROM dbo.Student WHERE RegistrationNumber = '" + txtRegNo.Text + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    id = int.Parse(oReader["Id"].ToString());
                }
                con.Close();
            }
            return id;
        }

        private bool isStudentAttendanceExists()
        {
            string query = "SELECT COUNT(*) FROM dbo.StudentAttendance WHERE StudentId = '" + getStudentId() + "'";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int records = (int)cmd.ExecuteScalar();
            con.Close();
            if (records > 0)
            {
                return true;
            }
            return false;
        }

        private int getStatus()
        {
            if (txtAStatus.Text == "Present")
            {
                return Lookup.Present;
            }
            else if (txtAStatus.Text == "Absent")
            {
                return Lookup.Absent;
            }
            else if (txtAStatus.Text == "Leave")
            {
                return Lookup.Leave;
            }
            else if (txtAStatus.Text == "Late")
            {
                return Lookup.Late;
            }
            return 0;
        }

        private bool validateForm()
        {
            if(txtAStatus.Text == "Select")
            {
                return false;
            }
            if(txtRegNo.Text == "Select")
            {
                return false;
            }
            return true;
        }
    }
}
