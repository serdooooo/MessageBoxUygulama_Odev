using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace kurs_08122021_86_MessageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int islemSonuc;
        private void BtnYeniKayit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIsim.Text) || string.IsNullOrWhiteSpace(TxtSoyisim.Text) || string.IsNullOrWhiteSpace(TxtEmailAdres.Text) || string.IsNullOrWhiteSpace(TxtTelefonNo.Text))
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz.");
                EkranTemizle();
            }
            else
            {

                islemSonuc = yeniMusteriEkle(new Musteri()
                {
                    ID = Guid.NewGuid(),
                    Isim = TxtIsim.Text,
                    Soyisim = TxtSoyisim.Text,
                    EmailAdres = TxtEmailAdres.Text,
                    TelefonNumarasi = TxtTelefonNo.Text
                });
            }

            if (islemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme işlemi başarılı, yeni müşteri kaydı eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    BildirimCubugu = new NotifyIcon();
                    BildirimCubugu.BalloonTipText = "Toplam müşteri kayıt adedi : " + SanalDataBase.musteriler.Count.ToString();
                    BildirimCubugu.BalloonTipTitle = "Müşteri adet bilgisi";
                    BildirimCubugu.Visible = true;
                    BildirimCubugu.Icon = SystemIcons.Information;
                    BildirimCubugu.ShowBalloonTip(2000);
                    EkranTemizle();
                }
                else if (res==DialogResult.No)
                {
                    EkranTemizle();
                    EkranListele();
                }
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işlemi yapılamadı");
            }
        }

        private void EkranListele()
        {
            LstMusteriler.Items.Clear();
            foreach (var item in SanalDataBase.musteriler)
            {
                LstMusteriler.Items.Add(item);

            }
           
           
        }

        private void EkranTemizle()
        {
            TxtEmailAdres.Clear();
            TxtIsim.Clear();
            TxtSoyisim.Clear();
            TxtTelefonNo.Clear();
        }

        private int yeniMusteriEkle(Musteri data)
        {
            SanalDataBase.musteriler.Add(data);
            return 1;
        }
        
    }
}
