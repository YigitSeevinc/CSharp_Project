﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Sistemi
{
    public partial class formOgrenci : Form
    {
        public formOgrenci()
        {
            InitializeComponent();
        }

        private void comboSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        VeriTabaniIslemleri vtislemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;
        private void formOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }
        
        public void Listele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutsatiri = "SELECT * FROM ogrenciler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOgrenci.DataSource = dataTable;
                gridOgrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci Numarası";
                gridOgrenci.Columns["ad"].HeaderText = "Adı";
                gridOgrenci.Columns["soyad"].HeaderText = "Soyadı";
                gridOgrenci.Columns["sinif"].HeaderText = "Sınıf";
                gridOgrenci.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                gridOgrenci.Columns["telefon"].HeaderText = "Telefon";
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, "Hata Oluştu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear(); 
            txtTelefon.Clear();
        }
       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "INSERT INTO ogrenciler(ogrenci_no,ad,soyad,sinif,cinsiyet,telefon) VALUES(@no,@ad,@soyad,@sinif,@cinsiyet,@telefon)";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtAd.Text = gridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = gridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txtTelefon.Text = gridOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
                comboSinif.SelectedItem = gridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
                comboCinsiyet.SelectedItem = gridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "DELETE FROM ogrenciler WHERE ogrenci_no = @no";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@no", gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());               
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "UPDATE ogrenciler SET ogrenci_no=@no,ad=@ad,soyad=@soyad,sinif=@sinif,cinsiyet=@cinsiyet,telefon=@telefon";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
             OgrenciArama(txtOgrenciAra.Text);
        }

        public void OgrenciArama(string aranacakkelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM ogrenciler WHERE ad LIKE '"+aranacakkelime+"%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridOgrenci.DataSource = dataTable;
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
