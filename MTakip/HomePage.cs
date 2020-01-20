using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace MTakip
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firmalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listele()
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());

                listFirmalar.Items.Add(ekle);
            }


        }


        private void HomePage_Load(object sender, EventArgs e)
        {

            listele();

        }

        private void listmusteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //firma ekleme butonu
            conn con = new conn();
            try
            {

                if (con.connect().State == ConnectionState.Closed)
                    con.connect().Open();

                string ekle = "insert into Firmalar(FirmaAd,FirmaTel,FirmaVergiNo,YetkiliAd,YetkiliTel,il,ilce) values (@fAd,@fTel,@fVno,@yAd,@yTel,@il,@ilce)";

                SqlCommand komut = new SqlCommand(ekle, con.connect());
                komut.Parameters.AddWithValue("@fAd", firmaAd.Text);
                komut.Parameters.AddWithValue("@fTel", firmaTel.Text);
                komut.Parameters.AddWithValue("@fVno", firmaVergino.Text);
                komut.Parameters.AddWithValue("@yAd", yetkAd.Text);
                komut.Parameters.AddWithValue("@yTel", yetkTel.Text);
                komut.Parameters.AddWithValue("@il", il.Text);
                komut.Parameters.AddWithValue("@ilce", ilce.Text);
                komut.ExecuteNonQuery();
                con.connect().Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            listele();
        }

        private void tbFirmaAd_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where FirmaAd like '%" + tbFirmaAd.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }
        }

        private void tbFirmaTel_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where FirmaTel like '%" +tbFirmaTel.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }

        }

        private void tbVergiNo_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where FirmaVergiNo like '%" +tbVergiNo.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }

        }

        private void tbYad_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where YetkiliAd like '%" +tbYad.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }

        }

        private void tbYetkiliTel_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where YetkiliTel like '%" + tbYetkiliTel.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }
        }

        private void tbil_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where il like '%" + tbil.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }
        }

        private void tbilce_TextChanged(object sender, EventArgs e)
        {
            conn con = new conn();
            SqlCommand komut = new SqlCommand("Select * From Firmalar where ilce like '%" + tbilce.Text + "%'", con.connect());
            SqlDataReader oku = komut.ExecuteReader();

            listFirmalar.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FirmaAd"].ToString();
                ekle.SubItems.Add(oku["FirmaTel"].ToString());
                ekle.SubItems.Add(oku["FirmaVergiNo"].ToString());
                ekle.SubItems.Add(oku["YetkiliAd"].ToString());
                ekle.SubItems.Add(oku["YetkiliTel"].ToString());
                ekle.SubItems.Add(oku["il"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                listFirmalar.Items.Add(ekle);

            }
        }
    }
}
