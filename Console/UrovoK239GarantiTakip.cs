using Bussiness;
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
    public partial class UrovoK239GarantiTakip : Form
    {
        UrovoOnarimService _manager = new(new());
        public UrovoK239GarantiTakip()
        {
            InitializeComponent();
        }

        private void UrovoK239GarantiTakip_Load(object sender, EventArgs e)
        {
           urovoOnarimDGV.DataSource= _manager.GetAll();
            urovoOnarimDGV.Columns["Id"].Visible= false;


            MessageBox.Show("Bu Sayfa Şu An Demo Versiyonundadır.");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new();
            anasayfa.Show();
            this.Close();
        }

        private void GonderBtn_Click(object sender, EventArgs e)
        {
            UrovoOnarimEkleme ekleme = new();
            ekleme.Show();
            this.Hide();
        }
    }
}
