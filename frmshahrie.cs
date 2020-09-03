using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CHITA
{
    public partial class frmshahrie : Form
    {
        public frmshahrie()
        {
            InitializeComponent();
        }
        string id = null;
        private void Frmshahrie_Load(object sender, EventArgs e)
        {
            try
            {
                sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);
                cmbcash.DataSource = sql.Fill("select id,name from tblcash");
                cmbcash.DisplayMember = "name";
                cmbcash.ValueMember = "id";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Txtcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcode.Text[txtcode.TextLength - 1] == '\n')
                {
                    DataTable dt = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblmember where code ='" + txtcode.Text.Substring(0,txtcode.TextLength-2) + "'");
                    txtcode.Text = "";

                    if (dt.Rows.Count > 0)
                    {
                        id = dt.Rows[0]["id"].ToString();
                        lblnamefamily.Text = dt.Rows[0]["name"].ToString() + " " + dt.Rows[0]["family"].ToString();

                        byte[] bytes = Convert.FromBase64String(dt.Rows[0]["picture"].ToString());
                        MemoryStream ms = new MemoryStream(bytes);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch { }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string cmd = "insert into tblcharge (memberid,date,cashid,numberofsession,amount,expiredate)values({0},'{1}',{2},{3},{4},'{5}')";
            cmd = string.Format(cmd, id,
                                  new DateConverter().ConverttoMiladi(txtpaydate.Text),
                                  cmbcash.SelectedValue.ToString(),
                                  txtnumberofsession.Text,
                                  txtamount.Text,
                                  new DateConverter().ConverttoMiladi(txtexpiredate.Text));

            new sqlclass(Properties.Settings.Default.con_string).SavetoDB(cmd);


            cmd = @"if exists(SELECT * from tblcreadit where memberid ={0})
                    BEGIN
                    update tblcreadit set remainingsession = (select remainingsession from tblcreadit where memberid = {1})+{2} , expiredate = '{3}' where memberid = {4}
                    End
                    else
                    begin
                    insert into tblcreadit (memberid,remainingsession,expiredate)values({5}, {6}, '{7}')
                    end ";

            cmd = string.Format(cmd, id,
                                     id,
                                     txtnumberofsession.Text,
                                     new DateConverter().ConverttoMiladi(txtexpiredate.Text),
                                     id,
                                     id,
                                     txtnumberofsession.Text,
                                     new DateConverter().ConverttoMiladi(txtexpiredate.Text));

            new sqlclass(Properties.Settings.Default.con_string).SavetoDB(cmd);

            ClearTextBoxes(this.Controls);
            lblnamefamily.Text = "?";
            pictureBox1.Image = null;
            MessageBox.Show("شارژ با موفقیت انجام شد", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
