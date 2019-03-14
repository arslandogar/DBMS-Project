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

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageStudents temp = new frmManageStudents();
            temp.Show();
            this.Hide();
        }
    }
}
