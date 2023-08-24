using AppBussiness;
using Console.Core;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class UrovoEnvanterYaziciEkleme : Form
    {
        YaziciManager manager = new(new());
        UrovoEnvanter envanter = new();

        Yazici yazici;
        public UrovoEnvanterYaziciEkleme()
        {
            InitializeComponent();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {

            yazici = new Yazici
            {
                Marka = MarkaCbx.Text?.ToString(),
                Model = ModelTxt.Text?.ToString(),
                TeslimTarih = TeslimTarihiDtp.Value,
                SeriNumarasi = SeriNumarasıTxt.Text?.ToString()
            };

            manager.Add(yazici);
            MessageBox.Show("Yazıcı eklendi");
            
            envanter.Show();
            this.Close();

        }

        private void UrovoEnvanterYaziciEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}


