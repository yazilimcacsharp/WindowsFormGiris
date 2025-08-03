using System.Reflection.PortableExecutable;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        string gelenKategori;
        public Form1(string veri)
        {
            InitializeComponent();
            gelenKategori = veri;
            //MessageBox.Show(gelenKategori);
        }
        string meyve;
        Label[] harflerinLabellari;
        string secilenHarf;
        int hataSayisi = 0;
        PictureBox pbox;
        private void Form1_Load(object sender, EventArgs e)
        {
            Baslat();
            //29 tane harfi yan yana ekleme kısmını burda yapalım
            HarfleriEkranaDiz();

            string tutulanlarDosyaYolu = Path.Combine(
                Application.StartupPath, "tutulanlar.txt");

            string degerler = File.ReadAllText(tutulanlarDosyaYolu);

            do
            {
                meyve = RandomKelimeSec(gelenKategori);

            } while (degerler.Contains(meyve));

            File.AppendAllText(tutulanlarDosyaYolu, meyve);
            File.AppendAllText(tutulanlarDosyaYolu, "\n");



            //eğer üretilen random meyve tutulanlar içerisinde varsa, bu durumda yeni meyve üret, yoksa oyunu o meyve ile başlat.

            kelimeyiDiz(meyve);

            pbox = new PictureBox();
            pbox.Location = new Point(867, 70);
            pbox.Width = 117;
            pbox.Height = 170;
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            string dosyayolu = Path.Combine(Application.StartupPath, "Adam", "0.png");
            //pbox.ImageLocation = dosyayolu;
            pbox.ImageLocation = "Adam//0.png";
            //pbox.Image = Image.FromFile("Adam//0.png");



            this.Controls.Add(pbox);

        }


        int kalanSure = 90;
        Label lbl;
        private void Baslat()
        {
            kalanSure = 90;
            lbl = new Label();
            lbl.Location = new Point(25, 116);
            lbl.Text = $"Süre: {kalanSure}";
            this.Controls.Add(lbl);
            timer1.Start();
        }


        private void HarfleriEkranaDiz()
        {

            int xDeger = 7;
            int asciiCode = 97;
            for (int i = 0; i < 26; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(xDeger, 23);
                btn.Text = ((char)asciiCode).ToString();
                btn.Width = 30;
                btn.Height = 30;
                btn.Click += goster;
                this.Controls.Add(btn);
                xDeger += btn.Width;
                asciiCode++;
            }
            Button btn2 = new Button();
            btn2.Location = new Point(xDeger, 23);
            btn2.Text = ((char)252).ToString();
            btn2.Width = 30;
            btn2.Height = 30;
            btn2.Click += goster;
            this.Controls.Add(btn2);
            xDeger += btn2.Width;
            asciiCode++;


            Button btn3 = new Button();
            btn3.Location = new Point(xDeger, 23);
            btn3.Text = ((char)305).ToString();
            btn3.Width = 30;
            btn3.Height = 30;
            btn3.Click += goster;
            this.Controls.Add(btn3);
            xDeger += btn2.Width;
            asciiCode++;



            Button btn4 = new Button();
            btn4.Location = new Point(xDeger, 23);
            btn4.Text = ((char)287).ToString();
            btn4.Width = 30;
            btn4.Height = 30;
            btn4.Click += goster;
            this.Controls.Add(btn4);
            xDeger += btn2.Width;
            asciiCode++;

            Button btn5 = new Button();
            btn5.Location = new Point(xDeger, 23);
            btn5.Text = ((char)246).ToString();
            btn5.Width = 30;
            btn5.Height = 30;
            btn5.Click += goster;
            this.Controls.Add(btn5);
            xDeger += btn2.Width;
            asciiCode++;



            Button btn6 = new Button();
            btn6.Location = new Point(xDeger, 23);
            btn6.Text = ((char)351).ToString();
            btn6.Width = 30;
            btn6.Height = 30;
            btn6.Click += goster;
            this.Controls.Add(btn6);
            xDeger += btn2.Width;
            asciiCode++;


            Button btn7 = new Button();
            btn7.Location = new Point(xDeger, 23);
            btn7.Text = ((char)231).ToString();
            btn7.Width = 30;
            btn7.Height = 30;
            btn7.Click += goster;
            this.Controls.Add(btn7);
            xDeger += btn2.Width;
            asciiCode++;

        }

        private void goster(object sender, EventArgs e)
        {
            //MessageBox.Show(meyve);
            Button secilenButton = (Button)sender;
            secilenButton.Enabled = false; //tıklanınca tekrar tıklanamaz hale getirdi
                                           //seçilen harf tutulan meyve içerisinde varsa bu durumda ekrana mbox ile harf var diyelim, yoksa harf yok mesajını gösterelim.
                                           //
                                           //MessageBox.Show(secilenButton.Text);
            secilenHarf = secilenButton.Text;

            if (meyve.Contains(secilenHarf.ToLower()))
            {
                //MessageBox.Show("var");
                for (int i = 0; i < meyve.Length; i++)
                {
                    if (meyve[i].ToString() == secilenHarf.ToLower())
                    {
                        harflerinLabellari[i].Text = secilenHarf;

                        //I harfi seçince erikteki i'yi açmıyor.
                        //eğer kullanıcı I seçmişse bu durumda ı ya da i var mı diye baksın.
                        //c seçmişse c ya da ç
                        //s seçmişse s ya da ş+++


                    }


                }

                bool sonuc = OyunBittiMi(harflerinLabellari);
                if (sonuc == true)
                {

                    MessageBox.Show("tebrikler kazandınız");
                    timer1.Stop();
                    ButtonlariTiklanamazYap();
                    this.Controls.Clear();
                    hataSayisi = 0;
                    this.Form1_Load(null, null);
                    //timer1.Start();
                    //timer1.Tick += timer1_Tick;
                    //Baslat();

                }
            }


            else
            {
                //MessageBox.Show("harf yok");
                //hatasayisi değişkenini her harf bilemediğinde 1 artır.
                //picturebox.Imagelocation="Adam\\hatasayisi.png"



                //hatasayisi diye değişken tanımlayıp, her hatada bu değişkenin değerini 1 artıracak sekilde hata sayısı max değere ulaştıgında harfleri açamamışsa bile hata verdirebiliriz.
                hataSayisi++;
                pbox.ImageLocation = "Adam//" + hataSayisi + ".png";


                if (hataSayisi == 6)
                {
                    MessageBox.Show("oyun bitti");
                    this.Close();
                }
            }
        }
        //ekranda gösterilecek olan metni random ile seçelim.

        //muz,erik,kiraz,çilek,ananas meyvelerinden random bir meyve seçen, seçmiş oldugu meyveyi ekrana _ _ , _ _ _ _ _ altçizgilerle gösteren dizen kod.(label, label.Text="_")

        private string RandomKelimeSec(string kategori)
        {
            List<string> kelimeler = new List<string>();
            //meyveler.Add("muz");
            //meyveler.Add("erik");
            //meyveler.Add("kiraz");
            //meyveler.Add("çilek");
            //meyveler.Add("ananas");
            ////0 1 2 3 4
            ///

            //kelimeler.text içerisindeki verileri oyuna yükleyecek kod yazılacak.
            //muz;
            //erik;
            //1.File kullanarak veri okuma işlemi yapılacak.
            //2.okuduğumuz değerleri meyveler listesi içerisine ekleyelim.
            string veriDosyaYolu = "";
            if (kategori == "drinks")
                veriDosyaYolu = Path.Combine(Application.StartupPath, "icecekler.txt");
            else if (kategori == "clothes")
                veriDosyaYolu = Path.Combine(Application.StartupPath, "giysiler.txt");
            else if (kategori == "fruits")
                veriDosyaYolu = Path.Combine(Application.StartupPath, "meyveler.txt");
            else if (kategori == "foods")
                veriDosyaYolu = Path.Combine(Application.StartupPath, "yemekler.txt");


            string[] datalar = File.ReadAllLines(veriDosyaYolu);


            foreach (var item in datalar)
            {
                kelimeler.Add(item.ToLower());
            }

            Random random = new Random();
            int sira = random.Next(0, kelimeler.Count + 1); //0dahil, 2
            return kelimeler[sira];

        }

        //parametre olarak random üretilmiş stringi alacak.
        //ekrana yan yana label eklemeli.
        //label textlerinde _ kelimenin harf adedi kadar olmalı.
        //bu _ yapısını ekranda buttonların biraz altında gösterelim.
        private void kelimeyiDiz(string kelime)
        {
            harflerinLabellari = new Label[kelime.Length];

            int xDeger = 20;
            for (int i = 0; i < kelime.Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(xDeger, 55);
                //lbl.Text += "_";
                lbl.Width = 20;
                this.Controls.Add(lbl);
                if (kelime[i] == ' ')
                {
                    lbl.Text = " ";
                }
                else
                {
                    lbl.Text = "_";
                }
                harflerinLabellari[i] = lbl;
                xDeger += 20;
            }


        }




        //bütün labellar açılmışsa oyun bittiği için tebrikler kazandınız mesajını gösterme
        //harflerinLabellari _ _ _ _, dizisi _ içermeyecek içermiyorsa bütün harfler açılmıştır bu durumda oyun bitti. 
        //parametre olarak bir label[] alan ve içerisindeki bütün harflerii _ dışındaysa bu metot bize true, _ içeriyorsa bize  false değerini dönsün. metodun adı OyunBittiMi() olsun.
        private bool OyunBittiMi(Label[] elemanlar)
        {
            bool durum = false;
            for (int i = 0; i < elemanlar.Length; i++)
            {
                if (elemanlar[i].Text == '_'.ToString())
                {
                    //hala açılmamış harf var demek.
                    return false;
                }
            }
            return true;
        }

        private void ButtonlariTiklanamazYap()
        {

            foreach (var item in this.Controls)
            {
                if (item is Button)
                {

                    Button btn = item as Button;
                    btn.Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            lbl.Text = $"Süre: {kalanSure}";

            if (kalanSure <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz bitti,kaybettiniz");
                Application.Exit();
            }
            else if (kalanSure <= 5)
            {
                lbl.ForeColor = Color.Red;
                lbl.Font = new Font("Arial", 9, FontStyle.Bold);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



