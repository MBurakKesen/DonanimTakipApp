using AppBussiness;
using Console.Core.ImportExcel;
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
    public partial class OtoparkPersonel : Form
    {
        OtoparkManager _manager = new(new());
        public OtoparkPersonel()
        {
            InitializeComponent();
            otoparkDgv.DataSource= _manager.GetAll();
            otoparkDgv.Columns["Id"].Visible = false;
        }

        private void geriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new();
            anasayfa.Show();
            this.Close();
        }

         

        private void iceriAktarBtn_Click(object sender, EventArgs e)
        {
            ImportExcel.AddDbForOtopark(ImportExcel.readExcelForOtopark());
        }

        private void OtoparkPersonel_Load(object sender, EventArgs e)
        {

        }

        private void disariAktarBtn_Click(object sender, EventArgs e)
        {

        }

        private void eklemeBtn_Click(object sender, EventArgs e)
        {

        }

        private void silBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
