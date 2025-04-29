using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace görselgame
{
    public partial class Form1 : Form
    {
        // 1) İki farklı Access veritabanı bağlantı dizesi
        string baglantiDizesi = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\bin\Debug\oyun.accdb";
        string baglantiDizesiKullanici = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\bin\Debug\kullanıcılar.accdb";

        public Form1()
        {
            InitializeComponent();
        }

 
        // FORM LOAD
   
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Oyun tablosu doldurma
            DataGridViewDoldur();
            ListViewAyarla();
            VerileriListVieweYukle();

            // Kullanıcı tablosu doldurma
            DataGridView2Doldur();

            // Çift tıklama 
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            listView1.DoubleClick += listView1_DoubleClick;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
        }


        // 1) OYUN TABLOSU (ürünanahtarı) DataGridView & ListView
 
        private void DataGridViewDoldur()
        {
            try
            {
                string sorgu = "SELECT [id], [oyun_adi], [oyun_fiyati], [kategoriler], [oyun_cikis_yili] FROM [ürünanahtarı]";
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, baglanti);
                    DataTable tablo = new DataTable();
                    adaptor.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGridView doldurulurken hata oluştu: " + ex.Message);
            }
        }

        private void ListViewAyarla()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Oyun Adı", 150);
            listView1.Columns.Add("Oyun Fiyatı", 100);
            listView1.Columns.Add("Kategoriler", 100);
            listView1.Columns.Add("Oyun Çıkış Yılı", 100);
        }

        private void VerileriListVieweYukle()
        {
            try
            {
                listView1.Items.Clear(); // Mevcut satırları temizle

                string sorgu = "SELECT [id], [oyun_adi], [oyun_fiyati], [kategoriler], [oyun_cikis_yili] FROM [ürünanahtarı]";
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    OleDbDataReader reader = komut.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id"].ToString());
                        item.SubItems.Add(reader["oyun_adi"].ToString());
                        item.SubItems.Add(reader["oyun_fiyati"].ToString());
                        item.SubItems.Add(reader["kategoriler"].ToString());
                        item.SubItems.Add(reader["oyun_cikis_yili"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ListView doldurulurken hata oluştu: " + ex.Message);
            }
        }

      
        // 2) KULLANICI TABLOSU (Tablo1) DataGridView2

        private void DataGridView2Doldur()
        {
            try
            {
                // Access'teki tablo adınız "Tablo1" ve alanlar "id, kullanici_adi, kullanici_soyadi, kullanici_maili, kullanici_sifresi" ise:
                string sorgu = "SELECT [id], [kullanici_adi], [kullanici_soyadi], [kullanici_maili], [kullanici_sifresi] FROM [Tablo1]";

                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesiKullanici))
                {
                    baglanti.Open();
                    OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, baglanti);
                    DataTable tablo = new DataTable();
                    adaptor.Fill(tablo);
                    dataGridView2.DataSource = tablo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("dataGridView2 doldurulurken hata oluştu: " + ex.Message);
            }
        }

        // Çift tıklama ile kullanıcı verilerini textBox’lara aktarma
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // ID'yi ve diğer bilgileri textBox9, textBox5,6,7,8'e atıyoruz.
                textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString();
                textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells["kullanici_adi"].Value.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["kullanici_soyadi"].Value.ToString();
                textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells["kullanici_maili"].Value.ToString();
                textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells["kullanici_sifresi"].Value.ToString();
            }
        }

   
        // 3) OYUN TABLOSU (ürünanahtarı) - SATIR SEÇİMİ
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["oyun_adi"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["oyun_fiyati"].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["kategoriler"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["oyun_cikis_yili"].Value.ToString();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem secilen = listView1.SelectedItems[0];
                textBox1.Text = secilen.SubItems[0].Text; // ID
                textBox2.Text = secilen.SubItems[1].Text; // oyun_adi
                textBox3.Text = secilen.SubItems[2].Text; // oyun_fiyati
                comboBox1.Text = secilen.SubItems[3].Text; // kategoriler
                textBox4.Text = secilen.SubItems[4].Text; // oyun_cikis_yili
            }
        }

        // 4) OYUN TABLOSU (ürünanahtarı) - EKLE / SİL / GÜNCELLE
     
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    string sorgu = @"INSERT INTO [ürünanahtarı]
                                     ([oyun_adi],[oyun_fiyati],[kategoriler],[oyun_cikis_yili])
                                     VALUES (@ad, @fiyat, @kategori, @yil)";

                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", textBox2.Text);

                        double fiyatDegeri;
                        if (!double.TryParse(textBox3.Text, out fiyatDegeri))
                        {
                            MessageBox.Show("Fiyat kısmına geçerli bir sayı giriniz!");
                            return;
                        }
                        komut.Parameters.AddWithValue("@fiyat", fiyatDegeri);

                        komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                        komut.Parameters.AddWithValue("@yil", textBox4.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                            MessageBox.Show("Kayıt başarıyla eklendi.");
                        else
                            MessageBox.Show("Kayıt eklenemedi!");
                    }
                }

                // Yenile
                DataGridViewDoldur();
                VerileriListVieweYukle();

                // Temizle
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Silinecek kaydın ID değerini giriniz.");
                return;
            }

            try
            {
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM [ürünanahtarı] WHERE [id] = @id";
                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", textBox1.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                            MessageBox.Show("Kayıt başarıyla silindi.");
                        else
                            MessageBox.Show("Kayıt silinemedi! ID bulunamadı.");
                    }
                }

                // Yenile
                DataGridViewDoldur();
                VerileriListVieweYukle();

                // Temizle
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Güncellenecek kaydın ID değerini giriniz.");
                return;
            }

            try
            {
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
                {
                    baglanti.Open();
                    string sorgu = @"UPDATE [ürünanahtarı]
                                     SET [oyun_adi] = @ad,
                                         [oyun_fiyati] = @fiyat,
                                         [kategoriler] = @kategori,
                                         [oyun_cikis_yili] = @yil
                                     WHERE [id] = @id";

                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", textBox2.Text);

                        double fiyatDegeri;
                        if (!double.TryParse(textBox3.Text, out fiyatDegeri))
                        {
                            MessageBox.Show("Fiyat kısmına geçerli bir sayı giriniz!");
                            return;
                        }
                        komut.Parameters.AddWithValue("@fiyat", fiyatDegeri);
                        komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                        komut.Parameters.AddWithValue("@yil", textBox4.Text);

                        // ID parametresi
                        komut.Parameters.AddWithValue("@id", textBox1.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                            MessageBox.Show("Kayıt başarıyla güncellendi.");
                        else
                            MessageBox.Show("Kayıt güncellenemedi! ID bulunamadı.");
                    }
                }

                // Yenile
                DataGridViewDoldur();
                VerileriListVieweYukle();

                // Temizle
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        // ========================================================
        // 5) KULLANICI TABLOSU (Tablo1) - EKLE / SİL / GÜNCELLE
        // ========================================================
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            // Ekle
            try
            {
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesiKullanici))
                {
                    baglanti.Open();
                    string sorgu = @"INSERT INTO [Tablo1]
                                     ([kullanici_adi], [kullanici_soyadi], [kullanici_maili], [kullanici_sifresi])
                                     VALUES (@adi, @soyadi, @mail, @sifre)";

                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adi", textBox5.Text);
                        komut.Parameters.AddWithValue("@soyadi", textBox6.Text);
                        komut.Parameters.AddWithValue("@mail", textBox7.Text);
                        komut.Parameters.AddWithValue("@sifre", textBox8.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                            MessageBox.Show("Kullanıcı başarıyla eklendi.");
                        else
                            MessageBox.Show("Kullanıcı eklenemedi!");
                    }
                }

                // Ekleme sonrası tabloyu yenile
                DataGridView2Doldur();

                // TextBox’ları temizle
                textBox9.Clear(); // ID
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı ekleme sırasında hata: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Sil
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Silinecek kaydın ID değerini giriniz veya bir satıra çift tıklayınız.");
                return;
            }

            try
            {
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesiKullanici))
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM [Tablo1] WHERE [id] = @id";
                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", textBox9.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                            MessageBox.Show("Kullanıcı başarıyla silindi.");
                        else
                            MessageBox.Show("Kullanıcı silinemedi! ID bulunamadı.");
                    }
                }

                // Silme sonrası tabloyu yenile
                DataGridView2Doldur();

                // TextBox’ları temizle
                textBox9.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silme sırasında hata: " + ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Güncelle
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                MessageBox.Show("Güncellenecek kaydın ID değerini giriniz veya bir satıra çift tıklayınız.");
                return;
            }

            try
            {
                using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesiKullanici))
                {
                    baglanti.Open();
                    string sorgu = @"UPDATE [Tablo1]
                                     SET [kullanici_adi] = @adi,
                                         [kullanici_soyadi] = @soyadi,
                                         [kullanici_maili] = @mail,
                                         [kullanici_sifresi] = @sifre
                                     WHERE [id] = @id";

                    using (OleDbCommand komut = new OleDbCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@adi", textBox5.Text);
                        komut.Parameters.AddWithValue("@soyadi", textBox6.Text);
                        komut.Parameters.AddWithValue("@mail", textBox7.Text);
                        komut.Parameters.AddWithValue("@sifre", textBox8.Text);

                        // Burada ID değerini eklemeyi unutmayın:
                        komut.Parameters.AddWithValue("@id", textBox9.Text);

                        int etkilenenSatir = komut.ExecuteNonQuery();
                        if (etkilenenSatir > 0)
                            MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                        else
                            MessageBox.Show("Kullanıcı güncellenemedi! ID bulunamadı.");
                    }
                }

                // Güncelleme sonrası tabloyu yenile
                DataGridView2Doldur();

                // TextBox’ları temizle
                textBox9.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncelleme sırasında hata: " + ex.Message);
            }
        }

        // -------------------------------------------------------
        // Formu Kapatma Butonu (opsiyonel)
        // -------------------------------------------------------

        private void FiltreliDoldur(string sorgu)
        {
            // 1) DataGridView1 doldur
            using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
            {
                baglanti.Open();
                OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }

            // 2) ListView1 doldur
            listView1.Items.Clear();  // Mevcut satırları temizleyelim
            using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesi))
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    // id, oyun_adi, oyun_fiyati, kategoriler, oyun_cikis_yili
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["oyun_adi"].ToString());
                    item.SubItems.Add(reader["oyun_fiyati"].ToString());
                    item.SubItems.Add(reader["kategoriler"].ToString());
                    item.SubItems.Add(reader["oyun_cikis_yili"].ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // 1) Maksimum fiyatı bulmak için sorgu
            string sorgu1 = @"
        SELECT *
        FROM [ürünanahtarı]
        WHERE [oyun_fiyati] = (SELECT MAX([oyun_fiyati]) FROM [ürünanahtarı])
    ";
            FiltreliDoldur(sorgu1);

            // 2) En çok kayıtlı kullanıcı adını bulmak için sorgu
            string sorgu2 = @"
        SELECT *
        FROM [Tablo1]
        WHERE [kullanici_adi] IN 
        (
          SELECT TOP 1 [kullanici_adi]
          FROM [Tablo1]
          GROUP BY [kullanici_adi]
          ORDER BY COUNT(*) DESC
        )
    ";
            FiltreliDoldurKullanici(sorgu2);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        { // 1) Minimum fiyatı bul (ürünanahtarı tablosu)
            string sorgu1 = @"
        SELECT *
        FROM [ürünanahtarı]
        WHERE [oyun_fiyati] = (SELECT MIN([oyun_fiyati]) FROM [ürünanahtarı])
    ";
            FiltreliDoldur(sorgu1);

            // 2) En az kayıtlı kullanıcı adını bul (Tablo1)
            // NOT: Burada ASC sıralama kullanılmış, yani en düşük tekrar eden kullanıcıyı getirir.
            string sorgu2 = @"
        SELECT *
        FROM [Tablo1]
        WHERE [kullanici_adi] IN 
        (
          SELECT TOP 1 [kullanici_adi]
          FROM [Tablo1]
          GROUP BY [kullanici_adi]
          ORDER BY COUNT(*) ASC
        )
    ";
            FiltreliDoldurKullanici(sorgu2);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // 1) En pahalı 5 oyunu getir (ürünanahtarı tablosu)
            string sorgu1 = @"
        SELECT TOP 5 *
        FROM [ürünanahtarı]
        ORDER BY [oyun_fiyati] DESC
    ";
            FiltreliDoldur(sorgu1);

            // 2) En çok kayıtlı kullanıcıları getir (Tablo1)
            string sorgu2 = @"
        SELECT TOP 5 [kullanici_adi], COUNT(*) AS [TekrarSayisi]
        FROM [Tablo1]
        GROUP BY [kullanici_adi]
        ORDER BY COUNT(*) DESC
    ";
            FiltreliDoldurKullanici(sorgu2);  // Bu metot DataGridView2 gibi bir kontrolü dolduruyor.
        }


        bool siralamaArtan = true;
        bool siralamaArtanKullanici = true;
        private void pictureBox10_Click(object sender, EventArgs e)
        { // Ürün tablosu için sıralama
            string sorguUrun;
            if (siralamaArtan)
            {
                // Artan (ASC) sıralama
                sorguUrun = @"
            SELECT *
            FROM [ürünanahtarı]
            ORDER BY [oyun_fiyati] ASC
        ";
                // Sonraki sefer için azalan yap
                siralamaArtan = false;
            }
            else
            {
                // Azalan (DESC) sıralama
                sorguUrun = @"
            SELECT *
            FROM [ürünanahtarı]
            ORDER BY [oyun_fiyati] DESC
        ";
                // Sonraki sefer için artan yap
                siralamaArtan = true;
            }
            FiltreliDoldur(sorguUrun);

            // Kullanıcı tablosu için sıralama
            string sorguKullanici;
            if (siralamaArtanKullanici)
            {
                // A'dan Z'ye sıralama
                sorguKullanici = "SELECT * FROM [Tablo1] ORDER BY [kullanici_adi] ASC";
                siralamaArtanKullanici = false;
            }
            else
            {
                // Z'den A'ya sıralama
                sorguKullanici = "SELECT * FROM [Tablo1] ORDER BY [kullanici_adi] DESC";
                siralamaArtanKullanici = true;
            }
            FiltreliDoldurKullanici(sorguKullanici);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Tüm kayıtlar (orijinal)
            DataGridViewDoldur();
            VerileriListVieweYukle();
            DataGridView2Doldur();
        }
        private void FiltreliDoldurKullanici(string sorgu)
        {
            using (OleDbConnection baglanti = new OleDbConnection(baglantiDizesiKullanici))
            {
                baglanti.Open();
                OleDbDataAdapter adaptor = new OleDbDataAdapter(sorgu, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridView2.DataSource = tablo;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
