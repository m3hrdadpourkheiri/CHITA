namespace CHITA
{
    partial class frmdbsetting
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
            this.gpbexpress = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtexpress = new System.Windows.Forms.TextBox();
            this.gpbserver = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtdatabasename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblconnectionstring = new System.Windows.Forms.Label();
            this.radioexpress = new System.Windows.Forms.RadioButton();
            this.radioserver = new System.Windows.Forms.RadioButton();
            this.gpbexpress.SuspendLayout();
            this.gpbserver.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbexpress
            // 
            this.gpbexpress.Controls.Add(this.button1);
            this.gpbexpress.Controls.Add(this.txtexpress);
            this.gpbexpress.Location = new System.Drawing.Point(9, 35);
            this.gpbexpress.Name = "gpbexpress";
            this.gpbexpress.Size = new System.Drawing.Size(290, 93);
            this.gpbexpress.TabIndex = 0;
            this.gpbexpress.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Borows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtexpress
            // 
            this.txtexpress.Location = new System.Drawing.Point(6, 38);
            this.txtexpress.Name = "txtexpress";
            this.txtexpress.Size = new System.Drawing.Size(259, 20);
            this.txtexpress.TabIndex = 0;
            // 
            // gpbserver
            // 
            this.gpbserver.Controls.Add(this.checkBox1);
            this.gpbserver.Controls.Add(this.label4);
            this.gpbserver.Controls.Add(this.label3);
            this.gpbserver.Controls.Add(this.label5);
            this.gpbserver.Controls.Add(this.label2);
            this.gpbserver.Controls.Add(this.txtpassword);
            this.gpbserver.Controls.Add(this.txtdatabasename);
            this.gpbserver.Controls.Add(this.txtusername);
            this.gpbserver.Controls.Add(this.txtservername);
            this.gpbserver.Enabled = false;
            this.gpbserver.Location = new System.Drawing.Point(9, 157);
            this.gpbserver.Name = "gpbserver";
            this.gpbserver.Size = new System.Drawing.Size(289, 146);
            this.gpbserver.TabIndex = 0;
            this.gpbserver.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Windows Authentication";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(63, 95);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(203, 20);
            this.txtpassword.TabIndex = 0;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(63, 69);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(203, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(63, 19);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(203, 20);
            this.txtservername.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Test Connection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtdatabasename
            // 
            this.txtdatabasename.Location = new System.Drawing.Point(63, 45);
            this.txtdatabasename.Name = "txtdatabasename";
            this.txtdatabasename.Size = new System.Drawing.Size(203, 20);
            this.txtdatabasename.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Database ";
            // 
            // lblconnectionstring
            // 
            this.lblconnectionstring.Location = new System.Drawing.Point(6, 306);
            this.lblconnectionstring.Name = "lblconnectionstring";
            this.lblconnectionstring.Size = new System.Drawing.Size(290, 69);
            this.lblconnectionstring.TabIndex = 1;
            this.lblconnectionstring.Click += new System.EventHandler(this.lblconnectionstring_Click);
            // 
            // radioexpress
            // 
            this.radioexpress.AutoSize = true;
            this.radioexpress.Checked = true;
            this.radioexpress.Location = new System.Drawing.Point(9, 12);
            this.radioexpress.Name = "radioexpress";
            this.radioexpress.Size = new System.Drawing.Size(132, 17);
            this.radioexpress.TabIndex = 2;
            this.radioexpress.TabStop = true;
            this.radioexpress.Text = "Microsoft SQL Express";
            this.radioexpress.UseVisualStyleBackColor = true;
            this.radioexpress.CheckedChanged += new System.EventHandler(this.radioexpress_CheckedChanged);
            this.radioexpress.Click += new System.EventHandler(this.radioexpress_Click);
            // 
            // radioserver
            // 
            this.radioserver.AutoSize = true;
            this.radioserver.Location = new System.Drawing.Point(9, 134);
            this.radioserver.Name = "radioserver";
            this.radioserver.Size = new System.Drawing.Size(167, 17);
            this.radioserver.TabIndex = 2;
            this.radioserver.Text = "Microsoft SQL Server Settings";
            this.radioserver.UseVisualStyleBackColor = true;
            this.radioserver.Click += new System.EventHandler(this.radioserver_Click);
            // 
            // frmdbsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 421);
            this.Controls.Add(this.radioexpress);
            this.Controls.Add(this.radioserver);
            this.Controls.Add(this.lblconnectionstring);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gpbserver);
            this.Controls.Add(this.gpbexpress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdbsetting";
            this.Text = "Database Settings";
            this.Load += new System.EventHandler(this.frmdbsetting_Load);
            this.gpbexpress.ResumeLayout(false);
            this.gpbexpress.PerformLayout();
            this.gpbserver.ResumeLayout(false);
            this.gpbserver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbexpress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtexpress;
        private System.Windows.Forms.GroupBox gpbserver;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdatabasename;
        private System.Windows.Forms.Label lblconnectionstring;
        private System.Windows.Forms.RadioButton radioexpress;
        private System.Windows.Forms.RadioButton radioserver;
    }
}