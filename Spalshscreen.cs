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
    public partial class Spalshscreen : Form
    {
        public Spalshscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            new frmlogin().Show();
            this.Hide();
           
        }
        private void Spalshscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
