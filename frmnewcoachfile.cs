using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace CHITA
{
    public partial class frmnewcoachfile : Form
    {
        public frmnewcoachfile()
        {
            InitializeComponent();
        }
        sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);
        private string dateconverttomiladi(string s)
        {
            string[] date = s.Split('/');

            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(Int32.Parse(date[0]), Int32.Parse(date[1]), Int32.Parse(date[2]), pc);

            string m = dt.Month.ToString(), d = dt.Day.ToString();

            switch (m)
            {
                case "0":
                    m = "00";
                    break;
                case "1":
                    m = "01";
                    break;
                case "2":
                    m = "02";
                    break;
                case "3":
                    m = "03";
                    break;
                case "4":
                    m = "04";
                    break;
                case "5":
                    m = "05";
                    break;
                case "6":
                    m = "06";
                    break;
                case "7":
                    m = "07";
                    break;
                case "8":
                    m = "08";
                    break;
                case "9":
                    m = "09";
                    break;
            }
            switch (d)
            {
                case "0":
                    d = "00";
                    break;
                case "1":
                    d = "01";
                    break;
                case "2":
                    d = "02";
                    break;
                case "3":
                    d = "03";
                    break;
                case "4":
                    d = "04";
                    break;
                case "5":
                    d = "05";
                    break;
                case "6":
                    d = "06";
                    break;
                case "7":
                    d = "07";
                    break;
                case "8":
                    d = "08";
                    break;
                case "9":
                    d = "09";
                    break;
            }
            return dt.Year.ToString() + "-" + m + "-" + d;

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



        private void frmnewcoachfile_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string command = "insert into tblcoach (code,name,family,personalid,nasionalid,fathername,birthdate,signupdate,gender,marital,mobilenumber,insurancecode,sport,licensenumber,address,description,picture)values" +
                                                           "({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')";

            if (txtpicture.Text == "")
            {
                txtpicture.Text = @"Data\person_photo.png";
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
                                                         dateconverttomiladi(txtbirthday.Text),
                                                         dateconverttomiladi(txtsignupdate.Text),
                                                         cmbgender.SelectedItem.ToString(),
                                                         cmbmarital.SelectedItem.ToString(),
                                                         txtmobilenumber.Text,
                                                         txtinsurancecode.Text,
                                                         txtsport.Text,
                                                         txtlicensenumber.Text,
                                                         txtaddress.Text,
                                                         txtdescription.Text,
                                                         base64Picture);




                sql.SavetoDB(fcommand);
                MessageBox.Show("ثبت پرونده با موفقییت انجام شد","پیام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes(groupBox1.Controls);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
