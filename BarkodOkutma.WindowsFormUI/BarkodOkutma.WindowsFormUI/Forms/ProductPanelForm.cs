using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodOkutma.WindowsFormUI
{
    public partial class ProductPanelForm : Form
    {
        public ProductPanelForm()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_İmage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturbox_Productİmage.ImageLocation = openFileDialog1.FileName;
            txt_İmageLocation.Text = openFileDialog1.FileName;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
