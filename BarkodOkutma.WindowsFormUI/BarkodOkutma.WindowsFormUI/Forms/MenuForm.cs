using Bunifu.Framework.UI;
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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();

            activeform = childform;

            childform.TopLevel = false;

            childform.FormBorderStyle = FormBorderStyle.None;

            childform.Dock = DockStyle.Fill;

            Panel_Fill.Controls.Add(childform);

            Panel_Fill.Tag = childform;

            childform.BringToFront();
            childform.Show();

        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_MenuAnimator_Click(object sender, EventArgs e)
        {
            if (Panel_Left.Width == 240)
            {
                Panel_Left.Width = 55;
                lbl_LogoLine.Visible = false;
                Panel_Left.Visible = false;
                panel1.Left += 50;
                PanelAnimator.ShowSync(Panel_Left);
            }
            else
            {
                Panel_Left.Width = 240;
                lbl_LogoLine.Visible = true;
                Panel_Left.Visible = false;
                panel1.Left -= 50;
                PanelAnimator.ShowSync(Panel_Left);
            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Lbl_Tarih.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Lbl_Saat.Text = DateTime.Now.ToString("HH: mm: ss");
        }
        public void btnCizgi(BunifuFlatButton btn)
        {
            lbl_btncizgi.Top = btn.Top;
            if (lbl_btncizgi.Visible == false)
                lbl_btncizgi.Visible = true;
        }

        private void btn_Urunler_Click(object sender, EventArgs e)
        {
            openchildform(new ProductsForm());
            btnCizgi(btn_Urunler);
        }

        private void btn_Stocks_Click(object sender, EventArgs e)
        {
            openchildform(new StocksForm());
            btnCizgi(btn_Stocks);

        }

        ProductsUserForm productsUser = new ProductsUserForm();

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            openchildform(productsUser);
            btnCizgi(btn_Personel);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void Btn_Sales_Click(object sender, EventArgs e)
        {
            btnCizgi(Btn_Sales);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            btnCizgi(btn_Settings);
        }
    }
}
