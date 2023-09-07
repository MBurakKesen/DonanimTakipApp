using AppBussiness;
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
    public partial class YaziciVeSeriNumaralarıEkleme : Form
    {
        YaziciVeSeriNumaralariManager _manager = new(new());
        public YaziciVeSeriNumaralarıEkleme()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            YaziciVeSeriNumara numara = new();
            numara.Show();
            this.Close();
        }

        private void YaziciVeSeriNumaralarıEkleme_Load(object sender, EventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                YaziciVeSeriNumaralari yaziciVeSeriNumaralari = new();
                yaziciVeSeriNumaralari.Amir = AmirTxt.Text;
                yaziciVeSeriNumaralari.SeriNumarasi = SeriNumarasiTxt.Text;
                yaziciVeSeriNumaralari.Personel = PersonelTxt.Text;
                yaziciVeSeriNumaralari.SicilNo = SicilNotxt.Text;
                yaziciVeSeriNumaralari.Yazici = YaziciCbx.Text;

                _manager.Add(yaziciVeSeriNumaralari);

                MessageBox.Show("Eklendi");
                this.Close();
                new YaziciVeSeriNumara().Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
                throw;
            }
        }
    }
}
