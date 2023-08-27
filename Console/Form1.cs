using Bussiness;
using Console.Core;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Squirrel;
using System.Diagnostics;
using System.Reflection;

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
            HyteraEnvanter hyteraEnvanter = new ();
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
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);
            string Text = $"{"Donanım Takip Uygulaması"} {info.FileVersion}";
            MessageBox.Show(Text);
        }

        private void OnarımTakipBtn_Click(object sender, EventArgs e)
        {
            UcretliOnarimTakip ucretliOnarimTakip= new();
            ucretliOnarimTakip.Show();
            this.Hide();
        }
       
    }
}