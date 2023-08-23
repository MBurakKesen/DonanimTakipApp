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
    public partial class QRScreen : Form
    {
        Bitmap bitmap;
        public QRScreen(Bitmap bitmap)
        {

            InitializeComponent();
            this.bitmap = bitmap;
        }

        private void QRScreen_Load(object sender, EventArgs e)
        {
            QrPic.Image = bitmap;
        }

        private void QrPic_Click(object sender, EventArgs e)
        {
           
        }
    }
}
