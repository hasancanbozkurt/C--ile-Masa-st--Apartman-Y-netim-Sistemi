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
    public partial class bilanco : Form
    {
        
        public bilanco()
        {
            InitializeComponent();
            bilancoverilerigörüntüle();

        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Apt\\Apartman.mdb");
        //Bilanço verilerini DB'den çek-oku
        private void bilancoverilerigörüntüle()
        {
            bilancoView.Items.Clear();

            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand();
            komut1.Connection = baglanti;
            komut1.CommandText = ("Select * From Apartman_db");
            OleDbDataReader oku1 = komut1.ExecuteReader();

            int aidat1 = 0;
            int aidat2 = 0;
            int aidat3 = 0;
            int aidat4 = 0;
            int aidat5 = 0;
            int aidat6 = 0;
            int aidat7 = 0;
            int aidat8 = 0;
            int aidat9 = 0;
            int aidat10 = 0;
            int aidat11 = 0;
            int aidat12 = 0;

            while (oku1.Read())
            {

                aidat1 += int.Parse(oku1["aidat1"].ToString());
                aidat2 += int.Parse(oku1["aidat2"].ToString());
                aidat3 += int.Parse(oku1["aidat3"].ToString());
                aidat4 += int.Parse(oku1["aidat4"].ToString());
                aidat5 += int.Parse(oku1["aidat5"].ToString());
                aidat6 += int.Parse(oku1["aidat6"].ToString());
                aidat7 += int.Parse(oku1["aidat7"].ToString());
                aidat8 += int.Parse(oku1["aidat8"].ToString());
                aidat9 += int.Parse(oku1["aidat9"].ToString());
                aidat10 += int.Parse(oku1["aidat10"].ToString());
                aidat11 += int.Parse(oku1["aidat11"].ToString());
                aidat12 += int.Parse(oku1["aidat12"].ToString());
                
            }
            baglanti.Close();

            // Bilanço verilerini güncelle

            baglanti.Open();
            OleDbCommand sqlkomut1 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat1 + " where [ay]=1", baglanti);
            sqlkomut1.ExecuteNonQuery();

            OleDbCommand sqlkomut2 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat2 + " where [ay]=2", baglanti);
            sqlkomut2.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut3 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat3 + " where [ay]=3", baglanti);
            sqlkomut3.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut4 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat4 + " where [ay]=4", baglanti);
            sqlkomut4.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut5 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat5 + " where [ay]=5", baglanti);
            sqlkomut5.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut6 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat6 + " where [ay]=6", baglanti);
            sqlkomut6.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut7 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat7 + " where [ay]=7", baglanti);
            sqlkomut7.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut8 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat8 + " where [ay]=8", baglanti);
            sqlkomut8.ExecuteNonQuery();                                                        
                                                                                                
            OleDbCommand sqlkomut9 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat9 + " where [ay]=9", baglanti);
            sqlkomut9.ExecuteNonQuery();

            OleDbCommand sqlkomut10 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat10 + " where [ay]=10", baglanti);
            sqlkomut10.ExecuteNonQuery();                                                         
                                                                                                  
            OleDbCommand sqlkomut11 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat11 + " where [ay]=11", baglanti);
            sqlkomut11.ExecuteNonQuery();                                                         
                                                                                                  
            OleDbCommand sqlkomut12 = new OleDbCommand("update bilanco_db set [aidat]=" + aidat12 + " where [ay]=12", baglanti);
            sqlkomut12.ExecuteNonQuery();

            baglanti.Close();

            int aidatT = 0;
            double suT = 0.0;
            double elektrikT = 0;
            double sgkT = 0;
            double temizlikT = 0;
            double bakimT = 0;
            double kapiciT = 0;
            double muhasebeT = 0;

            baglanti.Open();

            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From bilanco_db");
            OleDbDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                string ayStr = "";

                if (oku["ay"].ToString() == "1")
                {
                    ayStr = "Ocak";
                }
                else if (oku["ay"].ToString() == "2")
                {
                    ayStr = "Şubat";
                }
                else if (oku["ay"].ToString() == "3")
                {
                    ayStr = "Mart";
                }
                else if (oku["ay"].ToString() == "4")
                {
                    ayStr = "Nisan";
                }
                else if (oku["ay"].ToString() == "5")
                {
                    ayStr = "Mayıs";
                }
                else if (oku["ay"].ToString() == "6")
                {
                    ayStr = "Haziran";
                }
                else if (oku["ay"].ToString() == "7")
                {
                    ayStr = "Temmuz";
                }
                else if (oku["ay"].ToString() == "8")
                {
                    ayStr = "Ağustos";
                }
                else if (oku["ay"].ToString() == "9")
                {
                    ayStr = "Eylül";
                }
                else if (oku["ay"].ToString() == "10")
                {
                    ayStr = "Ekim";
                }
                else if (oku["ay"].ToString() == "11")
                {
                    ayStr = "Kasım";
                }
                else if (oku["ay"].ToString() == "12")
                {
                    ayStr = "Aralık";
                }

                ekle.Text = ayStr;

                ekle.SubItems.Add(oku["aidat"].ToString());
                aidatT += int.Parse(oku["aidat"].ToString());
              
                ekle.SubItems.Add(oku["Su"].ToString());
                suT += Convert.ToDouble(oku["su"]);

                ekle.SubItems.Add(oku["Elektrik"].ToString());
                elektrikT += Convert.ToDouble(oku["Elektrik"]);

                ekle.SubItems.Add(oku["SGK"].ToString());
                sgkT += Convert.ToDouble(oku["SGK"]);
                
                ekle.SubItems.Add(oku["Temizlik"].ToString());
                temizlikT += Convert.ToDouble(oku["Temizlik"]);

                ekle.SubItems.Add(oku["Bakım"].ToString());
                bakimT += Convert.ToDouble(oku["Bakım"]);

                ekle.SubItems.Add(oku["Kapıcı"].ToString());
                kapiciT += Convert.ToDouble(oku["Kapıcı"]);

                ekle.SubItems.Add(oku["Muhasebe"].ToString());
                muhasebeT += Convert.ToDouble(oku["Muhasebe"]);

                bilancoView.Items.Add(ekle);
            }
            aidatTot.Text = aidatT.ToString();
            suTot.Text = suT.ToString();
            elektrikTot.Text = elektrikT.ToString();
            sgkTot.Text = sgkT.ToString();
            temizlikTot.Text = temizlikT.ToString();
            bakimTot.Text = bakimT.ToString();
            kapiciTot.Text = kapiciT.ToString();
            muhasebeTot.Text = muhasebeT.ToString();

            totBilanco.Text = (aidatT - suT - elektrikT - sgkT - temizlikT - bakimT - kapiciT - muhasebeT).ToString();

            baglanti.Close();
        }
        private void bilanco_Load(object sender, EventArgs e)
        {
            bilancoverilerigörüntüle();
        }
        private void mainMenu(object sender, EventArgs e)
        {
            FormAna fr = new FormAna();
            fr.Show();
            this.Hide();
        }

        private void harcamaButton_Click(object sender, EventArgs e)
        {
            if (harcamaList.SelectedItem != null)
            {
                if (harcamaTextBox.Text != null)
                {
                    if (monthList.SelectedItem != null)
                    {
                        if (harcamaTextBox.Text != "")
                        {
                            harcamaTextBox.Text = harcamaTextBox.Text.Replace(',', '.');
                            baglanti.Open();

                        OleDbCommand sqlkomut = new OleDbCommand("update [bilanco_db] set " + harcamaList.SelectedItem.ToString() + "="
                                                                + harcamaTextBox.Text + " where [ay]=" + monthList.SelectedItem.ToString().Split('.')[0] + ""
                                                                    , baglanti);
                        sqlkomut.ExecuteNonQuery();
                        
                        baglanti.Close();
                        bilancoverilerigörüntüle();
                        }
                    }
                }
            }
        }


        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kayit_Click(object sender, EventArgs e)
        {
            Veriler fr = new Veriler();
            fr.Show();
            this.Hide();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            FormAna fr = new FormAna();
            fr.Show();
            this.Hide();
        }

        private void harcamaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8 && e.KeyChar !=',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
