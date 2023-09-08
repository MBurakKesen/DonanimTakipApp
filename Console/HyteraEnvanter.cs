using Bussiness;
using Console.Core.ExportFile;
using Console.Core.ImportExcel;
using Console.Core.QrOluştur;
using Entity.DTO;
using Entity.Models;
using Microsoft.EntityFrameworkCore.Metadata;
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
        List<HyteraDto> _list;
        List<HyteraDto> liste=new List<HyteraDto>();     
        public HyteraEnvanter()
        {
            InitializeComponent();
                }
        private void Refresh(List<HyteraDto> mainList)
        {
            _list = mainList;
            DataGridView view = HyteraEnvanterView;
            view.DataSource = _list;
            view.Columns["Id"].Visible = false;
        }
        private void HyteraEnvanter_Load(object sender, EventArgs e)
        {
            //List<HyteraDto> _list = _manager.GetHyteraDtos();
            DataGridView view = HyteraEnvanterView;
            //view.DataSource = _list;
            Refresh(_manager.GetHyteraDtos());

            //foreach (var item in _manager.GetHyteraDtos())
            //{
            //    view.Rows.Add(item.Id,item.SeriNo, item.IsimVeSoyisim, item.Yazici);
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
            this.Close();
            new HyteraEnvanter().Show();


        }
        private void DisaAktarBtn_Click(object sender, EventArgs e)
        {
            ExportFile.ExportFileToExcel(this.HyteraEnvanterView);
        }
        private void SilBtn_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow item in this.HyteraEnvanterView.SelectedRows)
            {
                _manager.Delete(new HyteraPerson
                {
                    Id= Convert.ToInt32(item.Cells[0].Value),
                    SeriNo = item.Cells[1].Value.ToString(),
                    IsimVeSoyisim = item.Cells[2].Value.ToString(),
                   
                });
            }

            MessageBox.Show("Silindi ");
           
        } 
        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = HyteraEnvanterView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = HyteraEnvanterView.Rows[selectedrowindex];
            string Id = selectedRow.Cells["Id"].Value.ToString();
            string SeriNo = Convert.ToString(selectedRow.Cells["SeriNo"].Value);
            string IsimVeSoyisim = selectedRow.Cells["IsimVeSoyisim"].Value.ToString();


            _manager.Update(new HyteraPerson { Id = Convert.ToInt32(Id), IsimVeSoyisim = IsimVeSoyisim, SeriNo = SeriNo });

            MessageBox.Show("Seçili Veri Güncellendi \n Yazıcı güncellemesi burdan yapılamaz");

           

        }           
        
        private void HyteraEnvanterView_Enter(object sender, EventArgs e)
        {
            int selectedrowindex = HyteraEnvanterView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = HyteraEnvanterView.Rows[selectedrowindex];
            string Id = selectedRow.Cells["Id"].Value.ToString();
            string SeriNo = Convert.ToString(selectedRow.Cells["SeriNo"].Value);
            string IsimVeSoyisim = selectedRow.Cells["IsimVeSoyisim"].Value.ToString();

            _manager.Update(new HyteraPerson { Id = Convert.ToInt32(Id), IsimVeSoyisim = IsimVeSoyisim, SeriNo = SeriNo });

            MessageBox.Show("Seçili Veri Güncellendi");
        }

        private void HyteraEnvanterView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QrBtn_Click(object sender, EventArgs e)
        {          
            string SeriNo="";
            foreach (DataGridViewRow item in this.HyteraEnvanterView.SelectedRows)
            {
                SeriNo = item.Cells[1].Value.ToString();
            }
            ;
            QRScreen screen = new(CreateQr.Create(SeriNo));

            screen.Show();
        }

        private void seriNumarasıTxt_TextChanged(object sender, EventArgs e)
        {         
            liste = _list.Where(p => p.SeriNo.ToString().StartsWith(seriNumarasıTxt.Text)).ToList();
            Refresh(liste);
        }
        private void isimVeSoyisimTxt_TextChanged(object sender, EventArgs e)
        {
            liste = _list.Where(p => p.IsimVeSoyisim.ToLower().StartsWith(isimVeSoyisimTxt.Text.ToLower())).ToList();
            Refresh(liste);
        }

        private void yaziciTxt_TextChanged(object sender, EventArgs e)
        {
            liste = _list.Where(p => p.Yazici.ToLower().StartsWith(yaziciTxt.Text.ToLower())).ToList();
            Refresh(liste);
            
        }
        private void temizleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new HyteraEnvanter().Show();
        }
    }
}
