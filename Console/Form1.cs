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

        private void UrovoEnvanterBtn_Click(object sender, EventArgs e)
        {
            UrovoEnvanter urovoEnvanter = new();
            urovoEnvanter.Show();
            this.Hide();
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
            YaziciVeSeriNumaralari yaziciVeSeriNumaralari = new YaziciVeSeriNumaralari();
            yaziciVeSeriNumaralari.Show();
            this.Hide();
        }
    }
}