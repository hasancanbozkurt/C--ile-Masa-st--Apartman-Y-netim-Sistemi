using System;
using System.Diagnostics;
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
   
    public partial class FrmAdmin : System.Windows.Forms.Form
    {
        public static string AdminName;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        //database bağlantısı
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Apt\\Apartman.mdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            komut.CommandText = ("Select * From kullanici_db");

            OleDbDataReader oku = komut.ExecuteReader();

            List<String> users = new List<String>();
            List<String> passwords = new List<String>();

            //kullanıcı ve şifre bilgileri girişi
            while (oku.Read())
            {
                users.Add(oku["kullanici"].ToString());
                passwords.Add(oku["password"].ToString());
            }


            for (int i = 0; i < users.Count; i++)

                if (users[i].Contains(KullaniciAdi.Text))

                    if (passwords[i] == Sifre.Text)
                    {
                        FormAna fr = new FormAna();
                        fr.Show();
                        this.Hide();
                        AdminName = KullaniciAdi.Text;
                        return;
                    }
        }

        //kullanıcı ve şifre bilgilerini oku
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Apt\\Apartman.mdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            komut.CommandText = ("Select * From kullanici_db");

            OleDbDataReader oku = komut.ExecuteReader();

            List<String> users = new List<String>();
            List<String> passwords = new List<String>();

            while (oku.Read())
            {
                users.Add(oku["kullanici"].ToString());
                passwords.Add(oku["password"].ToString());
            }


            for (int i = 0; i < users.Count; i++)

                if (users[i].Contains(KullaniciAdi.Text))

                    if (passwords[i] == Sifre.Text)
                    {
                        FormAna fr = new FormAna();
                        fr.Show();
                        this.Hide();
                        return;
                    }


        }

        //kullanıcı ve şifre bilgilerini doğrulama
        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Apt\\Apartman.mdb");

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            komut.CommandText = ("Select * From kullanici_db");

            OleDbDataReader oku = komut.ExecuteReader();

            List<String> users = new List<String>();
            List<String> passwords = new List<String>();

            while (oku.Read())
            {
                users.Add(oku["kullanici"].ToString());
                passwords.Add(oku["password"].ToString());
            }

            //Ana Sayfa alanına bağlan
            for (int i = 0; i < users.Count; i++)

                if (users[i].Contains(KullaniciAdi.Text))

                    if (passwords[i] == Sifre.Text)
                    {
                        FormAna fr = new FormAna();
                        fr.Show();
                        this.Hide();
                        AdminName = KullaniciAdi.Text;
                        return;
                    }

        }
        //Şifre gizle
        private void Sifre_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            Sifre.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            Sifre.MaxLength = 12;
        }
        //şifre unuttum
        private void SifreUnutum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişime Geçiniz: hasancanbozkurt@hotmail.com");
        }
        //çıkış
        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
