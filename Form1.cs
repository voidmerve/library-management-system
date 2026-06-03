namespace MERVEGÜNDOĞDU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textkullanıcıadi.Text == "merve" && textsifre.Text == "1234") { 
                this.Hide();
            GöstergePaneli gösterge=new GöstergePaneli();
            gösterge.Show();}
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre!");
                textkullanıcıadi.Clear();
                textsifre.Clear();
            }
            
        }
    }
}
