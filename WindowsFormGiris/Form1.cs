namespace WindowsFormGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Merhaba";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label3.Text = "button içerisine mouse ile geldin";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "button sınırlarından ayrıldın.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "İstanbul"; //this: içerisinde bulundugumuz formu temsil eder.
            this.BackColor = Color.Red;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ad = textBox2.Text;
            label5.Text = "Merhaba " + ad;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //seçili hale getirmek, seçimi kaldırmak
            if (checkBox1.Checked)
            {
                label6.Text = "Futbolu seçtiniz.";
            }
            else
            {
                label6.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) //radibutton1.Checked
            {
                label7.Text = "1.seçenek seçildi";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label7.Text = "2.seçenek seçildi";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show( listBox1.SelectedItem.ToString());
            textBox3.Text=listBox1.SelectedItem.ToString();

        }
    }
}
