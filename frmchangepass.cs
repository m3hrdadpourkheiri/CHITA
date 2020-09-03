using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHITA
{
    public partial class frmchangepass : Form
    {
        public string name, family, username,id;

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



        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != txtconfirm.Text)
            {
                MessageBox.Show("عدم تطابق کلمه های عبور");
                return;

            }
            else
            {
                new sqlclass(Properties.Settings.Default.con_string).SavetoDB("update tblusers set password = '" + Hash(txtpassword.Text) + "'   where id = " + id);
                MessageBox.Show("کلمه عبور جدید با موفقییت ذخیره شد");
                this.Close();
            }
        }

        public frmchangepass()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmchangepass_Load(object sender, EventArgs e)
        {
            lblname.Text = name + " " + family;
            lblusername.Text = username;
        }
    }
}
