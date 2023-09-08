using AppBussiness;
using Console.Core.ExportFile;
using Console.Core.ImportExcel;
using DataAccess;
using Entity.Models;
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
        YaziciVeSeriNumaralariManager _Manager = new(new());
        DataGridView view;
        public YaziciVeSeriNumara()
        {
            InitializeComponent();

        }



        private void YaziciVeSeriNumara_Load(object sender, EventArgs e)
        {
            view = YaziciVeSeriNumaralariDGV;
            YaziciVeSeriNumaralariDGV.DataSource = _Manager.GetDeatails();
            view.Columns["Id"].Visible = false;
           

        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void IceriAktarBtn_Click(object sender, EventArgs e)
        {
            ImportExcel.AddYaziciVeSeriNumaralariDb(ImportExcel.readExcelForYaziciVeSeriNumaralari());
            this.Close();
            new YaziciVeSeriNumara().Show(); 
        }

        private void DısarıAktarBtn_Click(object sender, EventArgs e)
        {
            ExportFile.ExportFileToExcel(YaziciVeSeriNumaralariDGV);
        }

        private void YaziciVeSeriNumaralariDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            YaziciVeSeriNumaralarıEkleme yaziciVeSeriNumaraEkleme = new();
            yaziciVeSeriNumaraEkleme.Show();
            this.Close();


        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            List<YaziciVeSeriNumaralari> list = new();

            foreach (DataGridViewRow item in this.YaziciVeSeriNumaralariDGV.SelectedRows)
            {
                YaziciVeSeriNumaralari yaziciVeSeriNumara = new YaziciVeSeriNumaralari
                {
                    Id = Convert.ToInt32(item.Cells[0].Value),
                    Personel = item.Cells[2].Value.ToString(),
                    Amir = item.Cells[3].Value.ToString(),
                    Yazici = item.Cells[4].Value.ToString(),
                    SeriNumarasi = item.Cells[5].Value.ToString()

                };
                list.Add(yaziciVeSeriNumara);


            }
            foreach (YaziciVeSeriNumaralari person in list)
            {
                _Manager.Delete(person);
            }

            MessageBox.Show("Silindi ");
        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = YaziciVeSeriNumaralariDGV.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = YaziciVeSeriNumaralariDGV.Rows[selectedrowindex];
            int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            string SicilNo = selectedRow.Cells["SicilNo"].Value?.ToString() ?? " ";
            string Personel = selectedRow.Cells["Personel"].Value.ToString();
            string Amir = selectedRow.Cells["Amir"].Value.ToString();
            string Yazi = selectedRow.Cells["Yazici"].Value.ToString();
            string SeriNumarasi = selectedRow.Cells["SeriNumarasi"].Value.ToString();

            _Manager.Update(new YaziciVeSeriNumaralari { Id = Id, Personel = Personel, Amir = Amir, SeriNumarasi = SeriNumarasi, Yazici= Yazi });

            MessageBox.Show("Seçili Veri Güncellendi");
        }
    }
}
