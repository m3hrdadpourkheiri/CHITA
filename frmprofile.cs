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
using System.Data.SqlClient;
namespace CHITA
{
    public partial class frmprofile : Form
    {

        string logo_address = "";



        public frmprofile()
        {
            InitializeComponent();
        }
        sqlclass sql = new sqlclass(Properties.Settings.Default.con_string);
        private void frmprofile_Load(object sender, EventArgs e)
        {
            DataTable dt = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblprofile where id = 1");
            txtgymname.Text = dt.Rows[0]["name"].ToString();
            txtmanager.Text = dt.Rows[0]["manager"].ToString();
            txtaddress.Text = dt.Rows[0]["address"].ToString();
            if (dt.Rows[0]["logo"].ToString() != "")
            {
                MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["logo"]);
                pictureBox1.Image = new Bitmap(ms);
            }
            //byte[] bytes = Convert.FromBase64String(dt.Rows[0][4].ToString());
            //Image image;
            //using (MemoryStream ms = new MemoryStream(bytes))
            //{
            //    image = Image.FromStream(ms);
            //}
            //pictureBox1.Image = image;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            string cmd = "update tblprofile set name = '" + txtgymname.Text + "' , address = '" + txtaddress.Text + "' , manager = '" + txtmanager.Text + "', logo = {0} where id = 1";
            cmd = string.Format(cmd, ImageToByte(pictureBox1.Image));
            new sqlclass(Properties.Settings.Default.con_string).SavetoDB(cmd);

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con_string);
            //SqlCommand cmd=new SqlCommand();
            //if(logo_address!="")
            //{
            //    cmd.CommandText = "update tblprofile set name='"+txtgymname.Text+"' , address='"+txtaddress.Text+"' , manager='"+txtmanager.Text+"', logo = @LOGO where id = 1";
            //    cmd.Parameters.AddWithValue("@LOGO", ImageToByte(pictureBox1.Image));
            //}
            //else if (logo_address=="")
            //{
            //    cmd.CommandText = "update tblprofile set name='"+ txtgymname.Text + "' , address='"+ txtaddress.Text + "' , manager='"+ txtmanager.Text + "'  where id = 1";
            //}
            //cmd.Connection = con;
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("saved successfully");
            //this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg|PNG|*.png";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;

            DialogResult dr = op.ShowDialog();

            if (dr == DialogResult.OK)
            {
                logo_address = op.FileName;
                pictureBox1.Image = Image.FromFile(logo_address);
            }
        }
    }
}
