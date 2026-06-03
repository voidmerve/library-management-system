using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERVEGÜNDOĞDU
{
    public partial class KİTAPLİSTELE : Form
    {
        public KİTAPLİSTELE()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-MPOC9F0\\SQLEXPRESS; Initial Catalog=MERVE;Integrated Security=True");
        DataSet daset = new DataSet();
        private void kitaplistele()
        {
            Baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap ", Baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            Baglanti.Close();

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {

            Baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kitap where barkod =@barkod", Baglanti);
            komut.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti!");
            daset.Tables["kitap"].Clear();
            kitaplistele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void buttonkitapguncelle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapadi=@kitapadi,yazar=@yazar,yayınevi=@yayınevi,sayfasayisi=@sayfasayisi,türü=@türü,stoksayisi=@stoksayisi,rafno=@rafno where barkod=@barkod", Baglanti);
            komut.Parameters.AddWithValue("@barkod", textbarkod.Text);
            komut.Parameters.AddWithValue("@kitapadi", textkitapadi.Text);
            komut.Parameters.AddWithValue("@yazar", textyazar.Text);
            komut.Parameters.AddWithValue("@yayınevi", textyayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", textsayfasayisi.Text);
            komut.Parameters.AddWithValue("@türü", combotürü.Text);
            komut.Parameters.AddWithValue("@stoksayisi", textstoksayisi.Text);
            komut.Parameters.AddWithValue("@rafno", textrafno.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            daset.Tables["kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void textarabarkod_TextChanged(object sender, EventArgs e)
        {/*
            daset.Tables.Clear();
            Baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where barkod like'%" + textarabarkod.Text + "%'", Baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            Baglanti.Close();*/

        }

        private void textbarkod_TextChanged(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkod like'" + textbarkod.Text + "'", Baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textbarkod.Text = read["barkod"].ToString();
                textkitapadi.Text = read["kitapadi"].ToString();
                textyazar.Text = read["yazar"].ToString();
                textyayinevi.Text = read["yayınevi"].ToString();
                textsayfasayisi.Text = read["sayfasayisi"].ToString();
                combotürü.Text = read["türü"].ToString();
                textstoksayisi.Text = read["stoksayisi"].ToString();
                textrafno.Text = read["rafno"].ToString();

            }
            Baglanti.Close();

        }

        private void KİTAPLİSTELE_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


