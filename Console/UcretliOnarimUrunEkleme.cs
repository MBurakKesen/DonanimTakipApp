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
        public UcretliOnarimUrunEkleme()
        {
            InitializeComponent();
        }

        private void UcretliOnarimUrunEkleme_Load(object sender, EventArgs e)
        {

        }

        private void GonderBtn_Click(object sender, EventArgs e)
        {
            Onarim onarim= new Onarim();
            onarim.Ariza = ArizaCbx.Text;
            this.Close();
        }

        private void GelişTarihiDtp_MouseHover(object sender, EventArgs e)
        {
            OptionalLbl.Visible = true;
        }
    }
}
