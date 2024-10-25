
namespace Apartman
{
    partial class bilanco
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilanco));
            this.bilancoView = new System.Windows.Forms.ListView();
            this.YılAy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aidat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Su = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Elektrik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SGK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temizlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bakim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kapici = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Muhasebe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aidatTot = new System.Windows.Forms.Label();
            this.suTot = new System.Windows.Forms.Label();
            this.elektrikTot = new System.Windows.Forms.Label();
            this.sgkTot = new System.Windows.Forms.Label();
            this.totBilancoLabel = new System.Windows.Forms.Label();
            this.totBilanco = new System.Windows.Forms.Label();
            this.harcamaList = new System.Windows.Forms.ListBox();
            this.harcamaTextBox = new System.Windows.Forms.TextBox();
            this.harcamaButton = new System.Windows.Forms.Button();
            this.monthList = new System.Windows.Forms.ListBox();
            this.Cikis = new System.Windows.Forms.Button();
            this.Kayit = new System.Windows.Forms.Button();
            this.temizlikTot = new System.Windows.Forms.Label();
            this.bakimTot = new System.Windows.Forms.Label();
            this.kapiciTot = new System.Windows.Forms.Label();
            this.muhasebeTot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Button();
            this.bilancoPNG = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bilancoPNG)).BeginInit();
            this.SuspendLayout();
            // 
            // bilancoView
            // 
            this.bilancoView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.bilancoView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.YılAy,
            this.aidat,
            this.Su,
            this.Elektrik,
            this.SGK,
            this.Temizlik,
            this.Bakim,
            this.Kapici,
            this.Muhasebe});
            this.bilancoView.Cursor = System.Windows.Forms.Cursors.Default;
            this.bilancoView.Enabled = false;
            this.bilancoView.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilancoView.GridLines = true;
            this.bilancoView.HideSelection = false;
            this.bilancoView.Location = new System.Drawing.Point(43, 197);
            this.bilancoView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bilancoView.Name = "bilancoView";
            this.bilancoView.Size = new System.Drawing.Size(1000, 275);
            this.bilancoView.TabIndex = 1;
            this.toolTip1.SetToolTip(this.bilancoView, "Güncellemek için sağ taraftan önce ilgili Ayı ve Giderlerden birini seçiniz.\r\nGün" +
        "cel değeri yazıp Harcama Ekle-Güncelle butonuna tıkladığınız zaman gerekli günce" +
        "lleme yapılacaktır.");
            this.bilancoView.UseCompatibleStateImageBehavior = false;
            this.bilancoView.View = System.Windows.Forms.View.Details;
            // 
            // YılAy
            // 
            this.YılAy.Text = "Yıl/Ay";
            this.YılAy.Width = 110;
            // 
            // aidat
            // 
            this.aidat.Text = "Aidat";
            this.aidat.Width = 110;
            // 
            // Su
            // 
            this.Su.Text = "Su";
            this.Su.Width = 110;
            // 
            // Elektrik
            // 
            this.Elektrik.Text = "Elektrik";
            this.Elektrik.Width = 110;
            // 
            // SGK
            // 
            this.SGK.Text = "SGK Ücreti";
            this.SGK.Width = 110;
            // 
            // Temizlik
            // 
            this.Temizlik.Text = "Temizlik Malz.";
            this.Temizlik.Width = 110;
            // 
            // Bakim
            // 
            this.Bakim.Text = "Bakım-Onarım";
            this.Bakim.Width = 110;
            // 
            // Kapici
            // 
            this.Kapici.Text = "Kapıcı Ücreti";
            this.Kapici.Width = 110;
            // 
            // Muhasebe
            // 
            this.Muhasebe.Text = "Muhasebe";
            this.Muhasebe.Width = 110;
            // 
            // aidatTot
            // 
            this.aidatTot.AutoSize = true;
            this.aidatTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aidatTot.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aidatTot.ForeColor = System.Drawing.Color.LawnGreen;
            this.aidatTot.Location = new System.Drawing.Point(156, 474);
            this.aidatTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aidatTot.Name = "aidatTot";
            this.aidatTot.Size = new System.Drawing.Size(24, 33);
            this.aidatTot.TabIndex = 3;
            this.aidatTot.Text = "-";
            // 
            // suTot
            // 
            this.suTot.AutoSize = true;
            this.suTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.suTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suTot.Location = new System.Drawing.Point(262, 474);
            this.suTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.suTot.Name = "suTot";
            this.suTot.Size = new System.Drawing.Size(17, 24);
            this.suTot.TabIndex = 4;
            this.suTot.Text = "-";
            // 
            // elektrikTot
            // 
            this.elektrikTot.AutoSize = true;
            this.elektrikTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elektrikTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elektrikTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elektrikTot.Location = new System.Drawing.Point(371, 474);
            this.elektrikTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.elektrikTot.Name = "elektrikTot";
            this.elektrikTot.Size = new System.Drawing.Size(17, 24);
            this.elektrikTot.TabIndex = 5;
            this.elektrikTot.Text = "-";
            // 
            // sgkTot
            // 
            this.sgkTot.AutoSize = true;
            this.sgkTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sgkTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sgkTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sgkTot.Location = new System.Drawing.Point(484, 474);
            this.sgkTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sgkTot.Name = "sgkTot";
            this.sgkTot.Size = new System.Drawing.Size(17, 24);
            this.sgkTot.TabIndex = 6;
            this.sgkTot.Text = "-";
            // 
            // totBilancoLabel
            // 
            this.totBilancoLabel.AutoSize = true;
            this.totBilancoLabel.BackColor = System.Drawing.Color.Red;
            this.totBilancoLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totBilancoLabel.ForeColor = System.Drawing.Color.White;
            this.totBilancoLabel.Location = new System.Drawing.Point(1052, 442);
            this.totBilancoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totBilancoLabel.Name = "totBilancoLabel";
            this.totBilancoLabel.Size = new System.Drawing.Size(75, 28);
            this.totBilancoLabel.TabIndex = 7;
            this.totBilancoLabel.Text = "KASA";
            // 
            // totBilanco
            // 
            this.totBilanco.AutoSize = true;
            this.totBilanco.BackColor = System.Drawing.Color.Red;
            this.totBilanco.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totBilanco.ForeColor = System.Drawing.Color.White;
            this.totBilanco.Location = new System.Drawing.Point(1054, 472);
            this.totBilanco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totBilanco.Name = "totBilanco";
            this.totBilanco.Size = new System.Drawing.Size(25, 35);
            this.totBilanco.TabIndex = 8;
            this.totBilanco.Text = "-";
            // 
            // harcamaList
            // 
            this.harcamaList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harcamaList.FormattingEnabled = true;
            this.harcamaList.ItemHeight = 24;
            this.harcamaList.Items.AddRange(new object[] {
            "Su",
            "Elektrik",
            "SGK",
            "Temizlik",
            "Bakım",
            "Kapıcı",
            "Muhasebe"});
            this.harcamaList.Location = new System.Drawing.Point(1362, 197);
            this.harcamaList.Margin = new System.Windows.Forms.Padding(5);
            this.harcamaList.Name = "harcamaList";
            this.harcamaList.Size = new System.Drawing.Size(113, 172);
            this.harcamaList.TabIndex = 37;
            // 
            // harcamaTextBox
            // 
            this.harcamaTextBox.Location = new System.Drawing.Point(1220, 416);
            this.harcamaTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.harcamaTextBox.Name = "harcamaTextBox";
            this.harcamaTextBox.Size = new System.Drawing.Size(129, 27);
            this.harcamaTextBox.TabIndex = 38;
            this.harcamaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harcamaTextBox_KeyPress);
            // 
            // harcamaButton
            // 
            this.harcamaButton.BackColor = System.Drawing.Color.Yellow;
            this.harcamaButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harcamaButton.Location = new System.Drawing.Point(1220, 448);
            this.harcamaButton.Margin = new System.Windows.Forms.Padding(5);
            this.harcamaButton.Name = "harcamaButton";
            this.harcamaButton.Size = new System.Drawing.Size(223, 33);
            this.harcamaButton.TabIndex = 40;
            this.harcamaButton.Text = "Harcama Ekle - Güncelle";
            this.harcamaButton.UseVisualStyleBackColor = false;
            this.harcamaButton.Click += new System.EventHandler(this.harcamaButton_Click);
            // 
            // monthList
            // 
            this.monthList.FormattingEnabled = true;
            this.monthList.ItemHeight = 19;
            this.monthList.Items.AddRange(new object[] {
            "1.Ay",
            "2.Ay",
            "3.Ay",
            "4.Ay",
            "5.Ay",
            "6.Ay",
            "7.Ay",
            "8.Ay",
            "9.Ay",
            "10.Ay",
            "11.Ay",
            "12.Ay"});
            this.monthList.Location = new System.Drawing.Point(1220, 195);
            this.monthList.Margin = new System.Windows.Forms.Padding(5);
            this.monthList.Name = "monthList";
            this.monthList.Size = new System.Drawing.Size(129, 213);
            this.monthList.TabIndex = 41;
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cikis.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis.Location = new System.Drawing.Point(597, 1);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(120, 60);
            this.Cikis.TabIndex = 64;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Kayit
            // 
            this.Kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Kayit.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayit.Location = new System.Drawing.Point(263, 1);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(248, 60);
            this.Kayit.TabIndex = 65;
            this.Kayit.Text = "Kayıt İşlemleri";
            this.Kayit.UseVisualStyleBackColor = false;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // temizlikTot
            // 
            this.temizlikTot.AutoSize = true;
            this.temizlikTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temizlikTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizlikTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temizlikTot.Location = new System.Drawing.Point(595, 474);
            this.temizlikTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.temizlikTot.Name = "temizlikTot";
            this.temizlikTot.Size = new System.Drawing.Size(17, 24);
            this.temizlikTot.TabIndex = 66;
            this.temizlikTot.Text = "-";
            // 
            // bakimTot
            // 
            this.bakimTot.AutoSize = true;
            this.bakimTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bakimTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakimTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bakimTot.Location = new System.Drawing.Point(701, 474);
            this.bakimTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bakimTot.Name = "bakimTot";
            this.bakimTot.Size = new System.Drawing.Size(17, 24);
            this.bakimTot.TabIndex = 67;
            this.bakimTot.Text = "-";
            // 
            // kapiciTot
            // 
            this.kapiciTot.AutoSize = true;
            this.kapiciTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kapiciTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapiciTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kapiciTot.Location = new System.Drawing.Point(812, 474);
            this.kapiciTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.kapiciTot.Name = "kapiciTot";
            this.kapiciTot.Size = new System.Drawing.Size(17, 24);
            this.kapiciTot.TabIndex = 68;
            this.kapiciTot.Text = "-";
            // 
            // muhasebeTot
            // 
            this.muhasebeTot.AutoSize = true;
            this.muhasebeTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.muhasebeTot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muhasebeTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.muhasebeTot.Location = new System.Drawing.Point(928, 474);
            this.muhasebeTot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.muhasebeTot.Name = "muhasebeTot";
            this.muhasebeTot.Size = new System.Drawing.Size(17, 24);
            this.muhasebeTot.TabIndex = 69;
            this.muhasebeTot.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1357, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 70;
            this.label1.Text = "Gider Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(513, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 70);
            this.label2.TabIndex = 71;
            this.label2.Text = "Bilanço İşlemleri";
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.Blue;
            this.anasayfa.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anasayfa.Location = new System.Drawing.Point(12, 1);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(207, 60);
            this.anasayfa.TabIndex = 72;
            this.anasayfa.Text = "Ana Sayfa";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // bilancoPNG
            // 
            this.bilancoPNG.BackColor = System.Drawing.Color.Transparent;
            this.bilancoPNG.Image = global::Apartman.Properties.Resources.bilanco;
            this.bilancoPNG.Location = new System.Drawing.Point(43, 124);
            this.bilancoPNG.Name = "bilancoPNG";
            this.bilancoPNG.Size = new System.Drawing.Size(124, 68);
            this.bilancoPNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bilancoPNG.TabIndex = 73;
            this.bilancoPNG.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1218, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 74;
            this.label3.Text = "Ayı Seç";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Bilgilendirme";
            // 
            // bilanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Apartman.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1495, 956);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bilancoPNG);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muhasebeTot);
            this.Controls.Add(this.kapiciTot);
            this.Controls.Add(this.bakimTot);
            this.Controls.Add(this.temizlikTot);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.monthList);
            this.Controls.Add(this.harcamaButton);
            this.Controls.Add(this.harcamaTextBox);
            this.Controls.Add(this.harcamaList);
            this.Controls.Add(this.totBilanco);
            this.Controls.Add(this.totBilancoLabel);
            this.Controls.Add(this.sgkTot);
            this.Controls.Add(this.elektrikTot);
            this.Controls.Add(this.suTot);
            this.Controls.Add(this.aidatTot);
            this.Controls.Add(this.bilancoView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "bilanco";
            this.Text = "Bilanço İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bilancoPNG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView bilancoView;
        private System.Windows.Forms.ColumnHeader Su;
        private System.Windows.Forms.ColumnHeader Elektrik;
        private System.Windows.Forms.ColumnHeader SGK;
        private System.Windows.Forms.ColumnHeader YılAy;
        private System.Windows.Forms.ColumnHeader aidat;
        private System.Windows.Forms.Label aidatTot;
        private System.Windows.Forms.Label suTot;
        private System.Windows.Forms.Label elektrikTot;
        private System.Windows.Forms.Label sgkTot;
        private System.Windows.Forms.Label totBilancoLabel;
        private System.Windows.Forms.Label totBilanco;
        private System.Windows.Forms.ListBox harcamaList;
        private System.Windows.Forms.TextBox harcamaTextBox;
        private System.Windows.Forms.Button harcamaButton;
        private System.Windows.Forms.ListBox monthList;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.ColumnHeader Temizlik;
        private System.Windows.Forms.ColumnHeader Bakim;
        private System.Windows.Forms.ColumnHeader Kapici;
        private System.Windows.Forms.ColumnHeader Muhasebe;
        private System.Windows.Forms.Label temizlikTot;
        private System.Windows.Forms.Label bakimTot;
        private System.Windows.Forms.Label kapiciTot;
        private System.Windows.Forms.Label muhasebeTot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.PictureBox bilancoPNG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}