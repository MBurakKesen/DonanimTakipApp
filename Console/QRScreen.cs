using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class QRScreen : CustomForm
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
            //CaptureScreen();
            //qrPrint.Print();
            //qrPrint.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            base.PrintForm();
            this.Close();
        }

        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawImage(bitmap, 0, 0);
        //}
        //private void CaptureScreen()
        //{
        //    Graphics myGraphics = this.CreateGraphics();
        //    Size s = this.Size;
        //    bitmap = new Bitmap(s.Width, s.Height, myGraphics);
        //    Graphics memoryGraphics = Graphics.FromImage(bitmap);
        //    memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        //}
    }
    public class CustomForm : Form
    {
        protected Bitmap _prnImage;
        protected PrintPreviewDialog _prnpreviewdlg = new PrintPreviewDialog();
        protected PrintDocument _printdoc = new PrintDocument();

        public CustomForm()
        {
            _printdoc.PrintPage += new PrintPageEventHandler(printdoc_PrintPage);
        }

        protected void PrintForm()
        {
            Form form = this;
            _prnImage = new Bitmap(form.Width, form.Height);
            form.DrawToBitmap(_prnImage, new Rectangle(0, 0, form.Width, form.Height));
            _printdoc.DefaultPageSettings.Landscape = true;
            _printdoc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            _prnpreviewdlg.Document = _printdoc;
            _prnpreviewdlg.ShowDialog();
        }
        protected void printdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(_prnImage, e.MarginBounds);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_prnImage != null)
            {
                e.Graphics.DrawImage(_prnImage, 0, 0);
                base.OnPaint(e);
            }
        }
    }
}
