﻿using AppBussiness;
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
    public partial class UcretliOnarimUrunEkleme : Form
    {
        OnarimManager _manager = new(new());
        Onarim onarim = new Onarim();
        public UcretliOnarimUrunEkleme()
        {
            InitializeComponent();
        }

        private void UcretliOnarimUrunEkleme_Load(object sender, EventArgs e)
        {

        }

        private void GonderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Onarim onarim = new Onarim();
                onarim.Ariza = ArizaCbx.Text;
                onarim.FormNo = Convert.ToInt32(FormNoTxt.Text);
                onarim.YapilanIslem = YapilanIslemCbx.Text;
                onarim.GonderilisTarihi = GonderilisTarihiDtp.Value.Date;

                onarim.KargoTakipNo = Convert.ToInt32(KargoTakipNoTxt.Text);
                onarim.SeriNo = SeriNoTxt.Text;
                onarim.SENo = Convert.ToInt32(SENoTxt.Text);
                onarim.GelisTarihi = GelişTarihiDtp.Value.Date;
                onarim.GarantiBitisTarihi = GarantiBitisSuresiDtp.Value.Date;
                onarim.KalanSureAy = 0;
                onarim.KalanSureGun = 0;

                AddOnarimDb(onarim);
                MessageBox.Show("Garantiye Gönderildi");
                new UcretliOnarimTakip().Show();
                this.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("form doğru doldurulmadı");
             
            }

        }
       

       

        private void GelişTarihiDtp_MouseHover(object sender, EventArgs e)
        {
        }
        private void AddOnarimDb(Onarim onarim)
        {
            _manager.Add(onarim);
        }
    }
}
