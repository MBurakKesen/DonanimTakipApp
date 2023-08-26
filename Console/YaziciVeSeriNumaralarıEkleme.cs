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
        public YaziciVeSeriNumaralarıEkleme()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        }
    }
}
