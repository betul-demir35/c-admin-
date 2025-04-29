using System;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace görselgame
{
    public partial class Form3 : Form
    {
        private string verificationCode; // Doğrulama kodu saklanacak
        private bool isVerified = false; // Kullanıcının doğrulama yapıp yapmadığını kontrol edecek

        string baglantiDizesiKullanici = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\bin\Debug\kullanıcılar.accdb";

        public Form3()
        {
            InitializeComponent();
            textBox4.Visible = false; // Şifre alanı başta gizli
        }

        //  Doğrulama kodu oluşturma (isim + soyisim + 2025)
        private string GenerateVerificationCode(string isim, string soyisim)
        {
            string first3 = isim.Length >= 3 ? isim.Substring(0, 3) : isim; // İsmin ilk 3 harfi
            string last2 = soyisim.Length >= 2 ? soyisim.Substring(soyisim.Length - 2) : soyisim; // Soyismin son 2 harfi
            return first3 + last2 + "2025"; // Örn: "Ahmzi2025"
        }

        //  Doğrulama kodu gönderen fonksiyon
        private void SendVerificationCode(string email, string isim, string soyisim)
        {
            verificationCode = GenerateVerificationCode(isim, soyisim); // Kodu oluştur

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"); // Gmail kullanıyorsan

                mail.From = new MailAddress("sumeyyebdemir@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Doğrulama Kodu";
                mail.Body = "Doğrulama Kodunuz: " + verificationCode;

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("sumeyyebdemir@gmail.com", "ftie rzpu fkgp xfgd");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                MessageBox.Show("Doğrulama kodu e-posta adresinize gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme hatası: " + ex.Message);
            }
        }

        //  doğrulama başlatılır veya kayıt yapılır
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!isVerified) // Eğer doğrulama yapılmadıysa önce doğrulama işlemi başlat
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Lütfen isim, soyisim ve e-posta adresinizi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SendVerificationCode(textBox3.Text, textBox1.Text, textBox2.Text); // Mail gönder
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Doğrulama Kodunu Girin:", "Kod Onayı", "", -1, -1);

                if (userInput == verificationCode)
                {
                    MessageBox.Show("Doğrulama başarılı! Şifre alanı açıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox4.Visible = true; // Şifre alanını aç
                    isVerified = true; // Kullanıcı doğrulandı
                }
                else
                {
                    MessageBox.Show("Yanlış kod girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Eğer doğrulama zaten yapıldıysa, bilgileri Access'e kaydet
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Lütfen önce şifrenizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(baglantiDizesiKullanici))
                {
                    conn.Open();
                    string query = "INSERT INTO Tablo1 ([kullanici_adi], [kullanici_soyadi], [kullanici_maili], [kullanici_sifresi]) VALUES (@isim, @soyisim, @email, @sifre)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@isim", OleDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@soyisim", OleDbType.VarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@email", OleDbType.VarChar).Value = textBox3.Text;
                        cmd.Parameters.Add("@sifre", OleDbType.VarChar).Value = textBox4.Text; // Şifre artık metin olarak kaydedilecek

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void üyeGirişineDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
