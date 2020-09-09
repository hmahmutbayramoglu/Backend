using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Bunifu.Framework.UI;
using System.Windows.Forms;

namespace BarkodOkutma.WindowsFormUI
{
   public class SqlCon
    {
        //SQL CONNECTION
        public SqlConnection connectionString = new SqlConnection(@"Data Source=WIN7-BILGISAYAR\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

        public void Connection()
        {
            try
            {
                if (connectionString.State == ConnectionState.Closed)
                    connectionString.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Sql Connection Error" , "ERROR" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        public void DisConnection()
        {
            try
            {
                if (connectionString.State == ConnectionState.Open)
                    connectionString.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sql DisConnection Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
