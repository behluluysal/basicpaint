namespace NDPProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RenkSecim = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.silme = new System.Windows.Forms.PictureBox();
            this.resimsecme = new System.Windows.Forms.PictureBox();
            this.AltigenSecim = new System.Windows.Forms.PictureBox();
            this.ÜcgenSecim = new System.Windows.Forms.PictureBox();
            this.DaireSecim = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cizim = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RenkSecim)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimsecme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltigenSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ÜcgenSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaireSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cizim)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.çıkışToolStripMenuItem.Text = "Aç";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(130, 26);
            this.çıkışToolStripMenuItem1.Text = "Yenile";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // RenkSecim
            // 
            this.RenkSecim.Image = ((System.Drawing.Image)(resources.GetObject("RenkSecim.Image")));
            this.RenkSecim.Location = new System.Drawing.Point(534, 3);
            this.RenkSecim.Name = "RenkSecim";
            this.RenkSecim.Size = new System.Drawing.Size(119, 119);
            this.RenkSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RenkSecim.TabIndex = 1;
            this.RenkSecim.TabStop = false;
            this.RenkSecim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.RenkSecim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.RenkSecim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.silme);
            this.panel1.Controls.Add(this.resimsecme);
            this.panel1.Controls.Add(this.AltigenSecim);
            this.panel1.Controls.Add(this.ÜcgenSecim);
            this.panel1.Controls.Add(this.DaireSecim);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.RenkSecim);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 122);
            this.panel1.TabIndex = 2;
            // 
            // silme
            // 
            this.silme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.silme.Image = ((System.Drawing.Image)(resources.GetObject("silme.Image")));
            this.silme.Location = new System.Drawing.Point(162, 59);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(176, 50);
            this.silme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.silme.TabIndex = 8;
            this.silme.TabStop = false;
            this.silme.Click += new System.EventHandler(this.silme_Click);
            // 
            // resimsecme
            // 
            this.resimsecme.Image = ((System.Drawing.Image)(resources.GetObject("resimsecme.Image")));
            this.resimsecme.Location = new System.Drawing.Point(162, 3);
            this.resimsecme.Name = "resimsecme";
            this.resimsecme.Size = new System.Drawing.Size(176, 50);
            this.resimsecme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimsecme.TabIndex = 7;
            this.resimsecme.TabStop = false;
            this.resimsecme.Click += new System.EventHandler(this.resimsecme_Click_1);
            // 
            // AltigenSecim
            // 
            this.AltigenSecim.Image = ((System.Drawing.Image)(resources.GetObject("AltigenSecim.Image")));
            this.AltigenSecim.Location = new System.Drawing.Point(60, 63);
            this.AltigenSecim.Name = "AltigenSecim";
            this.AltigenSecim.Size = new System.Drawing.Size(51, 55);
            this.AltigenSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AltigenSecim.TabIndex = 6;
            this.AltigenSecim.TabStop = false;
            this.AltigenSecim.Click += new System.EventHandler(this.AltigenSecim_Click);
            // 
            // ÜcgenSecim
            // 
            this.ÜcgenSecim.Image = ((System.Drawing.Image)(resources.GetObject("ÜcgenSecim.Image")));
            this.ÜcgenSecim.Location = new System.Drawing.Point(3, 63);
            this.ÜcgenSecim.Name = "ÜcgenSecim";
            this.ÜcgenSecim.Size = new System.Drawing.Size(51, 55);
            this.ÜcgenSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ÜcgenSecim.TabIndex = 5;
            this.ÜcgenSecim.TabStop = false;
            this.ÜcgenSecim.Click += new System.EventHandler(this.ÜcgenSecim_Click);
            // 
            // DaireSecim
            // 
            this.DaireSecim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DaireSecim.BackgroundImage")));
            this.DaireSecim.Location = new System.Drawing.Point(60, 3);
            this.DaireSecim.Name = "DaireSecim";
            this.DaireSecim.Size = new System.Drawing.Size(51, 55);
            this.DaireSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DaireSecim.TabIndex = 4;
            this.DaireSecim.TabStop = false;
            this.DaireSecim.Click += new System.EventHandler(this.DaireSecim_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 55);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(408, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // cizim
            // 
            this.cizim.BackColor = System.Drawing.Color.Transparent;
            this.cizim.Location = new System.Drawing.Point(0, 161);
            this.cizim.Name = "cizim";
            this.cizim.Size = new System.Drawing.Size(996, 616);
            this.cizim.TabIndex = 3;
            this.cizim.TabStop = false;
            this.cizim.Click += new System.EventHandler(this.cizim_Click);
            this.cizim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cizim_MouseDown);
            this.cizim.MouseLeave += new System.EventHandler(this.cizim_MouseLeave);
            this.cizim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cizim_MouseMove);
            this.cizim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cizim_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 779);
            this.Controls.Add(this.cizim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RenkSecim)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.silme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimsecme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltigenSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ÜcgenSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaireSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cizim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.PictureBox RenkSecim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox cizim;
        private System.Windows.Forms.PictureBox AltigenSecim;
        private System.Windows.Forms.PictureBox ÜcgenSecim;
        private System.Windows.Forms.PictureBox DaireSecim;
        private System.Windows.Forms.PictureBox silme;
        private System.Windows.Forms.PictureBox resimsecme;
    }
}

