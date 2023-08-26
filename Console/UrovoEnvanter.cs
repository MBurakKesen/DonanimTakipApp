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
    public partial class UrovoEnvanter
        : Form
    {
        YaziciManager _manager;
        public void ReturnData()
        {
            _manager = new(new());

            // var bindingList = new BindingList<Yazici>();
            var source = new System.Windows.Forms.BindingSource { DataSource = _manager.GetAll() };
            foreach (var item in _manager.GetAll())
            {
                source.Add(item);
            }

            YaziciDGV.DataSource = source;
        }
        public UrovoEnvanter()
        {
            InitializeComponent();
            ReturnData();
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

        private void UrovoEnvanter_Load(object sender, EventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            UrovoEnvanterYaziciEkleme ekleme = new();
            ekleme.Show();
           

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            List<Yazici> list = new();

            foreach (DataGridViewRow item in this.YaziciDGV.SelectedRows)
            {
                _manager.Delete(new Yazici
                {
                    Id = Convert.ToInt32(item.Cells[0].Value),
                    Marka = item.Cells[1].Value.ToString(),
                    Model = item.Cells[2].Value.ToString(),
                    TeslimTarih = Convert.ToDateTime(item.Cells[3].Value),
                    SeriNumarasi = item.Cells[4].Value.ToString()

                });


            };
            MessageBox.Show("Silindi");
            ReturnData();
        }

        private void YaziciDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
