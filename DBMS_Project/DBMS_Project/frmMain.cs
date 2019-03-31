using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class frmMain : Form
    {
        private static frmMain obj = null;

        public static frmMain getObject()
        {
            if(obj == null)
            {
                obj = new frmMain(); 
            }
            return obj;
        }
        private frmMain()
        {
            InitializeComponent();
        }

        private void linkManageStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageStudents temp = new frmManageStudents();
            temp.Show();
            this.Hide();
        }

        private void linkManageCLOR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageCLOs temp = new frmManageCLOs();
            temp.Show();
            this.Hide();
        }

        private void linkManageAssessments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmManageAssessments temp = new frmManageAssessments();
            temp.Show();
            this.Hide();
        }

        private void linkMarkAttendance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMarkAttendance temp = new frmMarkAttendance();
            temp.Show();
            this.Hide();
        }
    }
}
