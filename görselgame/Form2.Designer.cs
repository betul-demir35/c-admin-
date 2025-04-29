namespace görselgame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(620, 213);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(620, 270);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 53);
            textBox2.TabIndex = 1;
            textBox2.Text = "şifre";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Plum;
            linkLabel1.BorderStyle = BorderStyle.FixedSingle;
            linkLabel1.Font = new Font("Yu Gothic Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(789, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(158, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "şifremi unuttum";
            linkLabel1.VisitedLinkColor = Color.FromArgb(255, 128, 255);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Click += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Plum;
            linkLabel2.BorderStyle = BorderStyle.FixedSingle;
            linkLabel2.Font = new Font("Yu Gothic Medium", 10.8F, FontStyle.Bold);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(798, 384);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(67, 25);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "üye ol";
            linkLabel2.VisitedLinkColor = Color.FromArgb(255, 128, 255);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Cyan;
            checkBox1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(642, 329);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 26);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "beni hatırla";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(655, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 30);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.indir;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(959, 509);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaptionText;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { çıkışToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(959, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.BackColor = Color.Red;
            çıkışToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(51, 24);
            çıkışToolStripMenuItem.Text = "çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(681, 364);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 9;
            label1.Text = "giriş";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 509);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private Label label1;
    }
}