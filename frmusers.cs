using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHITA
{
    public partial class frmusers : Form
    {
        public frmusers()
        {
            InitializeComponent();
        }

        private void Frmusers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblusers");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1["username", dataGridView1.CurrentRow.Index].Value.ToString()=="admin")
            {
                MessageBox.Show("کاربر Admin قابل حذف کردن نیست");
                return;

            }


            DialogResult dr = MessageBox.Show("آیا کاربر "+ dataGridView1["name", dataGridView1.CurrentRow.Index].Value.ToString()+" حذف شود؟","پیام سیستم", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dr == DialogResult.Yes)
            {
                new sqlclass(Properties.Settings.Default.con_string).Delete("delete from tblusers where id =" + dataGridView1["id", dataGridView1.CurrentRow.Index].Value.ToString());
                Frmusers_Load(null, null);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmchangepass fp = new frmchangepass();
            fp.name = dataGridView1["name", dataGridView1.CurrentRow.Index].Value.ToString();
            fp.family = dataGridView1["family", dataGridView1.CurrentRow.Index].Value.ToString();
            fp.username = dataGridView1["username", dataGridView1.CurrentRow.Index].Value.ToString();
            fp.id = dataGridView1["id", dataGridView1.CurrentRow.Index].Value.ToString();
            fp.ShowDialog();
        }
    }
}
