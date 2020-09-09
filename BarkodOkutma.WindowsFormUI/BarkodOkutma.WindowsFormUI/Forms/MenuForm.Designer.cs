namespace BarkodOkutma.WindowsFormUI
{
    partial class MenuForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Panel_Fill = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Saat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Tarih = new System.Windows.Forms.Label();
            this.Panel_Top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_MenuAnimator = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_Left = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Btn_Sales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_LogoLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_BackLogin = new System.Windows.Forms.PictureBox();
            this.lbl_btncizgi = new System.Windows.Forms.Label();
            this.btn_Urunler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Stocks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Personel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_Fill.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MenuAnimator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.Panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BackLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.Panel_Top;
            this.DragControl.Vertical = true;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Panel_Fill
            // 
            this.Panel_Fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Fill.BackgroundImage")));
            this.Panel_Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Fill.Controls.Add(this.panel1);
            this.PanelAnimator.SetDecoration(this.Panel_Fill, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Fill.GradientBottomLeft = System.Drawing.Color.White;
            this.Panel_Fill.GradientBottomRight = System.Drawing.Color.White;
            this.Panel_Fill.GradientTopLeft = System.Drawing.Color.White;
            this.Panel_Fill.GradientTopRight = System.Drawing.Color.White;
            this.Panel_Fill.Location = new System.Drawing.Point(240, 45);
            this.Panel_Fill.Name = "Panel_Fill";
            this.Panel_Fill.Quality = 10;
            this.Panel_Fill.Size = new System.Drawing.Size(1146, 743);
            this.Panel_Fill.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lbl_Saat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Lbl_Tarih);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(198, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 392);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::BarkodOkutma.WindowsFormUI.Properties.Resources.icons8_barcode_64;
            this.pictureBox2.Location = new System.Drawing.Point(206, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.PanelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(107, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(600, 1);
            this.label5.TabIndex = 28;
            // 
            // Lbl_Saat
            // 
            this.Lbl_Saat.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.Lbl_Saat, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_Saat.Font = new System.Drawing.Font("Open Sans", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Saat.ForeColor = System.Drawing.Color.DarkGray;
            this.Lbl_Saat.Location = new System.Drawing.Point(3, 193);
            this.Lbl_Saat.Name = "Lbl_Saat";
            this.Lbl_Saat.Size = new System.Drawing.Size(799, 82);
            this.Lbl_Saat.TabIndex = 24;
            this.Lbl_Saat.Text = "20: 47:28";
            this.Lbl_Saat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(276, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 54);
            this.label6.TabIndex = 27;
            this.label6.Text = "ENTEBE MARKET";
            // 
            // Lbl_Tarih
            // 
            this.Lbl_Tarih.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.Lbl_Tarih, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_Tarih.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_Tarih.Location = new System.Drawing.Point(3, 285);
            this.Lbl_Tarih.Name = "Lbl_Tarih";
            this.Lbl_Tarih.Size = new System.Drawing.Size(799, 37);
            this.Lbl_Tarih.TabIndex = 25;
            this.Lbl_Tarih.Text = "Cumartesi, 05 Eylül 2020";
            this.Lbl_Tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Top.BackgroundImage")));
            this.Panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Top.Controls.Add(this.btn_MenuAnimator);
            this.Panel_Top.Controls.Add(this.btn_Minimize);
            this.Panel_Top.Controls.Add(this.btn_Close);
            this.PanelAnimator.SetDecoration(this.Panel_Top, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.Panel_Top.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.Panel_Top.GradientTopLeft = System.Drawing.Color.WhiteSmoke;
            this.Panel_Top.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.Panel_Top.Location = new System.Drawing.Point(240, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Quality = 10;
            this.Panel_Top.Size = new System.Drawing.Size(1146, 45);
            this.Panel_Top.TabIndex = 0;
            // 
            // btn_MenuAnimator
            // 
            this.btn_MenuAnimator.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.btn_MenuAnimator, BunifuAnimatorNS.DecorationType.None);
            this.btn_MenuAnimator.Image = global::BarkodOkutma.WindowsFormUI.Properties.Resources.Menu_Flutent_32;
            this.btn_MenuAnimator.Location = new System.Drawing.Point(6, 6);
            this.btn_MenuAnimator.Name = "btn_MenuAnimator";
            this.btn_MenuAnimator.Size = new System.Drawing.Size(32, 32);
            this.btn_MenuAnimator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_MenuAnimator.TabIndex = 21;
            this.btn_MenuAnimator.TabStop = false;
            this.btn_MenuAnimator.Click += new System.EventHandler(this.btn_MenuAnimator_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.btn_Minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_Minimize.Image = global::BarkodOkutma.WindowsFormUI.Properties.Resources.Dot_Minus_32;
            this.btn_Minimize.ImageActive = null;
            this.btn_Minimize.Location = new System.Drawing.Point(1069, 6);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Minimize.TabIndex = 12;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Zoom = 5;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Image = global::BarkodOkutma.WindowsFormUI.Properties.Resources.Dot_Delete_32;
            this.btn_Close.ImageActive = null;
            this.btn_Close.Location = new System.Drawing.Point(1107, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 32);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Close.TabIndex = 13;
            this.btn_Close.TabStop = false;
            this.btn_Close.Zoom = 5;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.White;
            this.Panel_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Left.BackgroundImage")));
            this.Panel_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Left.Controls.Add(this.Btn_Sales);
            this.Panel_Left.Controls.Add(this.lbl_LogoLine);
            this.Panel_Left.Controls.Add(this.label1);
            this.Panel_Left.Controls.Add(this.pictureBox1);
            this.Panel_Left.Controls.Add(this.btn_BackLogin);
            this.Panel_Left.Controls.Add(this.lbl_btncizgi);
            this.Panel_Left.Controls.Add(this.btn_Urunler);
            this.Panel_Left.Controls.Add(this.btn_Stocks);
            this.Panel_Left.Controls.Add(this.btn_Settings);
            this.Panel_Left.Controls.Add(this.btn_Personel);
            this.PanelAnimator.SetDecoration(this.Panel_Left, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Panel_Left.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Panel_Left.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Panel_Left.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Quality = 10;
            this.Panel_Left.Size = new System.Drawing.Size(240, 788);
            this.Panel_Left.TabIndex = 1;
            // 
            // Btn_Sales
            // 
            this.Btn_Sales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Btn_Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Btn_Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Sales.BorderRadius = 0;
            this.Btn_Sales.ButtonText = "Satışlar";
            this.Btn_Sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.Btn_Sales, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Sales.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Sales.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Sales.Iconimage = global::BarkodOkutma.WindowsFormUI.Properties.Resources.Salesn_32;
            this.Btn_Sales.Iconimage_right = null;
            this.Btn_Sales.Iconimage_right_Selected = null;
            this.Btn_Sales.Iconimage_Selected = null;
            this.Btn_Sales.IconMarginLeft = 0;
            this.Btn_Sales.IconMarginRight = 0;
            this.Btn_Sales.IconRightVisible = true;
            this.Btn_Sales.IconRightZoom = 0D;
            this.Btn_Sales.IconVisible = true;
            this.Btn_Sales.IconZoom = 50D;
            this.Btn_Sales.IsTab = false;
            this.Btn_Sales.Location = new System.Drawing.Point(8, 369);
            this.Btn_Sales.Name = "Btn_Sales";
            this.Btn_Sales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Btn_Sales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.Btn_Sales.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Sales.selected = false;
            this.Btn_Sales.Size = new System.Drawing.Size(231, 48);
            this.Btn_Sales.TabIndex = 23;
            this.Btn_Sales.Text = "Satışlar";
            this.Btn_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Sales.Textcolor = System.Drawing.Color.White;
            this.Btn_Sales.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sales.Click += new System.EventHandler(this.Btn_Sales_Click);
            // 
            // lbl_LogoLine
            // 
            this.lbl_LogoLine.BackColor = System.Drawing.Color.LightGray;
            this.PanelAnimator.SetDecoration(this.lbl_LogoLine, BunifuAnimatorNS.DecorationType.None);
            this.lbl_LogoLine.Location = new System.Drawing.Point(22, 68);
            this.lbl_LogoLine.Name = "lbl_LogoLine";
            this.lbl_LogoLine.Size = new System.Drawing.Size(200, 1);
            this.lbl_LogoLine.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "ENTEBE MARKET";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::BarkodOkutma.WindowsFormUI.Properties.Resources.icons8_barcode_32;
            this.pictureBox1.Location = new System.Drawing.Point(18, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_BackLogin
            // 
            this.btn_BackLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.btn_BackLogin, BunifuAnimatorNS.DecorationType.None);
            this.btn_BackLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_BackLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackLogin.Image")));
            this.btn_BackLogin.Location = new System.Drawing.Point(0, 737);
            this.btn_BackLogin.Name = "btn_BackLogin";
            this.btn_BackLogin.Size = new System.Drawing.Size(240, 51);
            this.btn_BackLogin.TabIndex = 19;
            this.btn_BackLogin.TabStop = false;
            // 
            // lbl_btncizgi
            // 
            this.lbl_btncizgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(158)))), ((int)(((byte)(227)))));
            this.PanelAnimator.SetDecoration(this.lbl_btncizgi, BunifuAnimatorNS.DecorationType.None);
            this.lbl_btncizgi.Font = new System.Drawing.Font("Open Sans", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_btncizgi.ForeColor = System.Drawing.Color.White;
            this.lbl_btncizgi.Location = new System.Drawing.Point(4, 222);
            this.lbl_btncizgi.Name = "lbl_btncizgi";
            this.lbl_btncizgi.Size = new System.Drawing.Size(2, 48);
            this.lbl_btncizgi.TabIndex = 18;
            this.lbl_btncizgi.Visible = false;
            // 
            // btn_Urunler
            // 
            this.btn_Urunler.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Urunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Urunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Urunler.BorderRadius = 0;
            this.btn_Urunler.ButtonText = "Ürünler";
            this.btn_Urunler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Urunler, BunifuAnimatorNS.DecorationType.None);
            this.btn_Urunler.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Urunler.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Urunler.Iconimage = global::BarkodOkutma.WindowsFormUI.Properties.Resources.Urunlern_32;
            this.btn_Urunler.Iconimage_right = null;
            this.btn_Urunler.Iconimage_right_Selected = null;
            this.btn_Urunler.Iconimage_Selected = null;
            this.btn_Urunler.IconMarginLeft = 0;
            this.btn_Urunler.IconMarginRight = 0;
            this.btn_Urunler.IconRightVisible = true;
            this.btn_Urunler.IconRightZoom = 0D;
            this.btn_Urunler.IconVisible = true;
            this.btn_Urunler.IconZoom = 50D;
            this.btn_Urunler.IsTab = false;
            this.btn_Urunler.Location = new System.Drawing.Point(8, 216);
            this.btn_Urunler.Name = "btn_Urunler";
            this.btn_Urunler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Urunler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Urunler.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Urunler.selected = false;
            this.btn_Urunler.Size = new System.Drawing.Size(231, 48);
            this.btn_Urunler.TabIndex = 14;
            this.btn_Urunler.Text = "Ürünler";
            this.btn_Urunler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Urunler.Textcolor = System.Drawing.Color.White;
            this.btn_Urunler.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Urunler.Click += new System.EventHandler(this.btn_Urunler_Click);
            // 
            // btn_Stocks
            // 
            this.btn_Stocks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Stocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Stocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stocks.BorderRadius = 0;
            this.btn_Stocks.ButtonText = "Stoklar";
            this.btn_Stocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Stocks, BunifuAnimatorNS.DecorationType.None);
            this.btn_Stocks.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Stocks.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Stocks.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Stocks.Iconimage")));
            this.btn_Stocks.Iconimage_right = null;
            this.btn_Stocks.Iconimage_right_Selected = null;
            this.btn_Stocks.Iconimage_Selected = null;
            this.btn_Stocks.IconMarginLeft = 0;
            this.btn_Stocks.IconMarginRight = 0;
            this.btn_Stocks.IconRightVisible = true;
            this.btn_Stocks.IconRightZoom = 0D;
            this.btn_Stocks.IconVisible = true;
            this.btn_Stocks.IconZoom = 50D;
            this.btn_Stocks.IsTab = false;
            this.btn_Stocks.Location = new System.Drawing.Point(8, 267);
            this.btn_Stocks.Name = "btn_Stocks";
            this.btn_Stocks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Stocks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Stocks.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Stocks.selected = false;
            this.btn_Stocks.Size = new System.Drawing.Size(231, 48);
            this.btn_Stocks.TabIndex = 16;
            this.btn_Stocks.Text = "Stoklar";
            this.btn_Stocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Stocks.Textcolor = System.Drawing.Color.White;
            this.btn_Stocks.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Stocks.Click += new System.EventHandler(this.btn_Stocks_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Settings.BorderRadius = 0;
            this.btn_Settings.ButtonText = "Ayarlar";
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Settings, BunifuAnimatorNS.DecorationType.None);
            this.btn_Settings.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Iconimage")));
            this.btn_Settings.Iconimage_right = null;
            this.btn_Settings.Iconimage_right_Selected = null;
            this.btn_Settings.Iconimage_Selected = null;
            this.btn_Settings.IconMarginLeft = 0;
            this.btn_Settings.IconMarginRight = 0;
            this.btn_Settings.IconRightVisible = true;
            this.btn_Settings.IconRightZoom = 0D;
            this.btn_Settings.IconVisible = true;
            this.btn_Settings.IconZoom = 50D;
            this.btn_Settings.IsTab = false;
            this.btn_Settings.Location = new System.Drawing.Point(8, 420);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Settings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Settings.selected = false;
            this.btn_Settings.Size = new System.Drawing.Size(231, 48);
            this.btn_Settings.TabIndex = 17;
            this.btn_Settings.Text = "Ayarlar";
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Settings.Textcolor = System.Drawing.Color.White;
            this.btn_Settings.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Personel
            // 
            this.btn_Personel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Personel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Personel.BorderRadius = 0;
            this.btn_Personel.ButtonText = "Personeller";
            this.btn_Personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Personel, BunifuAnimatorNS.DecorationType.None);
            this.btn_Personel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Personel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Personel.Iconimage = global::BarkodOkutma.WindowsFormUI.Properties.Resources.icons8_customer_insight_32;
            this.btn_Personel.Iconimage_right = null;
            this.btn_Personel.Iconimage_right_Selected = null;
            this.btn_Personel.Iconimage_Selected = null;
            this.btn_Personel.IconMarginLeft = 0;
            this.btn_Personel.IconMarginRight = 0;
            this.btn_Personel.IconRightVisible = true;
            this.btn_Personel.IconRightZoom = 0D;
            this.btn_Personel.IconVisible = true;
            this.btn_Personel.IconZoom = 50D;
            this.btn_Personel.IsTab = false;
            this.btn_Personel.Location = new System.Drawing.Point(8, 318);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Personel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(40)))));
            this.btn_Personel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Personel.selected = false;
            this.btn_Personel.Size = new System.Drawing.Size(231, 48);
            this.btn_Personel.TabIndex = 15;
            this.btn_Personel.Text = "Personeller";
            this.btn_Personel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Personel.Textcolor = System.Drawing.Color.White;
            this.btn_Personel.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Panel_Fill);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.Panel_Left);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.Panel_Fill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MenuAnimator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.Panel_Left.ResumeLayout(false);
            this.Panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BackLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Left;
        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Top;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Fill;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minimize;
        private Bunifu.Framework.UI.BunifuImageButton btn_Close;
        private System.Windows.Forms.PictureBox btn_BackLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Urunler;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Stocks;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Settings;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Personel;
        private System.Windows.Forms.Label lbl_LogoLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Sales;
        private System.Windows.Forms.Label Lbl_Tarih;
        private System.Windows.Forms.Label Lbl_Saat;
        private System.Windows.Forms.PictureBox btn_MenuAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Time;
        public System.Windows.Forms.Label lbl_btncizgi;
    }
}

