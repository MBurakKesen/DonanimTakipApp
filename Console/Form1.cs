using Bussiness;

namespace Console
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void UrovoOnarimTakipBtn_Click(object sender, EventArgs e)
        {
            UcretliOnarimTakip ucretliOnarimTakip = new();
            ucretliOnarimTakip.Show();
            this.Hide();
        }

        private void HyteraEnvanterBtn_Click(object sender, EventArgs e)
        {
            HyteraEnvanter hyteraEnvanter = new HyteraEnvanter();
            hyteraEnvanter.Show();
            this.Hide();
        }

        private void UrovoGarantiTakipBtn_Click(object sender, EventArgs e)
        { 
            UrovoK239GarantiTakip urovoTakip = new();
            urovoTakip.Show();
            this.Hide();
        }

        private void YaziciSeriNoBtn_Click(object sender, EventArgs e)
        {
            UrovoEnvanter urovoEnvanter = new ();
            urovoEnvanter.Show();
            this.Hide();
        }

        private void YaziciVeSeriNumaraBtn_Click(object sender, EventArgs e)
        {
            YaziciVeSeriNumara yaziciVeSeriNumara = new();
            yaziciVeSeriNumara.Show();
            this.Hide();
        }

        private void AnasayfaLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici: Muhammed Burak Kesen \n" +
                "Sürüm: 1.0.0 Beta");
        }
    }
}