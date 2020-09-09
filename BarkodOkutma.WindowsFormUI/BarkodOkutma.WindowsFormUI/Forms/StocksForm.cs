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

namespace BarkodOkutma.WindowsFormUI
{
    public partial class StocksForm : Form
    {
        public StocksForm()
        {
            InitializeComponent();
        }

        SqlCon sqlCon = new SqlCon();

        public DataTable GetAll()
        {
            sqlCon.Connection();
            SqlCommand komut = new SqlCommand("SELECT * from Orders", sqlCon.connectionString);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            da.Fill(table);
            sqlCon.DisConnection();
            return table;
        }

        private void StocksForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAll();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
