using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    class DatabaseConnection
    {
        public static SqlConnection getConnection()
        {
            try
            {
                //String connString = "Data Source=TEKLEHAYMANOT\\SQLEXPRESS;Initial Catalog=DB_Debregelila;Integrated Security=True";
                String connString = "Data Source=Teklehaymanot;" +
                    "Initial Catalog=DB_Debregelila;Integrated Security=True;MultipleActiveResultSets=true";

                // Integrated Security=True;Connect Timeout=30
                //String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_Debregelila.mdf;Trusted_Connection=Yes;Integrated Security=True";
                //String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_Debregelila.mdf;Trusted_Connection=Yes;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
