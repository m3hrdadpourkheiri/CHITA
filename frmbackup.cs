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
    public partial class frmbackup : Form
    {
        public frmbackup()
        {
            InitializeComponent();
        }



        



        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.FileName = DateTime.Now.ToString("dd mm yyyy _ hh dd ss");
            sd.Filter = "Backupfile(*.bak)|*.bak";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                txtaddress.Text = sd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtaddress.Text != "")
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.con_string);
                    string query = "BACKUP database[" + Application.StartupPath + @"\data\Database1.mdf] To disk='" + txtaddress.Text + "'";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                MessageBox.Show("فایل پشتیبان با موفقیت تهیه شد");
                this.Close();
            }
        }
    }
}
