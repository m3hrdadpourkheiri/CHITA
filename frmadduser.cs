using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;

namespace CHITA
{
    public partial class frmadduser : Form
    {
        public frmadduser()
        {
            InitializeComponent();
        }


        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmadduser_Load(object sender, EventArgs e)
        {
            PersianCalendar pc = new PersianCalendar();

            lbldate.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text!=txtconfirmpass.Text)
            {
                MessageBox.Show("عدم تطابق پسوردها");
                return;
            }

            string cmd = "insert into tblusers (name,family,username,password,signupdate,status)values('{0}','{1}','{2}','{3}','{4}','{5}')";

            cmd = string.Format(cmd, txtname.Text,
                                    txtfamily.Text,
                                    txtusername.Text,
                                    Hash(txtpassword.Text),
                                    new DateConverter().ConverttoMiladi(lbldate.Text),
                                    chbstatus.Checked);

            new sqlclass(Properties.Settings.Default.con_string).SavetoDB(cmd);
            ClearTextBoxes(groupBox1.Controls);

        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                    ctrl.Text = String.Empty;
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }
       
    }
}
