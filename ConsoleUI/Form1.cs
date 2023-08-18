using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void htyeraEnvanter_Click(object sender, EventArgs e)
        {
            HyteraEnvanter hyteraEnvanter = new HyteraEnvanter();
            hyteraEnvanter.Show();
            this.Hide();
        }

        private void ucretliOnarimTakip_Click(object sender, EventArgs e)
        {
            UcretliOnarimTakip onarimTakip=new UcretliOnarimTakip();
            onarimTakip.Show();
            this.Hide();
        }

        private void urovaGarantiTakip_Click(object sender, EventArgs e)
        {
            UrovaK239GarantiTakip urovoTakip = new UrovaK239GarantiTakip();
            urovoTakip.Show();
            this.Hide();
        }

        private void urovo_Click(object sender, EventArgs e)
        {
            UrovoEnvanter urovoEnvanter=new UrovoEnvanter();
            urovoEnvanter.Show();
            this.Hide();
        }

        private void yazicilarVeSeriNo_Click(object sender, EventArgs e)
        {
            YazicilarVeSeriNumaraları yazicilarVeSeriNumaraları = new YazicilarVeSeriNumaraları();
            yazicilarVeSeriNumaraları.Show();
            this.Hide();
        }
    }
}
