using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class YazicilarVeSeriNumaraları : Form
    {
        public YazicilarVeSeriNumaraları()
        {
            InitializeComponent();
        }

        private void YazicilarVeSeriNumaraları_Load(object sender, EventArgs e)
        {

        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}
