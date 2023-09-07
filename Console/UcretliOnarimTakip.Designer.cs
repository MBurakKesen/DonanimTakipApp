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
            this.Ariza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YapilanIslem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderilisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KargoTakipNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GarantiBitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalanSureAy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KalanSureGun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SilBtn = new System.Windows.Forms.Button();
            this.bildiri1Lbl = new System.Windows.Forms.Label();
            this.bildiri2Lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.GüncelleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GüncelleBtn.Location = new System.Drawing.Point(952, 178);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(101, 63);
            this.GüncelleBtn.TabIndex = 1;
            this.GüncelleBtn.Text = "GÜNCELLE";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // OnarımaGonderBtn
            // 
            this.OnarımaGonderBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OnarımaGonderBtn.Location = new System.Drawing.Point(952, 52);
            this.OnarımaGonderBtn.Name = "OnarımaGonderBtn";
            this.OnarımaGonderBtn.Size = new System.Drawing.Size(101, 63);
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
            this.Ariza,
            this.YapilanIslem,
            this.GonderilisTarihi,
            this.KargoTakipNumarasi,
            this.GelisTarihi,
            this.GarantiBitisTarihi,
            this.KalanSureAy,
            this.KalanSureGun,
            this.Id});
            this.OnarimTakipDgv.Location = new System.Drawing.Point(-1, 83);
            this.OnarimTakipDgv.Name = "OnarimTakipDgv";
            this.OnarimTakipDgv.RowHeadersWidth = 51;
            this.OnarimTakipDgv.RowTemplate.Height = 29;
            this.OnarimTakipDgv.Size = new System.Drawing.Size(947, 453);
            this.OnarimTakipDgv.TabIndex = 3;
            this.OnarimTakipDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnarimTakipDgv_CellContentClick);
            this.OnarimTakipDgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.OnarimTakipDgv_RowPrePaint);
            this.OnarimTakipDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnarimTakipDgv_RowsAdded);
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
            // Ariza
            // 
            this.Ariza.HeaderText = "Arıza";
            this.Ariza.MinimumWidth = 6;
            this.Ariza.Name = "Ariza";
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
            // KalanSureAy
            // 
            this.KalanSureAy.HeaderText = "Kalan Süre (Ay)";
            this.KalanSureAy.MinimumWidth = 6;
            this.KalanSureAy.Name = "KalanSureAy";
            // 
            // KalanSureGun
            // 
            this.KalanSureGun.HeaderText = "Kalan Süre (Gün)";
            this.KalanSureGun.MinimumWidth = 6;
            this.KalanSureGun.Name = "KalanSureGun";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SilBtn
            // 
            this.SilBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SilBtn.Location = new System.Drawing.Point(952, 302);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(101, 64);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // bildiri1Lbl
            // 
            this.bildiri1Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bildiri1Lbl.AutoSize = true;
            this.bildiri1Lbl.BackColor = System.Drawing.Color.IndianRed;
            this.bildiri1Lbl.Location = new System.Drawing.Point(678, 9);
            this.bildiri1Lbl.Name = "bildiri1Lbl";
            this.bildiri1Lbl.Size = new System.Drawing.Size(55, 20);
            this.bildiri1Lbl.TabIndex = 5;
            this.bildiri1Lbl.Text = "Kırmızı";
            // 
            // bildiri2Lbl
            // 
            this.bildiri2Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bildiri2Lbl.AutoSize = true;
            this.bildiri2Lbl.Location = new System.Drawing.Point(736, 8);
            this.bildiri2Lbl.Name = "bildiri2Lbl";
            this.bildiri2Lbl.Size = new System.Drawing.Size(200, 20);
            this.bildiri2Lbl.TabIndex = 6;
            this.bildiri2Lbl.Text = "Garanti Süresi Bitmek Üzere !";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(952, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dışarı Aktar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(952, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "İçeri Aktar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UcretliOnarimTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bildiri2Lbl);
            this.Controls.Add(this.bildiri1Lbl);
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
            this.PerformLayout();

        }

        #endregion

        private Button GeriBtn;
        private Button GüncelleBtn;
        private Button OnarımaGonderBtn;
        private DataGridView OnarimTakipDgv;
        private Button SilBtn;
        private DataGridViewTextBoxColumn SeriNo;
        private DataGridViewTextBoxColumn SENo;
        private DataGridViewTextBoxColumn FormNo;
        private DataGridViewTextBoxColumn Ariza;
        private DataGridViewTextBoxColumn YapilanIslem;
        private DataGridViewTextBoxColumn GonderilisTarihi;
        private DataGridViewTextBoxColumn KargoTakipNumarasi;
        private DataGridViewTextBoxColumn GelisTarihi;
        private DataGridViewTextBoxColumn GarantiBitisTarihi;
        private DataGridViewTextBoxColumn KalanSureAy;
        private DataGridViewTextBoxColumn KalanSureGun;
        private DataGridViewTextBoxColumn Id;
        private Label bildiri1Lbl;
        private Label bildiri2Lbl;
        private Button button1;
        private Button button2;
    }
}