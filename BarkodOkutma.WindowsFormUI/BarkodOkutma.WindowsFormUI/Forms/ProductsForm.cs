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
using System.Diagnostics;

namespace BarkodOkutma.WindowsFormUI
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        SqlCon sqlCon = new SqlCon();
        MenuForm menuForm = new MenuForm();
        ProductPanelForm productPanelForm = new ProductPanelForm();

        public DataTable GetAll()
        {
            sqlCon.Connection();
            SqlCommand komut = new SqlCommand("SELECT * from Products", sqlCon.connectionString);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            da.Fill(table);
            sqlCon.DisConnection();
            return table;
        }


        List<UserControl1> Urunler = new List<UserControl1>();

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAll();

            for (int i = 0; i < 20; i++)
            {
                UserControl1 control1 = new UserControl1();
                Urunler.Add(control1);
            }
            tableLayoutPanel1.Controls.AddRange(Urunler.ToArray());

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.lbl_btncizgi.Visible = false;

        }

        private void btn_panel_Click(object sender, EventArgs e)
        {
            productPanelForm.ShowDialog();
        }
    }
}
