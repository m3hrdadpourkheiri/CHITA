namespace CHITA
{
    partial class frmcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbcards = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblcodetitle = new System.Windows.Forms.Label();
            this.lblnametitle = new System.Windows.Forms.Label();
            this.lblfamily = new System.Windows.Forms.Label();
            this.lblfamilytitle = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgymname = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.chbgymname = new System.Windows.Forms.CheckBox();
            this.chbpic = new System.Windows.Forms.CheckBox();
            this.chblogo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbcards);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 74);
            this.panel1.TabIndex = 0;
            // 
            // cmbcards
            // 
            this.cmbcards.FormattingEnabled = true;
            this.cmbcards.Location = new System.Drawing.Point(435, 29);
            this.cmbcards.Name = "cmbcards";
            this.cmbcards.Size = new System.Drawing.Size(121, 21);
            this.cmbcards.TabIndex = 1;
            this.cmbcards.SelectedIndexChanged += new System.EventHandler(this.cmbcards_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "تغییر تصویر زمینه";
            this.label11.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblcodetitle);
            this.panel2.Controls.Add(this.lblnametitle);
            this.panel2.Controls.Add(this.lblfamily);
            this.panel2.Controls.Add(this.lblfamilytitle);
            this.panel2.Controls.Add(this.lblcode);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.lblgymname);
            this.panel2.Controls.Add(this.picture);
            this.panel2.Controls.Add(this.piclogo);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 316);
            this.panel2.TabIndex = 1;
            // 
            // lblcodetitle
            // 
            this.lblcodetitle.AutoSize = true;
            this.lblcodetitle.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblcodetitle.Location = new System.Drawing.Point(388, 132);
            this.lblcodetitle.Name = "lblcodetitle";
            this.lblcodetitle.Size = new System.Drawing.Size(110, 24);
            this.lblcodetitle.TabIndex = 1;
            this.lblcodetitle.Text = "شماره عضویت";
            this.lblcodetitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.lblcodetitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // lblnametitle
            // 
            this.lblnametitle.AutoSize = true;
            this.lblnametitle.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblnametitle.Location = new System.Drawing.Point(388, 171);
            this.lblnametitle.Name = "lblnametitle";
            this.lblnametitle.Size = new System.Drawing.Size(33, 24);
            this.lblnametitle.TabIndex = 1;
            this.lblnametitle.Text = "نام";
            this.lblnametitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.lblnametitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblfamily
            // 
            this.lblfamily.AutoSize = true;
            this.lblfamily.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold);
            this.lblfamily.Location = new System.Drawing.Point(260, 206);
            this.lblfamily.Name = "lblfamily";
            this.lblfamily.Size = new System.Drawing.Size(66, 24);
            this.lblfamily.TabIndex = 1;
            this.lblfamily.Text = "پورخیری";
            this.lblfamily.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblfamily_MouseDown);
            this.lblfamily.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblfamily_MouseMove);
            // 
            // lblfamilytitle
            // 
            this.lblfamilytitle.AutoSize = true;
            this.lblfamilytitle.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblfamilytitle.Location = new System.Drawing.Point(388, 206);
            this.lblfamilytitle.Name = "lblfamilytitle";
            this.lblfamilytitle.Size = new System.Drawing.Size(103, 24);
            this.lblfamilytitle.TabIndex = 1;
            this.lblfamilytitle.Text = "نام خانوادگی";
            this.lblfamilytitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lblfamilytitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold);
            this.lblcode.Location = new System.Drawing.Point(260, 132);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(71, 24);
            this.lblcode.TabIndex = 1;
            this.lblcode.Text = "10000257";
            this.lblcode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblcode_MouseDown);
            this.lblcode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblcode_MouseMove);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(260, 171);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(63, 24);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "مهرداد";
            this.lblname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblname_MouseDown);
            this.lblname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblname_MouseMove);
            // 
            // lblgymname
            // 
            this.lblgymname.AutoSize = true;
            this.lblgymname.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold);
            this.lblgymname.Location = new System.Drawing.Point(161, 16);
            this.lblgymname.Name = "lblgymname";
            this.lblgymname.Size = new System.Drawing.Size(226, 24);
            this.lblgymname.TabIndex = 1;
            this.lblgymname.Text = "باشگاه فرهنگی ورزشی مسعود";
            this.lblgymname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblgymname_MouseDown);
            this.lblgymname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblgymname_MouseMove);
            // 
            // picture
            // 
            this.picture.Image = global::CHITA.Properties.Resources.Users___Download_From_WarezTeam_WS_;
            this.picture.Location = new System.Drawing.Point(12, 57);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(131, 167);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // piclogo
            // 
            this.piclogo.Image = global::CHITA.Properties.Resources.Valid;
            this.piclogo.Location = new System.Drawing.Point(415, 7);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(100, 100);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            this.piclogo.Click += new System.EventHandler(this.pictureBox1_Click);
            this.piclogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.piclogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.chbgymname);
            this.panel3.Controls.Add(this.chbpic);
            this.panel3.Controls.Add(this.chblogo);
            this.panel3.Location = new System.Drawing.Point(521, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 316);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Font";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "ذخیره کارت";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "مرتب سازی";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "رنگ فونت";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "رنگ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chbgymname
            // 
            this.chbgymname.AutoSize = true;
            this.chbgymname.Checked = true;
            this.chbgymname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbgymname.Location = new System.Drawing.Point(106, 69);
            this.chbgymname.Name = "chbgymname";
            this.chbgymname.Size = new System.Drawing.Size(73, 17);
            this.chbgymname.TabIndex = 0;
            this.chbgymname.Text = "نام باشگاه";
            this.chbgymname.UseVisualStyleBackColor = true;
            this.chbgymname.CheckedChanged += new System.EventHandler(this.Chbgymname_CheckedChanged);
            // 
            // chbpic
            // 
            this.chbpic.AutoSize = true;
            this.chbpic.Checked = true;
            this.chbpic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbpic.Location = new System.Drawing.Point(85, 46);
            this.chbpic.Name = "chbpic";
            this.chbpic.Size = new System.Drawing.Size(94, 17);
            this.chbpic.TabIndex = 0;
            this.chbpic.Text = "عکس پرسنلی";
            this.chbpic.UseVisualStyleBackColor = true;
            this.chbpic.CheckedChanged += new System.EventHandler(this.Chbpic_CheckedChanged);
            // 
            // chblogo
            // 
            this.chblogo.AutoSize = true;
            this.chblogo.Checked = true;
            this.chblogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chblogo.Location = new System.Drawing.Point(101, 23);
            this.chblogo.Name = "chblogo";
            this.chblogo.Size = new System.Drawing.Size(78, 17);
            this.chblogo.TabIndex = 0;
            this.chblogo.Text = "لوگو باشگاه";
            this.chblogo.UseVisualStyleBackColor = true;
            this.chblogo.CheckedChanged += new System.EventHandler(this.Chblogo_CheckedChanged);
            // 
            // frmcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 389);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmcard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کارت عضویت باشگاه";
            this.Load += new System.EventHandler(this.frmcard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbcards;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chbgymname;
        private System.Windows.Forms.CheckBox chbpic;
        private System.Windows.Forms.CheckBox chblogo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label lblcodetitle;
        private System.Windows.Forms.Label lblnametitle;
        private System.Windows.Forms.Label lblfamily;
        private System.Windows.Forms.Label lblfamilytitle;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgymname;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}