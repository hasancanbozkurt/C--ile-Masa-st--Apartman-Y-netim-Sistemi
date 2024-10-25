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
    public partial class Veriler : Form
    {
        public Veriler()
        {
            InitializeComponent();
            verilerigörüntüle();
        }
        //Database bağlan
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Apt\\Apartman.mdb");

        //Verileri oku
        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Apartman_db");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["aidat1"].ToString());
                ekle.SubItems.Add(oku["aidat2"].ToString());
                ekle.SubItems.Add(oku["aidat3"].ToString());
                ekle.SubItems.Add(oku["aidat4"].ToString());
                ekle.SubItems.Add(oku["aidat5"].ToString());
                ekle.SubItems.Add(oku["aidat6"].ToString());
                ekle.SubItems.Add(oku["aidat7"].ToString());
                ekle.SubItems.Add(oku["aidat8"].ToString());
                ekle.SubItems.Add(oku["aidat9"].ToString());
                ekle.SubItems.Add(oku["aidat10"].ToString());
                ekle.SubItems.Add(oku["aidat11"].ToString());
                ekle.SubItems.Add(oku["aidat12"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }



        int id = 0;


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].Text);

            daireTextBox.Text = listView1.SelectedItems[0].SubItems[0].Text;
            adTextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            soyadTextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            telefonTextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            aidatTextBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            aidatTextBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            aidatTextBox3.Text = listView1.SelectedItems[0].SubItems[6].Text;
            aidatTextBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            aidatTextBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            aidatTextBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            aidatTextBox7.Text = listView1.SelectedItems[0].SubItems[10].Text;
            aidatTextBox8.Text = listView1.SelectedItems[0].SubItems[11].Text;
            aidatTextBox9.Text = listView1.SelectedItems[0].SubItems[12].Text;
            aidatTextBox10.Text = listView1.SelectedItems[0].SubItems[13].Text;
            aidatTextBox11.Text = listView1.SelectedItems[0].SubItems[14].Text;
            aidatTextBox12.Text = listView1.SelectedItems[0].SubItems[15].Text;
        }



        private void btnTemizle_Click(object sender, EventArgs e)
        {
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            telefonTextBox.Text = "";
            aidatTextBox1.Text = "";
            aidatTextBox2.Text = "";
            aidatTextBox3.Text = "";
            aidatTextBox4.Text = "";
            aidatTextBox5.Text = "";
            aidatTextBox6.Text = "";
            aidatTextBox7.Text = "";
            aidatTextBox8.Text = "";
            aidatTextBox9.Text = "";
            aidatTextBox9.Text = "";
            aidatTextBox10.Text = "";
            aidatTextBox11.Text = "";
            aidatTextBox12.Text = "";
            adTextBox.Focus();
        }

        //Formda güncelleme-değişiklik
        private void UpdateButton(object sender, EventArgs e)
        {


            if (adTextBox.Text.Length > 0)
            {
                baglanti.Open();
                OleDbCommand sqlkomut = new OleDbCommand("update [Apartman_db] set  [Ad]='" + adTextBox.Text.ToString() + "', [ID]='" + daireTextBox.Text.ToString() + "', [Soyad]='" 
                   + soyadTextBox.Text.ToString() 
                   + "', [Telefon]='" + telefonTextBox.Text.ToString()
                   + "',[aidat1]='" + aidatTextBox1.Text.ToString()
                   + "',[aidat2]='" + aidatTextBox2.Text.ToString()
                   + "',[aidat3]='" + aidatTextBox3.Text.ToString()
                   + "',[aidat4]='" + aidatTextBox4.Text.ToString()
                   + "',[aidat5]='" + aidatTextBox5.Text.ToString()
                   + "',[aidat6]='" + aidatTextBox6.Text.ToString()
                   + "',[aidat7]='" + aidatTextBox7.Text.ToString()
                   + "',[aidat8]='" + aidatTextBox8.Text.ToString()
                   + "',[aidat9]='" + aidatTextBox9.Text.ToString()
                   + "',[aidat10]='" + aidatTextBox10.Text.ToString()
                   + "',[aidat11]='" + aidatTextBox11.Text.ToString()
                   + "',[aidat12]='" + aidatTextBox12.Text.ToString()
                   + "' where [ID]=" + daireTextBox.Text.ToString() + "", baglanti);
                sqlkomut.ExecuteNonQuery();
                baglanti.Close();
                verilerigörüntüle();
            }

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {         
               
        }


        private void mainMenu(object sender, EventArgs e)
        {
            FormAna fr = new FormAna();
            fr.Show();
            this.Hide();
        }
        private void CheckID()
        {


        }
        
        private void kaydetButtonFunc(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            komut.CommandText = ("Select ID From Apartman_db");
            OleDbDataReader oku = komut.ExecuteReader();

            List<String> daireNOs = new List<String>();

            while (oku.Read())
                daireNOs.Add(oku["ID"].ToString());

            for (int i = 0; i < daireNOs.Count; i++)

                if (daireNOs[i].Contains(daireTextBox.Text.ToString()))
                {
                    baglanti.Close();
                    string text = "Girilen daire var, bilgileri güncelleyin.";
                    MessageBox.Show(text);
                    return;
                }

            if (adTextBox.Text.Length > 0) {
                OleDbCommand sqlkomut = new OleDbCommand("insert into Apartman_db(Ad,Soyad,Telefon,aidat1,aidat2,aidat3,aidat4,aidat5,aidat6,aidat7,aidat8,aidat9,aidat10,aidat11,aidat12,ID) values ('"
               + adTextBox.Text.ToString() + "', '" + soyadTextBox.Text.ToString() + "', '" 
               + telefonTextBox.Text.ToString() + "','" 
               + aidatTextBox1.Text.ToString() + "', '" 
               + aidatTextBox2.Text.ToString() + "', '" 
               + aidatTextBox3.Text.ToString() + "', '" 
               + aidatTextBox4.Text.ToString() + "', '" 
               + aidatTextBox5.Text.ToString() + "', '" 
               + aidatTextBox6.Text.ToString() + "', '" 
               + aidatTextBox7.Text.ToString() + "', '" 
               + aidatTextBox8.Text.ToString() + "', '" 
               + aidatTextBox9.Text.ToString() + "', '"
               + aidatTextBox10.Text.ToString() + "', '"
               + aidatTextBox11.Text.ToString() + "', '"
               + aidatTextBox12.Text.ToString() + "', '"
               + daireTextBox.Text.ToString() + "')", baglanti);
                sqlkomut.ExecuteNonQuery();
                baglanti.Close();
                verilerigörüntüle();
                adTextBox.Refresh();
        }
        }
        private void searchByDaireNo(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Apartman_db where ID like '%" + searchDaireNoTextBox.Text + "%'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["aidat1"].ToString());
                ekle.SubItems.Add(oku["aidat2"].ToString());
                ekle.SubItems.Add(oku["aidat3"].ToString());
                ekle.SubItems.Add(oku["aidat4"].ToString());
                ekle.SubItems.Add(oku["aidat5"].ToString());
                ekle.SubItems.Add(oku["aidat6"].ToString());
                ekle.SubItems.Add(oku["aidat7"].ToString());
                ekle.SubItems.Add(oku["aidat8"].ToString());
                ekle.SubItems.Add(oku["aidat9"].ToString());
                ekle.SubItems.Add(oku["aidat10"].ToString());
                ekle.SubItems.Add(oku["aidat11"].ToString());
                ekle.SubItems.Add(oku["aidat12"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void searchBySurname(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Apartman_db where Soyad like '%" + searchSoyadTextBox.Text + "%'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["aidat1"].ToString());
                ekle.SubItems.Add(oku["aidat2"].ToString());
                ekle.SubItems.Add(oku["aidat3"].ToString());
                ekle.SubItems.Add(oku["aidat4"].ToString());
                ekle.SubItems.Add(oku["aidat5"].ToString());
                ekle.SubItems.Add(oku["aidat6"].ToString());
                ekle.SubItems.Add(oku["aidat7"].ToString());
                ekle.SubItems.Add(oku["aidat8"].ToString());
                ekle.SubItems.Add(oku["aidat9"].ToString());
                ekle.SubItems.Add(oku["aidat10"].ToString());
                ekle.SubItems.Add(oku["aidat11"].ToString());
                ekle.SubItems.Add(oku["aidat12"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            FormAna fr = new FormAna();
            fr.Show();
            this.Hide();
        }


        private void Bilanco_Click(object sender, EventArgs e)
        {
            bilanco fr = new bilanco();
            fr.Show();
            this.Hide();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            FormAna fr = new FormAna();
            fr.Show();
            this.Hide();
        }
        
        private void searchDaireNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
    }

        private void aidatTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            
    }

        private void aidatTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            
        }

        private void aidatTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void aidatTextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void telefonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
    }
}