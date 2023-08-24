namespace Console
{
    partial class YaziciVeSeriNumara
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
            this.SilBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.IceriAktarBtn = new System.Windows.Forms.Button();
            this.DısarıAktarBtn = new System.Windows.Forms.Button();
            this.YaziciVeSeriNumaralariDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.YaziciVeSeriNumaralariDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriBtn
            // 
            this.GeriBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(65, 29);
            this.GeriBtn.TabIndex = 1;
            this.GeriBtn.Text = "GERİ";
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SilBtn.Location = new System.Drawing.Point(349, 431);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(92, 29);
            this.SilBtn.TabIndex = 2;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EkleBtn.Location = new System.Drawing.Point(84, 431);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(92, 29);
            this.EkleBtn.TabIndex = 3;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GüncelleBtn.Location = new System.Drawing.Point(631, 431);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(94, 29);
            this.GüncelleBtn.TabIndex = 4;
            this.GüncelleBtn.Text = "GÜNCELLE";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // IceriAktarBtn
            // 
            this.IceriAktarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IceriAktarBtn.Location = new System.Drawing.Point(420, 12);
            this.IceriAktarBtn.Name = "IceriAktarBtn";
            this.IceriAktarBtn.Size = new System.Drawing.Size(99, 29);
            this.IceriAktarBtn.TabIndex = 5;
            this.IceriAktarBtn.Text = "İçeri Aktar";
            this.IceriAktarBtn.UseVisualStyleBackColor = true;
            this.IceriAktarBtn.Click += new System.EventHandler(this.IceriAktarBtn_Click);
            // 
            // DısarıAktarBtn
            // 
            this.DısarıAktarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DısarıAktarBtn.Location = new System.Drawing.Point(588, 12);
            this.DısarıAktarBtn.Name = "DısarıAktarBtn";
            this.DısarıAktarBtn.Size = new System.Drawing.Size(97, 29);
            this.DısarıAktarBtn.TabIndex = 6;
            this.DısarıAktarBtn.Text = "Dışarı Aktar";
            this.DısarıAktarBtn.UseVisualStyleBackColor = true;
            this.DısarıAktarBtn.Click += new System.EventHandler(this.DısarıAktarBtn_Click);
            // 
            // YaziciVeSeriNumaralariDGV
            // 
            this.YaziciVeSeriNumaralariDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YaziciVeSeriNumaralariDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YaziciVeSeriNumaralariDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YaziciVeSeriNumaralariDGV.Location = new System.Drawing.Point(12, 61);
            this.YaziciVeSeriNumaralariDGV.Name = "YaziciVeSeriNumaralariDGV";
            this.YaziciVeSeriNumaralariDGV.RowHeadersWidth = 51;
            this.YaziciVeSeriNumaralariDGV.RowTemplate.Height = 29;
            this.YaziciVeSeriNumaralariDGV.Size = new System.Drawing.Size(779, 349);
            this.YaziciVeSeriNumaralariDGV.TabIndex = 7;
            this.YaziciVeSeriNumaralariDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YaziciVeSeriNumaralariDGV_CellContentClick);
            // 
            // YaziciVeSeriNumara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 486);
            this.Controls.Add(this.YaziciVeSeriNumaralariDGV);
            this.Controls.Add(this.DısarıAktarBtn);
            this.Controls.Add(this.IceriAktarBtn);
            this.Controls.Add(this.GüncelleBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.GeriBtn);
            this.Name = "YaziciVeSeriNumara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YaziciVeSeriNumara";
            this.Load += new System.EventHandler(this.YaziciVeSeriNumara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YaziciVeSeriNumaralariDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button GeriBtn;
        private Button SilBtn;
        private Button EkleBtn;
        private Button GüncelleBtn;
        private Button IceriAktarBtn;
        private Button DısarıAktarBtn;
        private DataGridView YaziciVeSeriNumaralariDGV;
    }
}