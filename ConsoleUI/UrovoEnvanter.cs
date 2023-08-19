using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class UrovoEnvanter : Form
    {
        public UrovoEnvanter()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void YaziciEklemeBtn_Click(object sender, EventArgs e)
        {
            UrovoEnvanterYaziciEkleme urovoEnvanterYaziciEkleme = new UrovoEnvanterYaziciEkleme();
            urovoEnvanterYaziciEkleme.Show();
        }
    }
}
