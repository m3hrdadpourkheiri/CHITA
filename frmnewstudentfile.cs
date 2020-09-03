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
using System.Globalization;
using FarsiLibrary.Win.Enums;

namespace CHITA
{
    public partial class frmnewstudentfile : Form
    {
        public frmnewstudentfile()
        {
            InitializeComponent();
        }


        sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);
        private void button3_Click(object sender, EventArgs e)
        {
            string command = "insert into tblMember (code,name,family,personalid,nasionalid,fathername,birthdate,signupdate,gender,marital,mobilenumber,insurancecode,coachid,address,description,picture)values" +
                                                       "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},'{12}','{13}','{14}','{15}')";

            if(txtpicture.Text == "")
            {
                txtpicture.Text = @"Data\person_photo.jpg";
            }
            FileInfo fi = new FileInfo(txtpicture.Text);
            FileStream fs = fi.OpenRead();
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
            string base64Picture = Convert.ToBase64String(bytes, 0, bytes.Length);


            string fcommand = string.Format(command, txtcode.Text,
                                                     txtname.Text,
                                                     txtfamily.Text,
                                                     txtpersonalid.Text,
                                                     txtnasionalcode.Text,
                                                     txtfathername.Text,
                                                     new DateConverter().ConverttoMiladi(txtbirthday.Text),
                                                     new DateConverter().ConverttoMiladi(txtsignupdate.Text),
                                                     cmbgender.SelectedItem.ToString(),
                                                     cmbmarital.SelectedItem.ToString(),
                                                     txtmobilenumber.Text,
                                                     txtinsurancecode.Text,
                                                     cmbcoach.SelectedValue.ToString(),
                                                     txtaddress.Text,
                                                     txtdescription.Text,
                                                     base64Picture);
            



            sql.SavetoDB(fcommand);
            MessageBox.Show("ثبت پرونده با موفقییت انجام شد", "پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBoxes(groupBox1.Controls);
            pictureBox1.Image = null;



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

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "jpg Image File (*.jpg)|*.jpg";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;

            DialogResult dr = op.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtpicture.Text = op.FileName;
                pictureBox1.Image = Image.FromFile(txtpicture.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmnewstudentfile_Load(object sender, EventArgs e)
        {
            try
            {
                cmbcoach.DataSource = sql.Fill("select id,name,family from tblcoach");
                cmbcoach.DisplayMember = "family";
                cmbcoach.ValueMember = "id";
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
