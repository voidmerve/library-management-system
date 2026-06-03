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
    public partial class UYELİSTELE : Form
    {
        public UYELİSTELE()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            texttc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-MPOC9F0\\SQLEXPRESS; Initial Catalog=MERVE;Integrated Security=True");

        private void texttc_TextChanged(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where tc like'" + texttc.Text + "'", Baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textad.Text = read["adsoyad"].ToString();
                textyas.Text = read["yas"].ToString();
                combocinsiyet.Text = read["cinsiyet"].ToString();
                texttelefon.Text = read["telefon"].ToString();
                textadres.Text = read["adres"].ToString();
                textemail.Text = read["email"].ToString();
                textokukitapsayisi.Text = read["okukitapsayisi"].ToString();
               
            }
            Baglanti.Close();
        }
        DataSet daset = new DataSet();
        private void textaratc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();
            Baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where tc like'%" + textaratc.Text + "%'", Baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            Baglanti.Close();
            
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from uye where tc =@tc", Baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti!");
            daset.Tables["uye"].Clear();
            uyelistele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uyelistele()
        {
            Baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye ", Baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            Baglanti.Close();

        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okukitapsayisi=@okukitapsayisi where tc=@tc", Baglanti);
            komut.Parameters.AddWithValue("@tc", texttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textad.Text);
            komut.Parameters.AddWithValue("@yas", textyas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", combocinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", texttelefon.Text);
            komut.Parameters.AddWithValue("@adres", textadres.Text);
            komut.Parameters.AddWithValue("@email", textemail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", textokukitapsayisi.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close(); daset.Tables["uye"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void UYELİSTELE_Load(object sender, EventArgs e)
        {
            uyelistele();
        }
    }
}


