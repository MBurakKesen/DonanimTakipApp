namespace Console
{
    partial class UcretliOnarimTakip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeriBtn = new System.Windows.Forms.Button();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arıza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YapilanIslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderilisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoTakipNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GarantiBitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalanSüreAy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalanSüreGün = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriBtn
            // 
            this.GeriBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(94, 29);
            this.GeriBtn.TabIndex = 0;
            this.GeriBtn.Text = "GERİ";
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Location = new System.Drawing.Point(248, 526);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(149, 76);
            this.GüncelleBtn.TabIndex = 1;
            this.GüncelleBtn.Text = "GÜNCELLE";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(77, 526);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(149, 76);
            this.EkleBtn.TabIndex = 2;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriNo,
            this.SENo,
            this.FormNo,
            this.Arıza,
            this.YapilanIslem,
            this.GonderilisTarihi,
            this.KargoTakipNumarasi,
            this.GelisTarihi,
            this.GarantiBitisTarihi,
            this.KalanSüreAy,
            this.KalanSüreGün});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(918, 445);
            this.dataGridView1.TabIndex = 3;
            // 
            // SeriNo
            // 
            this.SeriNo.HeaderText = "Seri No";
            this.SeriNo.MinimumWidth = 6;
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.Width = 125;
            // 
            // SENo
            // 
            this.SENo.HeaderText = "SE No";
            this.SENo.MinimumWidth = 6;
            this.SENo.Name = "SENo";
            this.SENo.Width = 125;
            // 
            // FormNo
            // 
            this.FormNo.HeaderText = "Form No";
            this.FormNo.MinimumWidth = 6;
            this.FormNo.Name = "FormNo";
            this.FormNo.Width = 125;
            // 
            // Arıza
            // 
            this.Arıza.HeaderText = "Arıza";
            this.Arıza.MinimumWidth = 6;
            this.Arıza.Name = "Arıza";
            this.Arıza.Width = 125;
            // 
            // YapilanIslem
            // 
            this.YapilanIslem.HeaderText = "Yapılan İşlem";
            this.YapilanIslem.MinimumWidth = 6;
            this.YapilanIslem.Name = "YapilanIslem";
            this.YapilanIslem.Width = 125;
            // 
            // GonderilisTarihi
            // 
            this.GonderilisTarihi.HeaderText = "Gönderiliş Tarihi";
            this.GonderilisTarihi.MinimumWidth = 6;
            this.GonderilisTarihi.Name = "GonderilisTarihi";
            this.GonderilisTarihi.Width = 125;
            // 
            // KargoTakipNumarasi
            // 
            this.KargoTakipNumarasi.HeaderText = "Kargo Takip Numarası";
            this.KargoTakipNumarasi.MinimumWidth = 6;
            this.KargoTakipNumarasi.Name = "KargoTakipNumarasi";
            this.KargoTakipNumarasi.Width = 125;
            // 
            // GelisTarihi
            // 
            this.GelisTarihi.HeaderText = "GelişTarihi";
            this.GelisTarihi.MinimumWidth = 6;
            this.GelisTarihi.Name = "GelisTarihi";
            this.GelisTarihi.Width = 125;
            // 
            // GarantiBitisTarihi
            // 
            this.GarantiBitisTarihi.HeaderText = "Garanti Bitiş Tarihi";
            this.GarantiBitisTarihi.MinimumWidth = 6;
            this.GarantiBitisTarihi.Name = "GarantiBitisTarihi";
            this.GarantiBitisTarihi.Width = 125;
            // 
            // KalanSüreAy
            // 
            this.KalanSüreAy.HeaderText = "Kalan Süre (Ay)";
            this.KalanSüreAy.MinimumWidth = 6;
            this.KalanSüreAy.Name = "KalanSüreAy";
            this.KalanSüreAy.Width = 125;
            // 
            // KalanSüreGün
            // 
            this.KalanSüreGün.HeaderText = "Kalan Süre (Gün)";
            this.KalanSüreGün.MinimumWidth = 6;
            this.KalanSüreGün.Name = "KalanSüreGün";
            this.KalanSüreGün.Width = 125;
            // 
            // UcretliOnarimTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.GüncelleBtn);
            this.Controls.Add(this.GeriBtn);
            this.Name = "UcretliOnarimTakip";
            this.Text = "UcretliOnarimTakip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button GeriBtn;
        private Button GüncelleBtn;
        private Button EkleBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SeriNo;
        private DataGridViewTextBoxColumn SENo;
        private DataGridViewTextBoxColumn FormNo;
        private DataGridViewTextBoxColumn Arıza;
        private DataGridViewTextBoxColumn YapilanIslem;
        private DataGridViewTextBoxColumn GonderilisTarihi;
        private DataGridViewTextBoxColumn KargoTakipNumarasi;
        private DataGridViewTextBoxColumn GelisTarihi;
        private DataGridViewTextBoxColumn GarantiBitisTarihi;
        private DataGridViewTextBoxColumn KalanSüreAy;
        private DataGridViewTextBoxColumn KalanSüreGün;
    }
}