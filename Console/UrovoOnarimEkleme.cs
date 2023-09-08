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
    public partial class UrovoOnarimEkleme : Form
    {
        public UrovoOnarimEkleme()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new UrovoK239GarantiTakip().Show();
        }
    }
}
