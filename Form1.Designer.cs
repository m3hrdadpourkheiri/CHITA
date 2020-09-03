namespace CHITA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("حضور و غیاب", 13, 13);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("تشکیل پرونده ورزش کار", 1, 17);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("تشکیل پرونده مربی", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("پرونده", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("دریافت شهریه", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("دریافت کرایه", 5, 5);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("پرداخت هزینه ها", 6, 6);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("امور مالی", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("پروفایل باشگاه", 15, 15);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("لیست هزینه ها", 5, 5);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("لیست حسابها", 21, 21);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("حساب ها", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("هزینه ها");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("اطلاعات پایه سیستم", 12, 12, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("کاربر جدید", 7, 7);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ویرایش کاربر", 8, 8);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("کاربران", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("اعضا", 17, 1);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("مانده حساب ها", 10, 10);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ورود و خروج ها", 16, 16);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("دریافت ها");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("پرداخت ها");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("هزینه ها");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("خدمات");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("سود و ریان ها");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("بدهکاری");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("بستانکاری");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("مالی", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("چاپ کارت عضویت", 13, 13);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("گزارشات", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("تهیه فایل پشتیبان", 19, 19);
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("بازگردانی فایل پشتیبان", 20, 20);
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("پشتیبانی", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_member = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.کارتعضویتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.چاپپروندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 62);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CHITA.Properties.Resources.headset_male_man_support_user_young_icon_1320196267025138334;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 514);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(964, 514);
            this.splitContainer1.SplitterDistance = 752;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_member);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.ImageIndex = 17;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "لیست اعضا";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_member
            // 
            this.dataGridView_member.AllowUserToAddRows = false;
            this.dataGridView_member.AllowUserToDeleteRows = false;
            this.dataGridView_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.name,
            this.family,
            this.gender,
            this.coachname});
            this.dataGridView_member.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_member.Location = new System.Drawing.Point(3, 103);
            this.dataGridView_member.Name = "dataGridView_member";
            this.dataGridView_member.ReadOnly = true;
            this.dataGridView_member.Size = new System.Drawing.Size(738, 370);
            this.dataGridView_member.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "کد عضویت";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.Name = "family";
            this.family.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "جنسیت";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // coachname
            // 
            this.coachname.DataPropertyName = "coachname";
            this.coachname.HeaderText = "نام مربی";
            this.coachname.Name = "coachname";
            this.coachname.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کارتعضویتToolStripMenuItem,
            this.چاپپروندهToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // کارتعضویتToolStripMenuItem
            // 
            this.کارتعضویتToolStripMenuItem.Name = "کارتعضویتToolStripMenuItem";
            this.کارتعضویتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.کارتعضویتToolStripMenuItem.Text = "کارت عضویت";
            this.کارتعضویتToolStripMenuItem.Click += new System.EventHandler(this.کارتعضویتToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 100);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CHITA.Properties.Resources.Valid;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(18, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.ImageIndex = 9;
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "لیست مربیان";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(738, 370);
            this.dataGridView2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(738, 100);
            this.panel4.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 12;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "اطلاعات پایه سیستم";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-131964753094019398.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "coach.png");
            this.imageList1.Images.SetKeyName(3, "02_1-512.png");
            this.imageList1.Images.SetKeyName(4, "Custom-Icon-Design-Pretty-Office-11-Cash.ico");
            this.imageList1.Images.SetKeyName(5, "d33a97e5.png");
            this.imageList1.Images.SetKeyName(6, "money-icon.png");
            this.imageList1.Images.SetKeyName(7, "Custom-Icon-Design-Flatastic-1-Add-1.ico");
            this.imageList1.Images.SetKeyName(8, "UniversalEditButton3.png");
            this.imageList1.Images.SetKeyName(9, "user-icon-512.png");
            this.imageList1.Images.SetKeyName(10, "Dollar-USD-icon.png");
            this.imageList1.Images.SetKeyName(11, "accounts-512.png");
            this.imageList1.Images.SetKeyName(12, "Artboard_11-512.png");
            this.imageList1.Images.SetKeyName(13, "people_users_account_user_profiles_person_details_access_cards_profile_database-5" +
        "12.png");
            this.imageList1.Images.SetKeyName(14, "personal-health-record-icon.png");
            this.imageList1.Images.SetKeyName(15, "Credit_Card-512.png");
            this.imageList1.Images.SetKeyName(16, "sports-news-sports-betting-transfer-window-transfers-png-200_200.png");
            this.imageList1.Images.SetKeyName(17, "user.png");
            this.imageList1.Images.SetKeyName(18, "red_left_arrow_103.jpg");
            this.imageList1.Images.SetKeyName(19, "Alpha Dista Icon 050090.png");
            this.imageList1.Images.SetKeyName(20, "Alpha Dista Icon 050101.png");
            this.imageList1.Images.SetKeyName(21, "safebox.png");
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 13;
            treeNode1.Name = "presence";
            treeNode1.SelectedImageIndex = 13;
            treeNode1.Text = "حضور و غیاب";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "newdocument";
            treeNode2.SelectedImageIndex = 17;
            treeNode2.Text = "تشکیل پرونده ورزش کار";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "newcoach";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "تشکیل پرونده مربی";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "پرونده";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "shahrieh";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "دریافت شهریه";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "Node11";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "دریافت کرایه";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "costpay";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Text = "پرداخت هزینه ها";
            treeNode8.ImageIndex = 10;
            treeNode8.Name = "Node2";
            treeNode8.SelectedImageIndex = 10;
            treeNode8.Text = "امور مالی";
            treeNode9.ImageIndex = 15;
            treeNode9.Name = "profile";
            treeNode9.SelectedImageIndex = 15;
            treeNode9.Text = "پروفایل باشگاه";
            treeNode10.ImageIndex = 5;
            treeNode10.Name = "costs";
            treeNode10.SelectedImageIndex = 5;
            treeNode10.Text = "لیست هزینه ها";
            treeNode11.ImageIndex = 21;
            treeNode11.Name = "hesabha";
            treeNode11.SelectedImageIndex = 21;
            treeNode11.Text = "لیست حسابها";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "Node15";
            treeNode12.SelectedImageIndex = 0;
            treeNode12.Text = "حساب ها";
            treeNode13.Name = "Node16";
            treeNode13.Text = "هزینه ها";
            treeNode14.ImageIndex = 12;
            treeNode14.Name = "Node3";
            treeNode14.SelectedImageIndex = 12;
            treeNode14.Text = "اطلاعات پایه سیستم";
            treeNode15.ImageIndex = 7;
            treeNode15.Name = "newuser";
            treeNode15.SelectedImageIndex = 7;
            treeNode15.Text = "کاربر جدید";
            treeNode16.ImageIndex = 8;
            treeNode16.Name = "users";
            treeNode16.SelectedImageIndex = 8;
            treeNode16.Text = "ویرایش کاربر";
            treeNode17.ImageIndex = 9;
            treeNode17.Name = "Node4";
            treeNode17.SelectedImageIndex = 9;
            treeNode17.Text = "کاربران";
            treeNode18.ImageIndex = 17;
            treeNode18.Name = "Node22";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "اعضا";
            treeNode19.ImageIndex = 10;
            treeNode19.Name = "Node23";
            treeNode19.SelectedImageIndex = 10;
            treeNode19.Text = "مانده حساب ها";
            treeNode20.ImageIndex = 16;
            treeNode20.Name = "Node24";
            treeNode20.SelectedImageIndex = 16;
            treeNode20.Text = "ورود و خروج ها";
            treeNode21.Name = "Node26";
            treeNode21.Text = "دریافت ها";
            treeNode22.Name = "Node27";
            treeNode22.Text = "پرداخت ها";
            treeNode23.Name = "Node28";
            treeNode23.Text = "هزینه ها";
            treeNode24.Name = "Node29";
            treeNode24.Text = "خدمات";
            treeNode25.Name = "Node30";
            treeNode25.Text = "سود و ریان ها";
            treeNode26.Name = "Node31";
            treeNode26.Text = "بدهکاری";
            treeNode27.Name = "Node32";
            treeNode27.Text = "بستانکاری";
            treeNode28.Name = "Node25";
            treeNode28.Text = "مالی";
            treeNode29.ImageIndex = 13;
            treeNode29.Name = "card";
            treeNode29.SelectedImageIndex = 13;
            treeNode29.Text = "چاپ کارت عضویت";
            treeNode30.Name = "Node5";
            treeNode30.Text = "گزارشات";
            treeNode31.ImageIndex = 19;
            treeNode31.Name = "Node1";
            treeNode31.SelectedImageIndex = 19;
            treeNode31.Text = "تهیه فایل پشتیبان";
            treeNode32.ImageIndex = 20;
            treeNode32.Name = "Node2";
            treeNode32.SelectedImageIndex = 20;
            treeNode32.Text = "بازگردانی فایل پشتیبان";
            treeNode33.Name = "Node0";
            treeNode33.Text = "پشتیبانی";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode14,
            treeNode17,
            treeNode30,
            treeNode33});
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.SelectedImageIndex = 18;
            this.treeView1.Size = new System.Drawing.Size(208, 514);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // چاپپروندهToolStripMenuItem
            // 
            this.چاپپروندهToolStripMenuItem.Name = "چاپپروندهToolStripMenuItem";
            this.چاپپروندهToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.چاپپروندهToolStripMenuItem.Text = "چاپ پرونده";
            this.چاپپروندهToolStripMenuItem.Click += new System.EventHandler(this.چاپپروندهToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_member)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView_member;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem کارتعضویتToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachname;
        private System.Windows.Forms.ToolStripMenuItem چاپپروندهToolStripMenuItem;
    }
}

