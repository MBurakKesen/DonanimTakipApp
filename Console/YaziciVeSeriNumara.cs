using AppBussiness;
using Console.Core.ImportExcel;
using DataAccess;
using Microsoft.Office.Interop.Excel;
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
    public partial class YaziciVeSeriNumara : Form
    {
        YaziciVeSeriNumaralariManager _yaziciVeSeriNumaralariManager = new(new());
        DataGridView view;
        public YaziciVeSeriNumara()
        {
            InitializeComponent();

        }

        

        private void YaziciVeSeriNumara_Load(object sender, EventArgs e)
        {
            view = YaziciVeSeriNumaralariDGV;
            YaziciVeSeriNumaralariDGV.DataSource = _yaziciVeSeriNumaralariManager.GetAll();
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa= new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void IceriAktarBtn_Click(object sender, EventArgs e)
        {
            ImportExcel.AddYaziciVeSeriNumaralariDb(ImportExcel.readExcelForYaziciVeSeriNumaralari());
        }
    }
}
