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
            this.OnarımaGonderBtn = new System.Windows.Forms.Button();
            this.OnarimTakipDgv = new System.Windows.Forms.DataGridView();
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
            this.SilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OnarimTakipDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriBtn
            // 
            this.GeriBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(51, 29);
            this.GeriBtn.TabIndex = 0;
            this.GeriBtn.Text = "GERİ";
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GüncelleBtn.Location = new System.Drawing.Point(309, 1);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(149, 76);
            this.GüncelleBtn.TabIndex = 1;
            this.GüncelleBtn.Text = "GÜNCELLE";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            // 
            // OnarımaGonderBtn
            // 
            this.OnarımaGonderBtn.Location = new System.Drawing.Point(154, 1);
            this.OnarımaGonderBtn.Name = "OnarımaGonderBtn";
            this.OnarımaGonderBtn.Size = new System.Drawing.Size(149, 76);
            this.OnarımaGonderBtn.TabIndex = 2;
            this.OnarımaGonderBtn.Text = "GÖNDER";
            this.OnarımaGonderBtn.UseVisualStyleBackColor = true;
            this.OnarımaGonderBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // OnarimTakipDgv
            // 
            this.OnarimTakipDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OnarimTakipDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OnarimTakipDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OnarimTakipDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OnarimTakipDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.OnarimTakipDgv.Location = new System.Drawing.Point(-1, 83);
            this.OnarimTakipDgv.Name = "OnarimTakipDgv";
            this.OnarimTakipDgv.RowHeadersWidth = 51;
            this.OnarimTakipDgv.RowTemplate.Height = 29;
            this.OnarimTakipDgv.Size = new System.Drawing.Size(779, 385);
            this.OnarimTakipDgv.TabIndex = 3;
            this.OnarimTakipDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnarimTakipDgv_CellContentClick);
            // 
            // SeriNo
            // 
            this.SeriNo.HeaderText = "Seri No";
            this.SeriNo.MinimumWidth = 6;
            this.SeriNo.Name = "SeriNo";
            // 
            // SENo
            // 
            this.SENo.HeaderText = "SE No";
            this.SENo.MinimumWidth = 6;
            this.SENo.Name = "SENo";
            // 
            // FormNo
            // 
            this.FormNo.HeaderText = "Form No";
            this.FormNo.MinimumWidth = 6;
            this.FormNo.Name = "FormNo";
            // 
            // Arıza
            // 
            this.Arıza.HeaderText = "Arıza";
            this.Arıza.MinimumWidth = 6;
            this.Arıza.Name = "Arıza";
            // 
            // YapilanIslem
            // 
            this.YapilanIslem.HeaderText = "Yapılan İşlem";
            this.YapilanIslem.MinimumWidth = 6;
            this.YapilanIslem.Name = "YapilanIslem";
            // 
            // GonderilisTarihi
            // 
            this.GonderilisTarihi.HeaderText = "Gönderiliş Tarihi";
            this.GonderilisTarihi.MinimumWidth = 6;
            this.GonderilisTarihi.Name = "GonderilisTarihi";
            // 
            // KargoTakipNumarasi
            // 
            this.KargoTakipNumarasi.HeaderText = "Kargo Takip Numarası";
            this.KargoTakipNumarasi.MinimumWidth = 6;
            this.KargoTakipNumarasi.Name = "KargoTakipNumarasi";
            // 
            // GelisTarihi
            // 
            this.GelisTarihi.HeaderText = "GelişTarihi";
            this.GelisTarihi.MinimumWidth = 6;
            this.GelisTarihi.Name = "GelisTarihi";
            // 
            // GarantiBitisTarihi
            // 
            this.GarantiBitisTarihi.HeaderText = "Garanti Bitiş Tarihi";
            this.GarantiBitisTarihi.MinimumWidth = 6;
            this.GarantiBitisTarihi.Name = "GarantiBitisTarihi";
            // 
            // KalanSüreAy
            // 
            this.KalanSüreAy.HeaderText = "Kalan Süre (Ay)";
            this.KalanSüreAy.MinimumWidth = 6;
            this.KalanSüreAy.Name = "KalanSüreAy";
            // 
            // KalanSüreGün
            // 
            this.KalanSüreGün.HeaderText = "Kalan Süre (Gün)";
            this.KalanSüreGün.MinimumWidth = 6;
            this.KalanSüreGün.Name = "KalanSüreGün";
            // 
            // SilBtn
            // 
            this.SilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SilBtn.Location = new System.Drawing.Point(464, 1);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(149, 76);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // UcretliOnarimTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 470);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.OnarimTakipDgv);
            this.Controls.Add(this.OnarımaGonderBtn);
            this.Controls.Add(this.GüncelleBtn);
            this.Controls.Add(this.GeriBtn);
            this.Name = "UcretliOnarimTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcretliOnarimTakip";
            this.TransparencyKey = System.Drawing.Color.Teal;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UcretliOnarimTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OnarimTakipDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button GeriBtn;
        private Button GüncelleBtn;
        private Button OnarımaGonderBtn;
        private DataGridView OnarimTakipDgv;
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
        private Button SilBtn;
    }
}