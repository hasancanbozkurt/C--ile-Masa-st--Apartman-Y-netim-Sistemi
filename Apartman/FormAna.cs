using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Apartman
{
    public partial class FormAna : System.Windows.Forms.Form
    {
        private FrmAdmin FrmAdmin;

        public FormAna()
        {

            InitializeComponent();
        }
        
        private void BtnKayit_Click(object sender, EventArgs e)
        {
            Veriler fr = new Veriler();
            fr.Show();
            this.Hide();
        }
        
        private void btnVeriler_Click(object sender, EventArgs e)
        {
            bilanco fr = new bilanco();
            fr.Show();
            this.Hide();
        }
        
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Kayıtlı İşlemler Sayfasına Git
        private void Kayit_Click(object sender, EventArgs e)
        {
            Veriler fr = new Veriler();
            fr.Show();
            this.Hide();
        }
        //Bilanço Sayfasına Git
        private void Bilanco_Click(object sender, EventArgs e)
        {
            bilanco fr = new bilanco();
            fr.Show();
            this.Hide();
        }
        //Çıkış
        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Şifre Değiştirme
        private void button1_Click(object sender, EventArgs e)
        {
            SifreDbox.Visible = true;
            if (SifreDbox.Text != "")
            {
             OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Apt\\Apartman.mdb");
             baglanti.Open();
             OleDbCommand sqlkomut12 = new OleDbCommand("update kullanici_db set [password]=" + int.Parse(SifreDbox.Text) + " where [kullanici]='" + FrmAdmin.AdminName + "'", baglanti);
             sqlkomut12.ExecuteNonQuery();

                baglanti.Close();
                SifreDbox.Visible = false;
                SifreDbox.Text = "";
            }

        }
    }
}
