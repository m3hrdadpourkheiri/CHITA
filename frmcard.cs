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
    public partial class frmcard : Form
    {

        public string id = null;


        public frmcard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmcard_Load(object sender, EventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(@"Data\card");
            cmbcards.Items.AddRange(files);


            DataTable dt = new sqlclass(Properties.Settings.Default.con_string).Fill("select * from tblmember where id =" + id);

            lblcode.Text = dt.Rows[0]["code"].ToString();
            lblname.Text = dt.Rows[0]["name"].ToString();
            lblfamily.Text = dt.Rows[0]["family"].ToString();
            byte[] bytes = Convert.FromBase64String(dt.Rows[0]["picture"].ToString());

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
            {
                picture.Image = Image.FromStream(ms);
            }

        }

        private void cmbcards_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(cmbcards.SelectedItem.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // lblgymname.Location.X = (panel1.Width / 2) - (lblgymname.Width / 2);
            lblgymname.Location = new Point(((panel2.Size.Width / 2) - (lblgymname.Size.Width / 2)), lblgymname.Location.Y);//x, y;
            lblcode.Location = new Point(panel2.Size.Width / 2, lblcode.Location.Y);
            lblname.Location = new Point(panel2.Size.Width / 2, lblname.Location.Y);
            lblfamily.Location = new Point(panel2.Size.Width / 2, lblfamily.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private Point MouseDownLocation;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                piclogo.Left = e.X + piclogo.Left - MouseDownLocation.X;
                piclogo.Top = e.Y + piclogo.Top - MouseDownLocation.Y;
            }
        }

        private void lblcode_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void lblcode_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblcode.Left = e.X + lblcode.Left - MouseDownLocation.X;
                lblcode.Top = e.Y + lblcode.Top - MouseDownLocation.Y;
            }
        }

        private void lblname_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void lblfamily_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void lblname_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblname.Left = e.X + lblname.Left - MouseDownLocation.X;
                lblname.Top = e.Y + lblname.Top - MouseDownLocation.Y;
            }
        }

        private void lblfamily_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblfamily.Left = e.X + lblfamily.Left - MouseDownLocation.X;
                lblfamily.Top = e.Y + lblfamily.Top - MouseDownLocation.Y;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                picture.Left = e.X + picture.Left - MouseDownLocation.X;
                picture.Top = e.Y + picture.Top - MouseDownLocation.Y;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void lblgymname_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblgymname.Left = e.X + lblgymname.Left - MouseDownLocation.X;
                lblgymname.Top = e.Y + lblgymname.Top - MouseDownLocation.Y;
            }
        }

        private void lblgymname_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblcodetitle.Left = e.X + lblcodetitle.Left - MouseDownLocation.X;
                lblcodetitle.Top = e.Y + lblcodetitle.Top - MouseDownLocation.Y;
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblnametitle.Left = e.X + lblnametitle.Left - MouseDownLocation.X;
                lblnametitle.Top = e.Y + lblnametitle.Top - MouseDownLocation.Y;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lblfamilytitle.Left = e.X + lblfamilytitle.Left - MouseDownLocation.X;
                lblfamilytitle.Top = e.Y + lblfamilytitle.Top - MouseDownLocation.Y;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                
                DialogResult dr= sd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    using (var bmp = new Bitmap(panel2.Width, panel2.Height))
                    {
                        panel2.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        bmp.Save(sd.FileName);
                    }
                    MessageBox.Show("Image saved successfully.");
                }
            }
            catch
            {
                MessageBox.Show("Error.....");
            }
        }

        private void Chblogo_CheckedChanged(object sender, EventArgs e)
        {
            piclogo.Visible = chblogo.Checked;
        }

        private void Chbpic_CheckedChanged(object sender, EventArgs e)
        {
            picture.Visible = chbpic.Checked;
        }

        private void Chbbackground_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Chbgymname_CheckedChanged(object sender, EventArgs e)
        {
            lblgymname.Visible = chbgymname.Checked;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult dr = fd.ShowDialog();

            if(dr==DialogResult.OK)
            {
                lblgymname.Font = fd.Font;
                lblcode.Font = fd.Font;
                lblname.Font = fd.Font;
                lblfamily.Font = fd.Font;
                lblcodetitle.Font = fd.Font;
                lblnametitle.Font = fd.Font;
                lblfamilytitle.Font = fd.Font;

            }
        }
    }
}
