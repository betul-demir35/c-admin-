using System.Media;

namespace görselgame
{
    public partial class Form4 : Form
    {
        private System.Windows.Forms.Timer timer;
        private SoundPlayer player;  

        public Form4()
        {
            InitializeComponent();
            player = new SoundPlayer(@"C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\ne.wav");

            PlaySound(); 

            
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(690, 485);
            this.BackColor = Color.White;

            
            PictureBox loadingGif = new PictureBox
            {
                Size = new Size(690, 485),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            try
            {
                loadingGif.Image = Image.FromFile(@"C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\ne.gif");
            }
            catch (Exception ex)
            {
                MessageBox.Show("GIF yüklenirken hata oluştu: " + ex.Message);
            }

            this.Controls.Add(loadingGif);

            timer = new System.Windows.Forms.Timer
            {
                Interval = 3500 
            };

            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            };
            timer.Start();
        }

        private void PlaySound()
        {
            try
            {
                string soundPath = @"C:\Users\EXCALİBUR\Desktop\ödevler\görselgame\görselgame\ne.wav";

                if (!System.IO.File.Exists(soundPath))
                {
                    MessageBox.Show("Ses dosyası bulunamadı! Yol: " + soundPath);
                    return;
                }

                player.SoundLocation = soundPath;
                player.Load(); 
                player.Play(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses çalınırken hata oluştu: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
