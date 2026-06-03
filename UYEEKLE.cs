using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MERVEGÜNDOĞDU
{
    public partial class UYEEKLE : Form
    {
        public UYEEKLE()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=DESKTOP-MPOC9F0\\SQLEXPRESS; Initial Catalog=MERVE;Integrated Security=True");

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", Baglanti);
            komut.Parameters.AddWithValue("@tc", texttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", textad.Text);
            komut.Parameters.AddWithValue("@yas", textyas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", combocinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", texttelefon.Text);
            komut.Parameters.AddWithValue("@adres", textadres.Text);
            komut.Parameters.AddWithValue("@email", textemail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", textokukitapsayisi.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("uye kaydi yapıldı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != textokukitapsayisi)
                    {
                        item.Text = "";
                    }
                }
            }
        }
    }
}
