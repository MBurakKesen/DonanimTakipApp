using Bussiness;
using Console.Core.ExportFile;
using Console.Core.ImportExcel;
using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class HyteraEnvanter : Form
    {
        HyteraPersonManager _manager = new(new());
        DataGridView view;
        public HyteraEnvanter()
        {
            InitializeComponent();
        }
        private void HyteraEnvanter_Load(object sender, EventArgs e)
        {
            view = HyteraEnvanterView;
            view.DataSource= _manager.GetAll();
            //foreach (var item in _manager.GetAll())
            //{
            //    view.Rows.Add(item.Id, item.SeriNo, item.IsimVeSoyisim, item.Yazici);
            //}
        }
        private void EkleBtn_Click(object sender, EventArgs e)
        {
            HyteraUrunEkle ekle = new();
            ekle.Show();
        }
        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new();
            anasayfa.Show();
            this.Close();
        }
        private void ImportBtn_Click(object sender, EventArgs e)
        {
            ImportExcel.AddDB(ImportExcel.readExcel());
        }
        private void DisaAktarBtn_Click(object sender, EventArgs e)
        {
            ExportFile.ExportFileToExcel(this.HyteraEnvanterView);
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            HyteraPerson person = new();

            foreach (DataGridViewRow item in this.HyteraEnvanterView.SelectedRows)
            {
                person.Id =Convert.ToInt32(item.Cells[0].Value);
                person.SeriNo = item.Cells[1].Value.ToString();
                person.IsimVeSoyisim = item.Cells[2].Value.ToString();
            }

            _manager.Delete(person);
            MessageBox.Show("Silindi " + person.IsimVeSoyisim);
           
        }

        
    }
}
