
namespace Apartman
{
    partial class FormAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.Kayit = new System.Windows.Forms.Button();
            this.Bilanco = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.apartmanTableAdapter1 = new Apartman.ApartmanDataSetTableAdapters.ApartmanTableAdapter();
            this.SifreDegistir = new System.Windows.Forms.Button();
            this.SifreDbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Kayit
            // 
            this.Kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Kayit.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit.Image = global::Apartman.Properties.Resources.kayit_ana;
            this.Kayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kayit.Location = new System.Drawing.Point(46, 12);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(356, 110);
            this.Kayit.TabIndex = 4;
            this.Kayit.Text = "Kayıt İşlemleri";
            this.Kayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Kayit.UseVisualStyleBackColor = false;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // Bilanco
            // 
            this.Bilanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bilanco.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bilanco.Image = global::Apartman.Properties.Resources.bilanco_ana;
            this.Bilanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bilanco.Location = new System.Drawing.Point(46, 148);
            this.Bilanco.Name = "Bilanco";
            this.Bilanco.Size = new System.Drawing.Size(356, 110);
            this.Bilanco.TabIndex = 5;
            this.Bilanco.Text = "Bilanço";
            this.Bilanco.UseVisualStyleBackColor = false;
            this.Bilanco.Click += new System.EventHandler(this.Bilanco_Click);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cikis.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis.Image = global::Apartman.Properties.Resources.cikis;
            this.Cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikis.Location = new System.Drawing.Point(46, 289);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(356, 110);
            this.Cikis.TabIndex = 6;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // apartmanTableAdapter1
            // 
            this.apartmanTableAdapter1.ClearBeforeFill = true;
            // 
            // SifreDegistir
            // 
            this.SifreDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SifreDegistir.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreDegistir.Image = global::Apartman.Properties.Resources.sifre_degistir;
            this.SifreDegistir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SifreDegistir.Location = new System.Drawing.Point(437, 12);
            this.SifreDegistir.Name = "SifreDegistir";
            this.SifreDegistir.Size = new System.Drawing.Size(356, 110);
            this.SifreDegistir.TabIndex = 7;
            this.SifreDegistir.Text = "Şifre Değiştir";
            this.SifreDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SifreDegistir.UseVisualStyleBackColor = false;
            this.SifreDegistir.Click += new System.EventHandler(this.button1_Click);
            // 
            // SifreDbox
            // 
            this.SifreDbox.Location = new System.Drawing.Point(437, 148);
            this.SifreDbox.Name = "SifreDbox";
            this.SifreDbox.Size = new System.Drawing.Size(356, 22);
            this.SifreDbox.TabIndex = 8;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Apartman.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 748);
            this.Controls.Add(this.SifreDbox);
            this.Controls.Add(this.SifreDegistir);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.Bilanco);
            this.Controls.Add(this.Kayit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAna";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.Button Bilanco;
        private System.Windows.Forms.Button Cikis;
        private ApartmanDataSetTableAdapters.ApartmanTableAdapter apartmanTableAdapter1;
        private System.Windows.Forms.Button SifreDegistir;
        private System.Windows.Forms.TextBox SifreDbox;
    }
}