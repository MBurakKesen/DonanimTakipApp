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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.seriNumarasıTxt = new System.Windows.Forms.TextBox();
            this.isimVeSoyisimTxt = new System.Windows.Forms.TextBox();
            this.yaziciTxt = new System.Windows.Forms.TextBox();
            this.temizleBtn = new System.Windows.Forms.Button();
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
            this.ImportBtn.Location = new System.Drawing.Point(1125, 24);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(87, 55);
            this.ImportBtn.TabIndex = 1;
            this.ImportBtn.Text = "İçeri Aktar";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // DisaAktarBtn
            // 
            this.DisaAktarBtn.Location = new System.Drawing.Point(1220, 24);
            this.DisaAktarBtn.Name = "DisaAktarBtn";
            this.DisaAktarBtn.Size = new System.Drawing.Size(87, 55);
            this.DisaAktarBtn.TabIndex = 2;
            this.DisaAktarBtn.Text = "Dışa Aktar";
            this.DisaAktarBtn.UseVisualStyleBackColor = true;
            this.DisaAktarBtn.Click += new System.EventHandler(this.DisaAktarBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EkleBtn.Location = new System.Drawing.Point(1262, 377);
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
            this.SilBtn.Location = new System.Drawing.Point(1262, 444);
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
            this.GuncelleBtn.Location = new System.Drawing.Point(1262, 525);
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
            this.HyteraEnvanterView.Location = new System.Drawing.Point(27, 150);
            this.HyteraEnvanterView.Name = "HyteraEnvanterView";
            this.HyteraEnvanterView.RowHeadersWidth = 51;
            this.HyteraEnvanterView.RowTemplate.Height = 29;
            this.HyteraEnvanterView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HyteraEnvanterView.Size = new System.Drawing.Size(1185, 549);
            this.HyteraEnvanterView.TabIndex = 7;
            this.HyteraEnvanterView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HyteraEnvanterView_CellContentClick);
            // 
            // QrBtn
            // 
            this.QrBtn.Location = new System.Drawing.Point(1032, 24);
            this.QrBtn.Name = "QrBtn";
            this.QrBtn.Size = new System.Drawing.Size(87, 55);
            this.QrBtn.TabIndex = 8;
            this.QrBtn.Text = "QR";
            this.QrBtn.UseVisualStyleBackColor = true;
            this.QrBtn.Click += new System.EventHandler(this.QrBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 9;
            // 
            // seriNumarasıTxt
            // 
            this.seriNumarasıTxt.Location = new System.Drawing.Point(380, 115);
            this.seriNumarasıTxt.Name = "seriNumarasıTxt";
            this.seriNumarasıTxt.PlaceholderText = "Seri Numarası";
            this.seriNumarasıTxt.Size = new System.Drawing.Size(250, 27);
            this.seriNumarasıTxt.TabIndex = 10;
            this.seriNumarasıTxt.TextChanged += new System.EventHandler(this.seriNumarasıTxt_TextChanged);
            // 
            // isimVeSoyisimTxt
            // 
            this.isimVeSoyisimTxt.Location = new System.Drawing.Point(665, 115);
            this.isimVeSoyisimTxt.Name = "isimVeSoyisimTxt";
            this.isimVeSoyisimTxt.PlaceholderText = "İsim ve Soyisim";
            this.isimVeSoyisimTxt.Size = new System.Drawing.Size(252, 27);
            this.isimVeSoyisimTxt.TabIndex = 11;
            this.isimVeSoyisimTxt.TextChanged += new System.EventHandler(this.isimVeSoyisimTxt_TextChanged);
            // 
            // yaziciTxt
            // 
            this.yaziciTxt.Location = new System.Drawing.Point(965, 115);
            this.yaziciTxt.Name = "yaziciTxt";
            this.yaziciTxt.PlaceholderText = "Yazici";
            this.yaziciTxt.Size = new System.Drawing.Size(229, 27);
            this.yaziciTxt.TabIndex = 12;
            this.yaziciTxt.TextChanged += new System.EventHandler(this.yaziciTxt_TextChanged);
            // 
            // temizleBtn
            // 
            this.temizleBtn.Location = new System.Drawing.Point(234, 115);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(83, 29);
            this.temizleBtn.TabIndex = 13;
            this.temizleBtn.Text = "SIFIRLA";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // HyteraEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 711);
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.yaziciTxt);
            this.Controls.Add(this.isimVeSoyisimTxt);
            this.Controls.Add(this.seriNumarasıTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QrBtn);
            this.Controls.Add(this.HyteraEnvanterView);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.DisaAktarBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.GeriBtn);
            this.MaximizeBox = false;
            this.Name = "HyteraEnvanter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private TextBox textBox1;
        private TextBox seriNumarasıTxt;
        private TextBox isimVeSoyisimTxt;
        private TextBox yaziciTxt;
        private Button temizleBtn;
    }
}