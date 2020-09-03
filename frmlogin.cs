using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CHITA
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);

        Point mouseDownPoint = Point.Empty;

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



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string cmd = "select * from tblusers where username='{0}' and password='{1}'";

            cmd = string.Format(cmd, txtusername.Text, Hash(txtpassword.Text).ToLower());

            if (sql.Login(cmd))

            {
                this.Hide();
                this.ShowInTaskbar = false;
                Form1 fm = new Form1();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show(Hash(txtpassword.Text).ToLower(), txtusername.Text);
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            txtusername.Text = "نام کاربری";
            txtpassword.Text = "کلمه عبور";
        }

        private void Txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "نام کاربری";
                txtusername.ForeColor = Color.Gray;
            }
        }

        private void Txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "نام کاربری")
            {
                txtusername.Text = "";
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "کلمه عبور")
            {
                txtpassword.Text = "";
            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "کلمه عبور";
                txtpassword.ForeColor = Color.Gray;
            }
        }

        private void Txtusername_TextChanged(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtusername.Text != "نام کاربری")
                txtusername.ForeColor = Color.Black;
        }

        private void Txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text != "" && txtpassword.Text != "کلمه عبور")
                txtpassword.ForeColor = Color.Black;
        }

        private void Frmlogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void Frmlogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void Frmlogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //frmsqlsetting fs = new frmsqlsetting();
            //fs.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmdbsetting fs = new frmdbsetting();
            fs.ShowDialog();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
