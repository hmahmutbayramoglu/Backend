namespace BarkodOkutma.WindowsFormUI
{
    partial class ProductPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPanelForm));
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.picturbox_Productİmage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_OpenFile_İmage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_İmageLocation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_ProductUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ProductAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_Productİmage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 1;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(34, 151);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(218, 33);
            this.bunifuMaterialTextbox1.TabIndex = 0;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fiyat";
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 1;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(275, 151);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(218, 33);
            this.bunifuMaterialTextbox3.TabIndex = 8;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategori";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(34, 229);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 12;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(275, 229);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown2.TabIndex = 13;
            // 
            // picturbox_Productİmage
            // 
            this.picturbox_Productİmage.Location = new System.Drawing.Point(579, 67);
            this.picturbox_Productİmage.Name = "picturbox_Productİmage";
            this.picturbox_Productİmage.Size = new System.Drawing.Size(173, 153);
            this.picturbox_Productİmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturbox_Productİmage.TabIndex = 14;
            this.picturbox_Productİmage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_OpenFile_İmage
            // 
            this.btn_OpenFile_İmage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_OpenFile_İmage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_OpenFile_İmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OpenFile_İmage.BorderRadius = 0;
            this.btn_OpenFile_İmage.ButtonText = "Göz At";
            this.btn_OpenFile_İmage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenFile_İmage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_OpenFile_İmage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_OpenFile_İmage.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_OpenFile_İmage.Iconimage")));
            this.btn_OpenFile_İmage.Iconimage_right = null;
            this.btn_OpenFile_İmage.Iconimage_right_Selected = null;
            this.btn_OpenFile_İmage.Iconimage_Selected = null;
            this.btn_OpenFile_İmage.IconMarginLeft = 0;
            this.btn_OpenFile_İmage.IconMarginRight = 0;
            this.btn_OpenFile_İmage.IconRightVisible = true;
            this.btn_OpenFile_İmage.IconRightZoom = 0D;
            this.btn_OpenFile_İmage.IconVisible = true;
            this.btn_OpenFile_İmage.IconZoom = 90D;
            this.btn_OpenFile_İmage.IsTab = false;
            this.btn_OpenFile_İmage.Location = new System.Drawing.Point(608, 229);
            this.btn_OpenFile_İmage.Name = "btn_OpenFile_İmage";
            this.btn_OpenFile_İmage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_OpenFile_İmage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btn_OpenFile_İmage.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_OpenFile_İmage.selected = false;
            this.btn_OpenFile_İmage.Size = new System.Drawing.Size(111, 35);
            this.btn_OpenFile_İmage.TabIndex = 15;
            this.btn_OpenFile_İmage.Text = "Göz At";
            this.btn_OpenFile_İmage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OpenFile_İmage.Textcolor = System.Drawing.Color.White;
            this.btn_OpenFile_İmage.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile_İmage.Click += new System.EventHandler(this.btn_OpenFile_İmage_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "ÜRÜN KAYIT PANELİ";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(781, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(25, 25);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 63;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 10;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(-1, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1500, 1);
            this.label5.TabIndex = 64;
            // 
            // txt_İmageLocation
            // 
            this.txt_İmageLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_İmageLocation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_İmageLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_İmageLocation.HintForeColor = System.Drawing.Color.Empty;
            this.txt_İmageLocation.HintText = "";
            this.txt_İmageLocation.isPassword = false;
            this.txt_İmageLocation.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_İmageLocation.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_İmageLocation.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_İmageLocation.LineThickness = 1;
            this.txt_İmageLocation.Location = new System.Drawing.Point(558, 271);
            this.txt_İmageLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_İmageLocation.Name = "txt_İmageLocation";
            this.txt_İmageLocation.Size = new System.Drawing.Size(218, 33);
            this.txt_İmageLocation.TabIndex = 65;
            this.txt_İmageLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_ProductUpdate
            // 
            this.btn_ProductUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btn_ProductUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_ProductUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ProductUpdate.BorderRadius = 0;
            this.btn_ProductUpdate.ButtonText = "Güncelle";
            this.btn_ProductUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProductUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ProductUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ProductUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ProductUpdate.Iconimage")));
            this.btn_ProductUpdate.Iconimage_right = null;
            this.btn_ProductUpdate.Iconimage_right_Selected = null;
            this.btn_ProductUpdate.Iconimage_Selected = null;
            this.btn_ProductUpdate.IconMarginLeft = 0;
            this.btn_ProductUpdate.IconMarginRight = 0;
            this.btn_ProductUpdate.IconRightVisible = true;
            this.btn_ProductUpdate.IconRightZoom = 0D;
            this.btn_ProductUpdate.IconVisible = true;
            this.btn_ProductUpdate.IconZoom = 65D;
            this.btn_ProductUpdate.IsTab = false;
            this.btn_ProductUpdate.Location = new System.Drawing.Point(377, 411);
            this.btn_ProductUpdate.Name = "btn_ProductUpdate";
            this.btn_ProductUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_ProductUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btn_ProductUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ProductUpdate.selected = false;
            this.btn_ProductUpdate.Size = new System.Drawing.Size(159, 39);
            this.btn_ProductUpdate.TabIndex = 124;
            this.btn_ProductUpdate.Text = "Güncelle";
            this.btn_ProductUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ProductUpdate.Textcolor = System.Drawing.Color.White;
            this.btn_ProductUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_ProductAdd
            // 
            this.btn_ProductAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btn_ProductAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_ProductAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ProductAdd.BorderRadius = 0;
            this.btn_ProductAdd.ButtonText = "Ekle";
            this.btn_ProductAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProductAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ProductAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ProductAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ProductAdd.Iconimage")));
            this.btn_ProductAdd.Iconimage_right = null;
            this.btn_ProductAdd.Iconimage_right_Selected = null;
            this.btn_ProductAdd.Iconimage_Selected = null;
            this.btn_ProductAdd.IconMarginLeft = 0;
            this.btn_ProductAdd.IconMarginRight = 0;
            this.btn_ProductAdd.IconRightVisible = true;
            this.btn_ProductAdd.IconRightZoom = 0D;
            this.btn_ProductAdd.IconVisible = true;
            this.btn_ProductAdd.IconZoom = 65D;
            this.btn_ProductAdd.IsTab = false;
            this.btn_ProductAdd.Location = new System.Drawing.Point(225, 411);
            this.btn_ProductAdd.Name = "btn_ProductAdd";
            this.btn_ProductAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_ProductAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btn_ProductAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ProductAdd.selected = false;
            this.btn_ProductAdd.Size = new System.Drawing.Size(146, 39);
            this.btn_ProductAdd.TabIndex = 123;
            this.btn_ProductAdd.Text = "Ekle";
            this.btn_ProductAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ProductAdd.Textcolor = System.Drawing.Color.White;
            this.btn_ProductAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ProductPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 462);
            this.Controls.Add(this.btn_ProductUpdate);
            this.Controls.Add(this.btn_ProductAdd);
            this.Controls.Add(this.txt_İmageLocation);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_OpenFile_İmage);
            this.Controls.Add(this.picturbox_Productİmage);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_Productİmage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.PictureBox picturbox_Productİmage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_OpenFile_İmage;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_İmageLocation;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ProductUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ProductAdd;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}