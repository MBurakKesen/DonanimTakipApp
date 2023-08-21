using AppBussiness;
using Console.Core.ExportFile;
using Console.Core.ImportExcel;
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
    public partial class YaziciVeSeriNumaralari : Form
    {
        YaziciManager _manager;
        public YaziciVeSeriNumaralari()
        {
            InitializeComponent();
            _manager = new(new());

            var bindingList = new BindingList<Yazici>(_manager.GetAll());
            var source = new BindingSource(bindingList, null);
            YaziciDGV.DataSource = source;
        }

           
        private void IceriAktarBtn_Click(object sender, EventArgs e)
        {
            ImportExcel.AddYaziciDB(ImportExcel.readExcelForYazici());
        }

        private void DisariAktarBtn_Click(object sender, EventArgs e)
        {
            ExportFile.ExportFileToExcel(YaziciDGV);
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new();
            anasayfa.Show();
            this.Close();
        }
    }
}
