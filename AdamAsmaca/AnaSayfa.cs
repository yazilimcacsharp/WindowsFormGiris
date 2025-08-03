using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        string kategori;
        private void button1_Click(object sender, EventArgs e)
        {
            kategori = "drinks";
            Form1 frm=new Form1(kategori);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kategori = "fruits";
            Form1 frm = new Form1(kategori);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kategori = "foods";
            Form1 frm = new Form1(kategori);
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kategori = "clothes";
            Form1 frm = new Form1(kategori);
            frm.ShowDialog();
        }
    }
}
