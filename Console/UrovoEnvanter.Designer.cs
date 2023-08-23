namespace Console
{
    partial class UrovoEnvanter
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
            this.YaziciDGV = new System.Windows.Forms.DataGridView();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.IceriAktarBtn = new System.Windows.Forms.Button();
            this.DisariAktarBtn = new System.Windows.Forms.Button();
            this.GeriBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YaziciDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // YaziciDGV
            // 
            this.YaziciDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YaziciDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YaziciDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YaziciDGV.Location = new System.Drawing.Point(12, 81);
            this.YaziciDGV.Name = "YaziciDGV";
            this.YaziciDGV.RowHeadersWidth = 51;
            this.YaziciDGV.RowTemplate.Height = 29;
            this.YaziciDGV.Size = new System.Drawing.Size(809, 428);
            this.YaziciDGV.TabIndex = 0;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EkleBtn.Location = new System.Drawing.Point(858, 106);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(109, 47);
            this.EkleBtn.TabIndex = 1;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            // 
            // SilBtn
            // 
            this.SilBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SilBtn.Location = new System.Drawing.Point(858, 249);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(109, 47);
            this.SilBtn.TabIndex = 2;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // IceriAktarBtn
            // 
            this.IceriAktarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IceriAktarBtn.Location = new System.Drawing.Point(507, 28);
            this.IceriAktarBtn.Name = "IceriAktarBtn";
            this.IceriAktarBtn.Size = new System.Drawing.Size(109, 47);
            this.IceriAktarBtn.TabIndex = 3;
            this.IceriAktarBtn.Text = "İçeri Aktar";
            this.IceriAktarBtn.UseVisualStyleBackColor = true;
            this.IceriAktarBtn.Click += new System.EventHandler(this.IceriAktarBtn_Click);
            // 
            // DisariAktarBtn
            // 
            this.DisariAktarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisariAktarBtn.Location = new System.Drawing.Point(696, 28);
            this.DisariAktarBtn.Name = "DisariAktarBtn";
            this.DisariAktarBtn.Size = new System.Drawing.Size(109, 47);
            this.DisariAktarBtn.TabIndex = 4;
            this.DisariAktarBtn.Text = "Dışarı Aktar";
            this.DisariAktarBtn.UseVisualStyleBackColor = true;
            this.DisariAktarBtn.Click += new System.EventHandler(this.DisariAktarBtn_Click);
            // 
            // GeriBtn
            // 
            this.GeriBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(65, 30);
            this.GeriBtn.TabIndex = 5;
            this.GeriBtn.Text = "GERİ";
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // UrovoEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1020, 521);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.DisariAktarBtn);
            this.Controls.Add(this.IceriAktarBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.YaziciDGV);
            this.Name = "UrovoEnvanter";
            this.Text = "Yazıcılar";
            this.Load += new System.EventHandler(this.UrovoEnvanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YaziciDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView YaziciDGV;
        private Button EkleBtn;
        private Button SilBtn;
        private Button IceriAktarBtn;
        private Button DisariAktarBtn;
        private Button GeriBtn;
    }
}