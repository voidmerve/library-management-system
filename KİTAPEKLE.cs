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
    public partial class KİTAPEKLE : Form
    {
        public KİTAPEKLE()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-MPOC9F0\\SQLEXPRESS; Initial Catalog=MERVE;Integrated Security=True");

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkod,kitapadi,yazar,yayınevi,sayfasayisi,türü,stoksayisi,rafno) values(@barkod,@kitapadi,@yazar,@yayınevi,@sayfasayisi,@türü,@stoksayisi,@rafno)", Baglanti);
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
            MessageBox.Show("kitap kaydi yapıldı");
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
    }
}
