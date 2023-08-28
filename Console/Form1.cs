using Bussiness;
using Console.Core;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using System.Diagnostics;
using System.Reflection;
using UpdateProject;

namespace Console
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();

            try
            {
                //UptadeProject<Anasayfa> updates = new(this, @"https://www.dropbox.com/scl/fi/ic9jagmlddkgmo5onetgh/update.txt?rlkey=th7mx7vh3rww2nyo62lkh0btk&dl=1", @"https://www.dropbox.com/scl/fi/gtzec3p4lzvhit6twb3ku/DonanimTakipApp.zip?rlkey=7e93y4qkmashwzacj2opuw5re&dl=0", "DonanimTakipApp.zip", "1.0.0");
            }
            catch (Exception)
            {

                throw;
            }
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

        private void OtaparkPersonelBtn_Click(object sender, EventArgs e)
        {
            OtoparkPersonel otoparkPersonel = new();
            otoparkPersonel.Show();
            this.Close();
        }
    }
}