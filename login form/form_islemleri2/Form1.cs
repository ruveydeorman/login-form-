using System.Security.Cryptography;

namespace form_islemleri2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void kodolustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000, 100000);
            textBox4.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();
            timer1.Start();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (KullaniciAd.Text == "ruveyde" && textBox2.Text == "1234" && textBox3.Text == textBox4.Text)
            {
                Form2 frm = new Form2();
                frm.kullanici = KullaniciAd.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Bilgi Giriþi : Kullanýcý adý,þifre ya da kodu yanlýþ girdiniz");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();

        }
        int sayac;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label3.BackColor = Color.DarkBlue;
            }
            else
            {
                label3.BackColor = Color.Purple;
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }
    }
}