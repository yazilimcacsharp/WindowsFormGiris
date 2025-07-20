namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //29 tane harfi yan yana ekleme kısmını burda yapalım
            ButtonlariEkle();

            string meyve = RandomMeyveSec();
            kelimeyiDiz(meyve);

        }

        private void ButtonlariEkle()
        {

            int xDeger = 7;
            int asciiCode = 65;
            for (int i = 0; i < 26; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(xDeger, 23);
                btn.Text = ((char)asciiCode).ToString();
                btn.Width = 30;
                btn.Height = 30;
                this.Controls.Add(btn);
                xDeger += btn.Width;
                asciiCode++;
            }
        }

        //ekranda gösterilecek olan metni random ile seçelim.

        //muz,erik,kiraz,çilek,ananas meyvelerinden random bir meyve seçen, seçmiş oldugu meyveyi ekrana _ _ , _ _ _ _ _ altçizgilerle gösteren dizen kod.(label, label.Text="_")

        private string RandomMeyveSec()
        {
            List<string> meyveler = new List<string>();
            meyveler.Add("muz");
            meyveler.Add("erik");
            meyveler.Add("kiraz");
            meyveler.Add("çilek");
            meyveler.Add("ananas");
            //0 1 2 3 4

            Random random = new Random();
            int sira = random.Next(0, 5);
            return meyveler[sira];

        }

        //parametre olarak random üretilmiş stringi alacak.
        //ekrana yan yana label eklemeli.
        //label textlerinde _ kelimenin harf adedi kadar olmalı.
        //bu _ yapısını ekranda buttonların biraz altında gösterelim.
        private void kelimeyiDiz(string kelime)
        {

            int xDeger = 20;
            for (int i = 0; i < kelime.Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(xDeger, 55);
                lbl.Text += "_";  
                lbl.Width=10;
                this.Controls.Add(lbl);
                xDeger += 20;
            }

        }
    }
}
