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
    public partial class frmPresence : Form
    {
        public frmPresence()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtcode.Text[txtcode.TextLength - 1] == '\n')
                {
                    DataTable dt = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblmember where code ='" + txtcode.Text.Substring(0, txtcode.TextLength - 2) + "'");
                    
                    txtcode.Text = "";

                    if (dt.Rows.Count > 0)
                    {
                        
                        lblname.Text = dt.Rows[0]["name"].ToString();
                        lblfamily.Text= dt.Rows[0]["family"].ToString();
                        string code= dt.Rows[0]["code"].ToString();
                        string id = dt.Rows[0]["id"].ToString();

                        byte[] bytes = Convert.FromBase64String(dt.Rows[0]["picture"].ToString());
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        pictureBox1.Image = Image.FromStream(ms);
                        


                        DataTable dt2 = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblcreadit where memberid = " + id);
                        if(dt2.Rows[0]["remainingsession"].ToString()=="0")
                        {
                            lblstatus.ForeColor = Color.Red;
                            lblstatus.Text = "عدم اعتبار";
                            Logobox.Image = Properties.Resources.Error;
                        }
                        else if (dt2.Rows[0]["remainingsession"].ToString() == "1")
                        {
                            lblstatus.ForeColor = Color.Yellow;
                            lblstatus.Text = "جلسه آخر لطفا شارژ کنید";
                            new sqlclass(Properties.Settings.Default.con_string).SavetoDB("update tblcreadit set remainingsession = (select remainingsession from tblcreadit where memberid =" + id + ")-1 where memberid =" + id);
                            Logobox.Image = Properties.Resources.Alert;
                        }
                        else
                        {
                            lblstatus.ForeColor = Color.Green;
                            lblstatus.Text = "خوش آمدید";
                            new sqlclass(Properties.Settings.Default.con_string).SavetoDB("update tblcreadit set remainingsession = (select remainingsession from tblcreadit where memberid =" + id + ")-1 where memberid =" + id);
                            Logobox.Image = Properties.Resources.Valid;
                        }

                        string creadit = (Int32.Parse(dt2.Rows[0]["remainingsession"].ToString())-1).ToString();
                        if (creadit == "0")
                            lblcreadit.Text = "0";
                        else if (creadit == "-1")
                            lblcreadit.Text = "0";


                    }
                    else if(dt.Rows.Count == 0)
                    {
                        lblstatus.ForeColor = Color.Red;
                        lblstatus.Text = "کارت نا معتبر";
                        lblname.Text = "نا معتبر";
                        lblfamily.Text = "نا معتبر";
                        lblcreadit.Text = "نا معتبر";
                        Logobox.Image = Properties.Resources.Error;
                    }
                }
            }
            catch { }
        }
    }
}
