﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsoleUI
{
    public partial class UrovaK239GarantiTakip : Form
    {
        public UrovaK239GarantiTakip()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}
