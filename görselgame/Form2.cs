using System;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
// Interaction InputBox kullanmak için
using Microsoft.VisualBasic;

namespace görselgame
{
    public partial class Form2 : Form
    {
        // Access veritabanı bağlantı dizesi (kendi yolunuza göre güncelleyin)
        private string baglantiDizesiKullanici =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\bin\Debug\kullanıcılar.accdb";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Settings üzerinden kaydedilmiş bilgileri kontrol et.
            if (Properties.Settings.Default.RememberMe)
            {
                textBox1.Text = Properties.Settings.Default.UserMail;
                textBox2.Text = Properties.Settings.Default.UserPassword;
                checkBox1.Checked = true;
            }
        }

        // Giriş için tıklanacak PictureBox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // textBox1 = mail, textBox2 = şifre
            GirisYap(textBox1.Text.Trim(), textBox2.Text.Trim());
        }




        /// <summary>
        /// Giriş Yapma Metodu
        /// </summary>
        /// <param name="mail">Kullanıcının girdiği mail (textBox1)</param>
        /// <param name="sifre">Kullanıcının girdiği şifre (textBox2)</param>
        private void GirisYap(string mail, string sifre)
        {
            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen mail ve şifre alanlarını doldurunuz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection con = new OleDbConnection(baglantiDizesiKullanici))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Tablo1 WHERE kullanici_maili=@mail";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@mail", mail);
                        int count = (int)cmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Kayıt bulunamadı. Lütfen yeni kayıt yapın.",
                                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            string querySifre = "SELECT kullanici_sifresi FROM Tablo1 WHERE kullanici_maili=@mail2";
                            using (OleDbCommand cmdSifre = new OleDbCommand(querySifre, con))
                            {
                                cmdSifre.Parameters.AddWithValue("@mail2", mail);
                                string dbSifre = (string)cmdSifre.ExecuteScalar();

                                if (dbSifre == sifre)
                                {
                                    MessageBox.Show("Giriş başarılı!", "Başarılı",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Beni Hatırla seçili ise ayarları kaydet, değilse temizle
                                    if (checkBox1.Checked)
                                    {
                                        Properties.Settings.Default.UserMail = mail;
                                        Properties.Settings.Default.UserPassword = sifre;
                                        Properties.Settings.Default.RememberMe = true;
                                        Properties.Settings.Default.Save();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.UserMail = "";
                                        Properties.Settings.Default.UserPassword = "";
                                        Properties.Settings.Default.RememberMe = false;
                                        Properties.Settings.Default.Save();
                                    }

                                    // **Form1'i aç ve Form2'yi kapat**
                                    Form1 form1 = new Form1();
                                    form1.Show();
                                    this.Hide(); // Form2'yi gizler
                                }
                                else
                                {
                                    MessageBox.Show("Şifre veya maili yanlış girdiniz!", "Hata",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }


        /// Şifremi Unuttum Akışı

        private void SifremiUnuttum()
        {
            // 1) Kullanıcıdan mailini girmesini isteyin
            string girilenMail = Interaction.InputBox(
                "Lütfen mail adresinizi girin:",
                "Şifremi Unuttum",
                ""
            );

            if (string.IsNullOrEmpty(girilenMail))
            {
                MessageBox.Show("Mail adresi boş olamaz.");
                return;
            }

            
            bool mailVarMi = false;
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglantiDizesiKullanici))
                {
                    con.Open();
                    string query =
                        "SELECT COUNT(*) FROM Tablo1 WHERE kullanici_maili=@mail";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@mail", girilenMail);
                        int count = (int)cmd.ExecuteScalar();
                        mailVarMi = (count > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                return;
            }

            if (!mailVarMi)
            {
                MessageBox.Show("Bu mail adresiyle kayıt bulunamadı!");
                return;
            }

            // 3) 5 haneli rastgele kod oluştur ve mail gönder
            string dogrulamaKodu = RastgeleKodOlustur(5);

            try
            {
                // Örnek: Gmail SMTP
                using (MailMessage mesaj = new MailMessage())
                {
                    mesaj.From = new MailAddress("sumeyyebdemir@gmail.com"); // Kendi mailiniz
                    mesaj.To.Add(girilenMail);
                    mesaj.Subject = "Şifre Sıfırlama Kodu";
                    mesaj.Body = "Şifre sıfırlama kodunuz: " + dogrulamaKodu;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("sumeyyebdemir@gmail.com", "ftie rzpu fkgp xfgd");
                        smtp.EnableSsl = true;
                        smtp.Send(mesaj);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderim hatası: " + ex.Message);
                return;
            }

            // 4) Kullanıcıdan kodu iste
            string kullaniciKodu = Interaction.InputBox(
                "Mailinize gelen 5 haneli kodu girin:",
                "Kod Doğrulama",
                ""
            );

            if (kullaniciKodu == dogrulamaKodu)
            {
                // Kod doğru -> Yeni şifre al
                string yeniSifre = Interaction.InputBox(
                    "Yeni şifrenizi girin:",
                    "Yeni Şifre",
                    ""
                );

                if (!string.IsNullOrEmpty(yeniSifre))
                {
                    // 5) Veritabanında güncelle
                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(baglantiDizesiKullanici))
                        {
                            con.Open();
                            string updateQuery =
                                "UPDATE Tablo1 SET kullanici_sifresi=@yeniSifre WHERE kullanici_maili=@mail";
                            using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@yeniSifre", yeniSifre);
                                cmd.Parameters.AddWithValue("@mail", girilenMail);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Şifreniz başarıyla güncellendi!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Şifre güncelleme hatası: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Yeni şifre boş olamaz!");
                }
            }
            else
            {
                MessageBox.Show("Girilen kod hatalı!");
            }
        }

        /// <summary>
        /// 5 haneli rastgele sayı kodu üreten basit metod
        /// </summary>
        private string RastgeleKodOlustur(int uzunluk)
        {
            Random rnd = new Random();
            string kod = "";
            for (int i = 0; i < uzunluk; i++)
            {
                kod += rnd.Next(0, 10).ToString();
            }
            return kod;
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            SifremiUnuttum();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
