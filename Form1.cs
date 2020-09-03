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

namespace CHITA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            switch (treeView1.SelectedNode.Name)
            {
                case "newdocument":
                    new frmnewstudentfile().ShowDialog();
                    break;
                case "newcoach":
                    new frmnewcoachfile().ShowDialog();
                    break;
                case "costs":
                    new frmcost().ShowDialog();
                    break;
                case "hesabha":
                    new frmcash().ShowDialog();
                    break;
                case "costpay":
                    new frmcostpay().ShowDialog();
                    break;
                case "profile":
                    new frmprofile().ShowDialog();
                    break;
                case "card":
                    new frmcard().ShowDialog();
                    break;
                case "shahrieh":
                    new frmshahrie().ShowDialog();
                    break;
                case "presence":
                    new frmPresence().ShowDialog();
                    break;
                case "newuser":
                    new frmadduser().ShowDialog();
                    break;
                case "users":
                    new frmusers().ShowDialog();
                    break;



            }

            
           
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new aboutus().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button1_Click_1(null, null);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dataGridView_member.DataSource = new sqlclass(Properties.Settings.Default.con_string).Fill("select tblMember.id,tblMember.code,tblMember.name,tblMember.family,tblMember.gender,tblcoach.name +' '+ tblcoach.family as coachname from tblmember,tblcoach where tblMember.coachid=tblcoach.id");
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void کارتعضویتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcard fc = new frmcard();
            fc.id = dataGridView_member["id", dataGridView_member.CurrentRow.Index].Value.ToString();
            fc.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //frmReportView rp = new frmReportView();
            //rp.ShowDialog();
        }

        private void چاپپروندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportView rp = new frmReportView();
            rp.id = dataGridView_member["id", dataGridView_member.CurrentRow.Index].Value.ToString();
            rp.ShowDialog();
        }
    }
}
