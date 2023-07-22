using _214001004.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _214001004
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGirisEkrani_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Close();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            this.Close();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            this.Close();
            frm.Show();
        }
    }
}
