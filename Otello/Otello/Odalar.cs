using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otello
{
    public partial class Odalar : Form
    {
        private string secLevel;
        public string SecLevel {
        get { return secLevel; }
        set { secLevel = value; }
                }
        public Odalar()
        {
            InitializeComponent();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string iconPath = Path.Combine(currentDirectory, "ico.ico");
            Icon formIcon = new Icon(iconPath);
            this.Icon = formIcon;
            rylVisible(false);
            luxVisible(false);
            famVisible(false);
            label1.Visible = false;
            label2.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            famHizmet();
            famVisible(true);
            luxVisible(false);
            rylVisible(false);
            lblVisible();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "family", "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            luxHizmet();
            famVisible(false);
            luxVisible(true);
            rylVisible(false);
            lblVisible();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "luxurious", "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            rylHizmet();
            famVisible(false);
            luxVisible(false);
            rylVisible(true);
            lblVisible();
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "royalty", "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "royalty", "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "royalty", "2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "royalty", "3.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void pic4_Click(object sender, EventArgs e)
        {

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "royalty", "4.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            famHizmet();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            genelHizmet();
        }

        private void genelHizmet()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\r\n    Girişte Meyve (Yeşil Elma Tabağı)\r\n   Duşa Kabin\r\n    Tıraş / Makyaj Aynası\r\n    Saç Kurutma Makinası\r\n    Jakuzi\r\n    Banyoda Çift Lavabo\r\n    Bornoz ve Terlik\r\n    Kadınlara Özel Hijyen Set Kutusu\r\n    Erkeklere Özel Hijyen Set Kutusu\r\n    0-11 Yaş Çocuklara Özel Set\r\n    Bottega Veneta Kozmetik Ürünleri\r\n    Dijital Kasa\r\n    Direk Hat Telefon\r\n    LCD TV\r\n    Media Hub\r\n    Su Isıtıcısı & Nespresso Kahve Makinası\r\n    Çay ve Kahve Seti\r\n    Soyunma Odası\r\n    Balkon veya Terasta...\r\n    Valizlik\r\n    Baskül\r\n    Yağışlı Havalarda Odalara Yağmurluk\r\n");

        }
        private void famHizmet()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\r\n    Fast Track ve CIP Lounge\r\n    Yastık Menüsü (5 çeşit)\r\n    Akşam Turn Down Servisi\r\n    Oda Temizlik Servisi...\r\n    Girişte Özel Meyve Tabağı\r\n    Maxx Assistant\r\n    Elektronik Anahtar Sistemi\r\n");

        }
        private void luxHizmet()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\r\n    Fast Track ve CIP Lounge\r\n    Yastık Menüsü (5 çeşit)\r\n    Oda Temizlik Servisi...\r\n    Akşam Turn Down Servisi\r\n    Günlük Gazete Servisi\r\n    Maxxi Bar\r\n    Girişte Özel Meyve Tabağı\r\n    Ücretsiz Room Service\r\n    Maxx Assistant\r\n    Elektronik Anahtar Sistemi\r\n");
        }
        private void rylHizmet()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\r\n    VIP Havaalanı Transferi\r\n    Maxx Protocol Hizmeti\r\n    Yastık Menüsü (5 çeşit)\r\n    Akşam Turn Down Servisi\r\n    Oda Temizlik Servisi...\r\n    Günlük Gazete Servisi\r\n    Maxxi Bar\r\n    Girişte Özel Meyve Tabağı\r\n    Talep üzerine Dom Perignon veya Armand de Brignac Şampanya servisi\r\n    Çiçek Buketi\r\n    Ücretsiz Room Service\r\n    Full Bar Set Up\r\n    Pavilion\r\n    Maxx Assistant\r\n    Özel Butler Servisi\r\n    Yıkama ve Ütüleme Servisi\r\n    Elektronik Anahtar Sistemi\r\n");

        }
        private void rylVisible(bool isTrue)
        {

            rylpic1.Visible = isTrue;
            rylpic2.Visible = isTrue;
            rylpic3.Visible = isTrue;
            rylpic4.Visible = isTrue;
        }

        private void famVisible(bool isTrue)
        {
            fampic1.Visible = isTrue;
            fampic2.Visible = isTrue;
            fampic3.Visible = isTrue;
            fampic4.Visible = isTrue;
        }

        private void luxVisible(bool isTrue)
        {
            luxpic1.Visible = isTrue;
            luxpic2.Visible = isTrue;
            luxpic3.Visible = isTrue;
            luxpic4.Visible = isTrue;
        }
        private void lblVisible()
        {
            label1.Visible = true;
            label2.Visible = true;
        }


        private void fampic1_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "family", "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }


        private void fampic2_Click_1(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "family", "2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);

        }

        private void fampic3_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "family", "3.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void fampic4_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "family", "4.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void luxpic1_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "luxurious", "1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void luxpic2_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "luxurious", "2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void luxpic3_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "luxurious", "3.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void luxpic4_Click(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(currentDirectory, "luxurious", "4.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            if (secLevel == "manager")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else if (secLevel == "user")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
            else if (secLevel == "worker") {
                Form4 form4 = new Form4();
                form4.Show();
                this.Close();


            }

        }
    }
}
