using Bussiness;
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
    public partial class HyteraUrunEkle : Form
    {

        HyteraPerson hPerson = new();
        HyteraPersonManager manager;
        public HyteraUrunEkle()
        {
            InitializeComponent();
        }

        private void HyteraUrunEkle_Load(object sender, EventArgs e)
        {
            manager = new(new());
           
        }

        private void GönderBtn_Click(object sender, EventArgs e)
        {
            hPerson.SeriNo = SeriNoTxt.Text;
            hPerson.IsimVeSoyisim = IsimVeSoyisimTxt.Text;
            manager.Add(hPerson);
            MessageBox.Show("Eklendi");
            this.Close();
            
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            YaziciVeSeriNumara yaziciVeSeriNumara = new();
            yaziciVeSeriNumara.Show();

        }
    }
}
