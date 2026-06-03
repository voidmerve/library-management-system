using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MERVEGÜNDOĞDU
{
    public partial class GöstergePaneli : Form
    {
        public GöstergePaneli()
        {
            InitializeComponent();
        }

        private void buttonuyeekle_Click(object sender, EventArgs e)
        {
            UYEEKLE uyekle = new UYEEKLE();
            uyekle.Show();
        }

        private void buttonuyelistele_Click(object sender, EventArgs e)
        {
            UYELİSTELE uyelistele = new UYELİSTELE();
            uyelistele.Show();
        }

        private void buttonkitapekle_Click(object sender, EventArgs e)
        {
            KİTAPEKLE kitapekle = new KİTAPEKLE();
            kitapekle.Show();
        }

        private void buttonkitaplistele_Click(object sender, EventArgs e)
        {
            KİTAPLİSTELE kitaplistele = new KİTAPLİSTELE();
            kitaplistele.Show();
        }

        private void buttonemanetekle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
