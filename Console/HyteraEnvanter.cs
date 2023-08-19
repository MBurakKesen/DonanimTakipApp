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
    public partial class HyteraEnvanter : Form
    {
        public HyteraEnvanter()
        {
            InitializeComponent();
        }

        private void HyteraEnvanter_Load(object sender, EventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            HyteraUrunEkle ekle = new();
            ekle.Show();

        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new();
            anasayfa.Show();
            this.Close();
        }
    }
}
