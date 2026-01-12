using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalVRM.Helpers
{
    internal class dbHelpers
    {
        
    public static class dbHelper

        {
            private static string connectionString = ConfigurationManager.ConnectionStrings["VRMConnection"].ConnectionString;

            public static MySqlConnection GetConnection()
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    return conn;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Failed: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}

