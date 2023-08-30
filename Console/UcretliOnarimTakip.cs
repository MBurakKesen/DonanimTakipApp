using AppBussiness;
using Console.Core;
using DataAccess;
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
    public partial class UcretliOnarimTakip : Form
    {
        OnarimManager _manager = new(new());
        public UcretliOnarimTakip()
        {
            InitializeComponent();
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new();
            anasayfa.Show();
            this.Close();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            UcretliOnarimUrunEkleme ekleme = new();
            ekleme.Show();
            this.Close();
            

        }


        private void UcretliOnarimTakip_Load(object sender, EventArgs e)
        {
            foreach (var item in _manager.GetAll())
            {
                OnarimTakipDgv.Rows.Add(item.SeriNo, item.SENo, item.FormNo, item.Ariza, item.YapilanIslem, item.GonderilisTarihi.ToString().Substring(0, item.GonderilisTarihi.ToString().IndexOf(" ")), item.KargoTakipNo, item.GelisTarihi.ToString().Substring(0, item.GelisTarihi.ToString().IndexOf(" ")), item.GarantiBitisTarihi.ToString().Substring(0,item.GarantiBitisTarihi.ToString().IndexOf(" ")), MakeMount(item.GarantiBitisTarihi - DateTime.UtcNow), MakeDay(item.GarantiBitisTarihi - DateTime.UtcNow), item.Id);

            }

        }


        private void OnarimTakipDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnarimTakipDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void OnarimTakipDgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(OnarimTakipDgv.Rows[e.RowIndex].Cells[9].Value) < 1)
            {
                OnarimTakipDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
            }
            else
            {
                OnarimTakipDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }


        public int MakeMount(TimeSpan years)
        {
            if (years.TotalDays > 30)
            {
                return Convert.ToInt32(years.TotalDays / 30)-1;
            }
            return 0;
        }
        public int MakeDay(TimeSpan years)
        {

            if (years.TotalDays > 30)
            {
                return Convert.ToInt32(years.TotalDays % 30);
            }
            if (years.TotalDays <= 0)
                return 0;
            return Convert.ToInt32(years.TotalDays);

        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {

            int selectedrowindex = OnarimTakipDgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = OnarimTakipDgv.Rows[selectedrowindex];

            int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            int SENo = Convert.ToInt32(selectedRow.Cells["SENo"].Value);
            string SeriNo = selectedRow.Cells["SeriNo"].Value.ToString();
            int FormNo = Convert.ToInt32(selectedRow.Cells["FormNo"].Value);
            string Ariza = selectedRow.Cells["Ariza"].Value.ToString();
            string YapilanIslem = selectedRow.Cells["YapilanIslem"].Value.ToString();
            DateTime GonderilisTarihi = Convert.ToDateTime(selectedRow.Cells["GonderilisTarihi"].Value).Date;
            int KargoTakipNo = Convert.ToInt32(selectedRow.Cells["KargoTakipNumarasi"].Value);
            DateTime GelisTarihi = Convert.ToDateTime(selectedRow.Cells["GelisTarihi"].Value).Date;
            DateTime GarantiBitisTarihi = Convert.ToDateTime(selectedRow.Cells["GarantiBitisTarihi"].Value).Date;

            int KalanSureGun = Convert.ToInt32(selectedRow.Cells["KalanSureGun"].Value);
            int KalanSureAy = Convert.ToInt32(selectedRow.Cells["KalanSureAy"].Value);



            _manager.Update(new Onarim { Id = Id, SENo = SENo, SeriNo = SeriNo, FormNo = FormNo, Ariza = Ariza, YapilanIslem = YapilanIslem, GonderilisTarihi = GonderilisTarihi, KargoTakipNo = KargoTakipNo, GelisTarihi = GelisTarihi, GarantiBitisTarihi = GarantiBitisTarihi, KalanSureGun = KalanSureGun, KalanSureAy = KalanSureAy }
            );

            MessageBox.Show("Seçili Veri Güncellendi ");
            new UcretliOnarimTakip().Show();
            this.Close();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = OnarimTakipDgv.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = OnarimTakipDgv.Rows[selectedrowindex];

            int Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            int SENo = Convert.ToInt32(selectedRow.Cells["SENo"].Value);
            string SeriNo = selectedRow.Cells["SeriNo"].Value.ToString();
            int FormNo = Convert.ToInt32(selectedRow.Cells["FormNo"].Value);
            string Ariza = selectedRow.Cells["Ariza"].Value.ToString();
            string YapilanIslem = selectedRow.Cells["YapilanIslem"].Value.ToString();
            DateTime GonderilisTarihi = Convert.ToDateTime(selectedRow.Cells["GonderilisTarihi"].Value).Date;
            int KargoTakipNo = Convert.ToInt32(selectedRow.Cells["KargoTakipNumarasi"].Value);
            DateTime GelisTarihi = Convert.ToDateTime(selectedRow.Cells["GelisTarihi"].Value).Date;
            DateTime GarantiBitisTarihi = Convert.ToDateTime(selectedRow.Cells["GarantiBitisTarihi"].Value).Date;

            int KalanSureGun = Convert.ToInt32(selectedRow.Cells["KalanSureGun"].Value);
            int KalanSureAy = Convert.ToInt32(selectedRow.Cells["KalanSureAy"].Value);

            foreach (DataGridViewRow item in this.OnarimTakipDgv.SelectedRows)
            {
                _manager.Delete(new Onarim { Id = Id, SENo = SENo, SeriNo = SeriNo, FormNo = FormNo, Ariza = Ariza, YapilanIslem = YapilanIslem, GonderilisTarihi = GonderilisTarihi, KargoTakipNo = KargoTakipNo, GelisTarihi = GelisTarihi, GarantiBitisTarihi = GarantiBitisTarihi, KalanSureGun = KalanSureGun, KalanSureAy = KalanSureAy });
            }

            MessageBox.Show("Silindi ");
            new UcretliOnarimTakip().Show();
            this.Close();
        }
    }
}
