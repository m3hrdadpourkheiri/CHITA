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
    public partial class frmdbsetting : Form
    {
        public frmdbsetting()
        {
            InitializeComponent();
        }
        private string server_connection_build()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtservername.Text;
            builder.InitialCatalog = txtdatabasename.Text;
            builder.MultipleActiveResultSets = true;

            if (checkBox1.Checked == true)
            {
                builder.IntegratedSecurity = true;

            }
            else if (checkBox1.Checked == false)
            {
                builder.IntegratedSecurity = false;
                builder.UserID = txtusername.Text;
                builder.Password = txtpassword.Text;
            }

            return builder.ConnectionString;

        }



        private string express_connection_build()
        {

            string connectionstring = "Data Source=.\\SQLExpress;AttachDbFilename={0};Integrated Security=True;";

            connectionstring = string.Format(connectionstring, op.FileName);//, op.FileName.Split('\\')[op.FileName.Split('\\').Length-1]);

            return connectionstring;



        }

        private void frmdbsetting_Load(object sender, EventArgs e)
        {
            lblconnectionstring.Text = Properties.Settings.Default.con_string;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (radioserver.Checked)
            {
                if (txtservername.Text == "")
                {
                    txtservername.BackColor = Color.LightGoldenrodYellow;
                    return;
                }
                if (txtdatabasename.Text == "")
                {
                    txtdatabasename.BackColor = Color.LightGoldenrodYellow;
                    return;
                }
                Properties.Settings.Default.con_string = server_connection_build();
            }
            else if(radioexpress.Checked)
            {
                if (txtexpress.Text == "")
                {
                    txtexpress.BackColor = Color.LightGoldenrodYellow;
                    return;
                }
                Properties.Settings.Default.con_string = express_connection_build();
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioexpress.Checked=true;
            radioserver.Checked = false;
            gpbexpress.Enabled = true;
            radioserver.Enabled = false;
        }

        private void lblconnectionstring_Click(object sender, EventArgs e)
        {

        }

        private void radioexpress_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioexpress_Click(object sender, EventArgs e)
        {
            radioexpress.Checked = true;
            gpbexpress.Enabled = true;
            radioserver.Checked = false;
            gpbserver.Enabled = false;
        }

        private void radioserver_Click(object sender, EventArgs e)
        {
            radioexpress.Checked = false;
            gpbexpress.Enabled = false;
            radioserver.Checked = true;
            gpbserver.Enabled = true;
        }

        OpenFileDialog op; 
        private void button1_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.Filter = "SQL database file (*.mdf)|*.mdf";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;

            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtexpress.Text = op.FileName;
            }
        }
    }
}
