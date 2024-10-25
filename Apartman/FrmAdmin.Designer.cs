
namespace Apartman
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreUnutum = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apartman.Properties.Resources.Adsız_4;
            this.pictureBox1.Location = new System.Drawing.Point(324, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Location = new System.Drawing.Point(324, 225);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(376, 22);
            this.KullaniciAdi.TabIndex = 9;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(324, 335);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(376, 22);
            this.Sifre.TabIndex = 10;
            this.Sifre.TextChanged += new System.EventHandler(this.Sifre_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::Apartman.Properties.Resources._152533;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(324, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 74);
            this.button1.TabIndex = 11;
            this.button1.Text = "Giriş Yap";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(119, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // SifreUnutum
            // 
            this.SifreUnutum.BackColor = System.Drawing.Color.Red;
            this.SifreUnutum.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreUnutum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SifreUnutum.Location = new System.Drawing.Point(324, 482);
            this.SifreUnutum.Name = "SifreUnutum";
            this.SifreUnutum.Size = new System.Drawing.Size(252, 39);
            this.SifreUnutum.TabIndex = 15;
            this.SifreUnutum.Text = "Şifremi Unuttum";
            this.SifreUnutum.UseVisualStyleBackColor = false;
            this.SifreUnutum.Click += new System.EventHandler(this.SifreUnutum_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cikis.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis.Image = global::Apartman.Properties.Resources.cikis;
            this.Cikis.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cikis.Location = new System.Drawing.Point(582, 402);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(131, 119);
            this.Cikis.TabIndex = 16;
            this.Cikis.Text = "Çıkış";
            this.Cikis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Apartman.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.SifreUnutum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.Text = "Giriş Alanı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox KullaniciAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SifreUnutum;
        private System.Windows.Forms.Button Cikis;
    }
}

