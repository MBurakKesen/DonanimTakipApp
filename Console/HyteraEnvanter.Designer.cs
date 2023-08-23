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
            this.HyteraEnvanterView = new System.Windows.Forms.DataGridView();
            this.QrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HyteraEnvanterView)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriBtn
            // 
            this.GeriBtn.AutoSize = true;
            this.GeriBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(50, 30);
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
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // DisaAktarBtn
            // 
            this.DisaAktarBtn.Location = new System.Drawing.Point(562, 54);
            this.DisaAktarBtn.Name = "DisaAktarBtn";
            this.DisaAktarBtn.Size = new System.Drawing.Size(94, 29);
            this.DisaAktarBtn.TabIndex = 2;
            this.DisaAktarBtn.Text = "Dışa Aktar";
            this.DisaAktarBtn.UseVisualStyleBackColor = true;
            this.DisaAktarBtn.Click += new System.EventHandler(this.DisaAktarBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EkleBtn.Location = new System.Drawing.Point(734, 122);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(94, 29);
            this.EkleBtn.TabIndex = 3;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SilBtn.Location = new System.Drawing.Point(734, 261);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(94, 29);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GuncelleBtn.Location = new System.Drawing.Point(734, 396);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(94, 29);
            this.GuncelleBtn.TabIndex = 5;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // HyteraEnvanterView
            // 
            this.HyteraEnvanterView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HyteraEnvanterView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HyteraEnvanterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HyteraEnvanterView.Location = new System.Drawing.Point(31, 115);
            this.HyteraEnvanterView.Name = "HyteraEnvanterView";
            this.HyteraEnvanterView.RowHeadersWidth = 51;
            this.HyteraEnvanterView.RowTemplate.Height = 29;
            this.HyteraEnvanterView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HyteraEnvanterView.Size = new System.Drawing.Size(679, 386);
            this.HyteraEnvanterView.TabIndex = 7;
            this.HyteraEnvanterView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HyteraEnvanterView_CellContentClick);
            // 
            // QrBtn
            // 
            this.QrBtn.Location = new System.Drawing.Point(744, 47);
            this.QrBtn.Name = "QrBtn";
            this.QrBtn.Size = new System.Drawing.Size(60, 42);
            this.QrBtn.TabIndex = 8;
            this.QrBtn.Text = "QR";
            this.QrBtn.UseVisualStyleBackColor = true;
            this.QrBtn.Click += new System.EventHandler(this.QrBtn_Click);
            // 
            // HyteraEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 548);
            this.Controls.Add(this.QrBtn);
            this.Controls.Add(this.HyteraEnvanterView);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.DisaAktarBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.GeriBtn);
            this.Name = "HyteraEnvanter";
            this.Text = "HyteraEnvanter";
            this.Load += new System.EventHandler(this.HyteraEnvanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HyteraEnvanterView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GeriBtn;
        private Button ImportBtn;
        private Button DisaAktarBtn;
        private Button EkleBtn;
        private Button SilBtn;
        private Button GuncelleBtn;
        private DataGridView HyteraEnvanterView;
        private Button QrBtn;
    }
}