namespace görselgame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            dataGridView2 = new DataGridView();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            menuStrip1 = new MenuStrip();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            pictureBox16 = new PictureBox();
            textBox9 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(586, 169);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(673, 425);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(573, 188);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Image = Properties.Resources.delete;
            pictureBox2.Location = new Point(821, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Image = Properties.Resources.loading_arrow;
            pictureBox3.Location = new Point(952, 91);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = Properties.Resources.add;
            pictureBox1.Location = new Point(724, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(606, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 39);
            textBox1.TabIndex = 12;
            textBox1.Text = "oyun ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(734, 31);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 39);
            textBox2.TabIndex = 13;
            textBox2.Text = "oyun adı";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(864, 31);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 39);
            textBox3.TabIndex = 14;
            textBox3.Text = "oyun çıkış yılı";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "kroku", "heyecan", "fps", "yaşam", "eğitim" });
            comboBox1.Location = new Point(995, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 28);
            comboBox1.TabIndex = 15;
            comboBox1.Text = "kategoriler";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1107, 31);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(107, 38);
            textBox4.TabIndex = 16;
            textBox4.Text = "oyun fiyati";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(4, 425);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(653, 188);
            dataGridView2.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 381);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 33);
            textBox5.TabIndex = 21;
            textBox5.Text = "isim";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(366, 381);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(102, 33);
            textBox6.TabIndex = 22;
            textBox6.Text = "soyisim";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(254, 381);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(106, 33);
            textBox7.TabIndex = 23;
            textBox7.Text = "gmail";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(134, 381);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(114, 33);
            textBox8.TabIndex = 24;
            textBox8.Text = "şifre";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ActiveCaptionText;
            pictureBox7.Image = Properties.Resources.file;
            pictureBox7.Location = new Point(921, 314);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(82, 88);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.ActiveCaptionText;
            pictureBox8.Image = Properties.Resources.min;
            pictureBox8.Location = new Point(837, 314);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(78, 88);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 30;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.ActiveCaptionText;
            pictureBox9.Image = Properties.Resources.number_5;
            pictureBox9.Location = new Point(1087, 314);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(80, 84);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = SystemColors.ActiveCaptionText;
            pictureBox10.Image = Properties.Resources.ranking_factor;
            pictureBox10.Location = new Point(1009, 314);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(72, 88);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 32;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = SystemColors.ActiveCaptionText;
            pictureBox11.Image = Properties.Resources.brush;
            pictureBox11.Location = new Point(1159, 314);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(99, 84);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 33;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1246, 28);
            menuStrip1.TabIndex = 45;
            menuStrip1.Text = "menuStrip1";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.BackColor = Color.Red;
            çıkışToolStripMenuItem.ForeColor = Color.White;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(51, 24);
            çıkışToolStripMenuItem.Text = "çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = SystemColors.ActiveCaptionText;
            pictureBox16.Dock = DockStyle.Fill;
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(0, 0);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(1246, 625);
            pictureBox16.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox16.TabIndex = 46;
            pictureBox16.TabStop = false;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(369, 629);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 28;
            textBox9.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(729, 73);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 47;
            label1.Text = "ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(854, 73);
            label2.Name = "label2";
            label2.Size = new Size(29, 23);
            label2.TabIndex = 48;
            label2.Text = "sil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(959, 73);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 49;
            label3.Text = "güncelle";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.Image = Properties.Resources.add;
            pictureBox4.Location = new Point(49, 330);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(53, 304);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 51;
            label4.Text = "ekle";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaptionText;
            pictureBox5.Image = Properties.Resources.delete;
            pictureBox5.Location = new Point(134, 326);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(170, 304);
            label5.Name = "label5";
            label5.Size = new Size(29, 23);
            label5.TabIndex = 53;
            label5.Text = "sil";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveCaptionText;
            pictureBox6.Image = Properties.Resources.loading_arrow;
            pictureBox6.Location = new Point(254, 326);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(90, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 54;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(265, 300);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 55;
            label6.Text = "güncelle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(908, 292);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 56;
            label7.Text = "maksimum";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(832, 399);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 57;
            label8.Text = "minimum";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(1102, 292);
            label9.Name = "label9";
            label9.Size = new Size(46, 23);
            label9.TabIndex = 58;
            label9.Text = "top5";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(988, 399);
            label10.Name = "label10";
            label10.Size = new Size(115, 23);
            label10.TabIndex = 59;
            label10.Text = "artan/azalan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(1173, 399);
            label11.Name = "label11";
            label11.Size = new Size(70, 23);
            label11.TabIndex = 60;
            label11.Text = "temizle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1246, 625);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(dataGridView2);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(pictureBox11);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(pictureBox16);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private DataGridView dataGridView2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private PictureBox pictureBox16;
        private TextBox textBox9;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
