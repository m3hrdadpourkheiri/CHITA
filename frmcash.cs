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
    public partial class frmcash : Form
    {
        public frmcash()
        {
            InitializeComponent();
        }
        sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtacount.Text != "")
                {
                    sql.SavetoDB("insert into tblcash(name)values('" + txtacount.Text + "')");
                    txtacount.Text = "";

                    frmhesabha_Load(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                sql.Delete("delete from tblcash where id = " + listBox1.SelectedValue.ToString());
                frmhesabha_Load(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmhesabha_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.DataSource = sql.Fill("select * from tblcash");
                listBox1.DisplayMember = "name";
                listBox1.ValueMember = "id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
