using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBMS_Project
{
    class Lookup
    {
        public static int Present;
        public static int Absent;
        public static int Leave;
        public static int Late;
        public static int Active;
        public static int InActive;

        public static void makeLookUp()
        {
            string name;
            string query = "SELECT * FROM dbo.Lookup";
            SqlConnection con = new SqlConnection(DBClass.conString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            using (SqlDataReader oReader = cmd.ExecuteReader())
            {

                while (oReader.Read())
                {
                    name = oReader["Name"].ToString();
                    if (name == "Present")
                    {
                        Present = int.Parse(oReader["LookupId"].ToString());
                    }
                    else if (name == "Absent")
                    {
                        Absent = int.Parse(oReader["LookupId"].ToString());
                    }
                    else if (name == "Leave")
                    {
                        Leave = int.Parse(oReader["LookupId"].ToString());
                    }
                    else if (name == "Late")
                    {
                        Late = int.Parse(oReader["LookupId"].ToString());
                    }
                    else if (name == "Active")
                    {
                        Active = int.Parse(oReader["LookupId"].ToString());
                    }
                    else if (name == "InActive")
                    {
                        InActive = int.Parse(oReader["LookupId"].ToString());
                    }
                }


            }
        }
    }
}
