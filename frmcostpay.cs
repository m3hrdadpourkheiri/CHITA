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
    public partial class frmcostpay : Form
    {
        public frmcostpay()
        {
            InitializeComponent();
        }
        sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);
        private void frmcostpay_Load(object sender, EventArgs e)
        {
            cmbcost.DataSource = sql.Fill("select * from tblcost");
            cmbcost.DisplayMember = "name";
            cmbcost.ValueMember = "id";

            cmbcash.DataSource = sql.Fill("select * from tblcash");
            cmbcash.DisplayMember = "name";
            cmbcash.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd = "insert into tblcostpay (costid,cashid,date,amount,description)values({0},{1},'{2}',{3},'{4}')";
            cmd = string.Format(cmd, cmbcost.SelectedValue.ToString(), cmbcash.SelectedValue.ToString(), new DateConverter().ConverttoMiladi(faDatePicker1.Text), txtamount.Text, txtdescription.Text);
            MessageBox.Show(cmd);

            sql.SavetoDB(cmd);

            ClearTextBoxes(groupBox1.Controls);
        }


        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
    }
}
