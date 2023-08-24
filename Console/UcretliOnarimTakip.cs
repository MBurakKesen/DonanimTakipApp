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
    public partial class UcretliOnarimTakip : Form
    {
        public UcretliOnarimTakip()
        {
            InitializeComponent();
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa= new();
            anasayfa.Show();
            this.Close();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            UcretliOnarimUrunEkleme ekleme = new();
            ekleme.Show();

        }

        private void UcretliOnarimTakip_Load(object sender, EventArgs e)
        {

        }
    }
}
