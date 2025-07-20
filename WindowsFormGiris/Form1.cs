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
            textBox3.Text = listBox1.SelectedItem.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label8.Text = "Günaydın " + textBox4.Text;
        }
        int sayac = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            sayac++;
            label9.Text = sayac.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label9.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //19.07 gun, 19.07 saat her 2bilgi aynı anda kontrol ediliyor olmalı.

            int gun = DateTime.Now.Day;
            int ay = DateTime.Now.Month;
            int saat = DateTime.Now.Hour;
            int dak = DateTime.Now.Minute;

            if (gun == 19 && ay == 07 && saat == 19 && dak == 07)
            {
                label10.Text = "fenerbahçeliler gününüz kutlu olsun";
            }
            else
            {
                label10.Text = "Hello";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //label11.Text= listBox2.SelectedItem.ToString();
            if (listBox2.Items.Count > 0)
            {
                listBox3.Items.Add(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("seçecek eleman kalmadı");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count > 0)
            {
                listBox2.Items.Add(listBox3.SelectedItem.ToString());
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
            else
            {
                MessageBox.Show("seçecek eleman kalmadı");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form yüklenmeden ekrana çizdirilmeden önce bu metot çalışır

            comboBox1.Items.Add("istanbul");
            comboBox1.Items.Add("ankara");
            comboBox1.Items.Add("izmir");
            comboBox1.Items.Add("adana");

            ComboboxDoldur(comboBox3);
            ComboboxDoldur(comboBox5);
            ComboboxDoldurYil(comboBox6);
            ComboboxDoldurGun(comboBox4);

            label22.Text = "";
        }

        //parametre olarak Combobox alan 1den 12ye kadar olan sayıları bu combobox içerisine dolduran metot

        private void ComboboxDoldur(ComboBox cmbbox)
        {
            for (int i = 1; i < 13; i++)
            {
                cmbbox.Items.Add(i);
            }
        }

        //yıl 1950-2025 arası


        private void ComboboxDoldurYil(ComboBox cmbbox)
        {
            for (int i = 1950; i < 2026; i++)
            {
                cmbbox.Items.Add(i);
            }
        }

        private void ComboboxDoldurGun(ComboBox cmbbox)
        {
            for (int i = 1; i < 31; i++)
            {
                cmbbox.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text = comboBox1.SelectedItem.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label15.Text = textBox5.Text + " " + comboBox2.SelectedItem.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Location = new Point(372, 404);
            button.Width = 100;
            button.Height = 100;
            button.BackColor = Color.Red;
            button.ForeColor = Color.White;
            button.Text = "HELLO";
            this.Controls.Add(button);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(textBox6.Text);
            int x = 390;
            for (int i = 0; i < adet; i++)
            {
                Button button = new Button();
                button.Location = new Point(x, 478);
                button.Width = 75;
                button.Height = 50;
                button.BackColor = Color.Red;
                button.ForeColor = Color.White;
                button.Text = "HELLO";
                this.Controls.Add(button);
                x += button.Width;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //seçili olan üyeyi labelda gösterme
            label17.Text = dateTimePicker1.Value.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            int adet = int.Parse(comboBox3.SelectedItem.ToString());
            dt = dt.AddMonths(adet);
            label17.Text = dt.Date.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label22.Text += comboBox4.Text + "-" + comboBox5.Text + "-" + comboBox6.Text;


        }

        private void button18_Click(object sender, EventArgs e)
        {
            //for (; ; )
            //{
            //    YeniForm form = new YeniForm();
            //    form.Show();
            //}
            //
            YeniForm form = new YeniForm();
            form.ShowDialog();
        }
    }
}
