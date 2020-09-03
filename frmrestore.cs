using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHITA
{
    public partial class frmrestore : Form
    {
        public frmrestore()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtaddress.Text != "")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.con_string);
                    string query = "alter database[" + Application.StartupPath + @"\data\Database1.mdf] set single_user with rollback immediate; restore database[" + Application.StartupPath + @"\data\Database1.mdf] from disk='" + txtaddress.Text + "'; alter database [" + Application.StartupPath + @"\data\database1.mdf] set multi_user;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    timer1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در پشتیبان گیری");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Backupfile(*.bak)|*.bak";
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtaddress.Text = od.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show("فایل پشتیبان با موفقیت بازگردانی شد");
                this.Close();
            }
        }
    }
}
