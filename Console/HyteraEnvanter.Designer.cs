namespace Console
{
    partial class HyteraEnvanter
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
            this.ImportBtn = new System.Windows.Forms.Button();
            this.DisaAktarBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsimVeSoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazici = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(358, 54);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(94, 29);
            this.ImportBtn.TabIndex = 1;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            // 
            // DisaAktarBtn
            // 
            this.DisaAktarBtn.Location = new System.Drawing.Point(473, 54);
            this.DisaAktarBtn.Name = "DisaAktarBtn";
            this.DisaAktarBtn.Size = new System.Drawing.Size(94, 29);
            this.DisaAktarBtn.TabIndex = 2;
            this.DisaAktarBtn.Text = "Dışa Aktar";
            this.DisaAktarBtn.UseVisualStyleBackColor = true;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(676, 115);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(94, 29);
            this.EkleBtn.TabIndex = 3;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(676, 254);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(94, 29);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Location = new System.Drawing.Point(676, 389);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(94, 29);
            this.GuncelleBtn.TabIndex = 5;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriNo,
            this.IsimVeSoyisim,
            this.Yazici});
            this.dataGridView1.Location = new System.Drawing.Point(31, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(621, 358);
            this.dataGridView1.TabIndex = 7;
            // 
            // SeriNo
            // 
            this.SeriNo.HeaderText = "Seri No";
            this.SeriNo.MinimumWidth = 6;
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.Width = 200;
            // 
            // IsimVeSoyisim
            // 
            this.IsimVeSoyisim.HeaderText = "İsim ve Soyisim";
            this.IsimVeSoyisim.MinimumWidth = 6;
            this.IsimVeSoyisim.Name = "IsimVeSoyisim";
            this.IsimVeSoyisim.Width = 200;
            // 
            // Yazici
            // 
            this.Yazici.HeaderText = "Yazıcı";
            this.Yazici.MinimumWidth = 6;
            this.Yazici.Name = "Yazici";
            this.Yazici.Width = 200;
            // 
            // HyteraEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.DisaAktarBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.GeriBtn);
            this.Name = "HyteraEnvanter";
            this.Text = "HyteraEnvanter";
            this.Load += new System.EventHandler(this.HyteraEnvanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button GeriBtn;
        private Button ImportBtn;
        private Button DisaAktarBtn;
        private Button EkleBtn;
        private Button SilBtn;
        private Button GuncelleBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SeriNo;
        private DataGridViewTextBoxColumn IsimVeSoyisim;
        private DataGridViewTextBoxColumn Yazici;
    }
}