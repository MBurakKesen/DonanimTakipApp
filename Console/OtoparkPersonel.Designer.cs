namespace Console
{
    partial class OtoparkPersonel
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
            this.otoparkDgv = new System.Windows.Forms.DataGridView();
            this.geriBtn = new System.Windows.Forms.Button();
            this.iceriAktarBtn = new System.Windows.Forms.Button();
            this.disariAktarBtn = new System.Windows.Forms.Button();
            this.eklemeBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // otoparkDgv
            // 
            this.otoparkDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otoparkDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.otoparkDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.otoparkDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otoparkDgv.Location = new System.Drawing.Point(27, 89);
            this.otoparkDgv.Name = "otoparkDgv";
            this.otoparkDgv.RowHeadersWidth = 51;
            this.otoparkDgv.RowTemplate.Height = 29;
            this.otoparkDgv.Size = new System.Drawing.Size(801, 384);
            this.otoparkDgv.TabIndex = 0;
            // 
            // geriBtn
            // 
            this.geriBtn.Location = new System.Drawing.Point(12, 12);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(55, 29);
            this.geriBtn.TabIndex = 1;
            this.geriBtn.Text = "GERİ";
            this.geriBtn.UseVisualStyleBackColor = true;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // iceriAktarBtn
            // 
            this.iceriAktarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iceriAktarBtn.FlatAppearance.BorderSize = 2;
            this.iceriAktarBtn.Location = new System.Drawing.Point(517, 12);
            this.iceriAktarBtn.Name = "iceriAktarBtn";
            this.iceriAktarBtn.Size = new System.Drawing.Size(95, 55);
            this.iceriAktarBtn.TabIndex = 2;
            this.iceriAktarBtn.Text = "İçeri Aktar";
            this.iceriAktarBtn.UseVisualStyleBackColor = true;
            this.iceriAktarBtn.Click += new System.EventHandler(this.iceriAktarBtn_Click);
            // 
            // disariAktarBtn
            // 
            this.disariAktarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disariAktarBtn.Location = new System.Drawing.Point(618, 12);
            this.disariAktarBtn.Name = "disariAktarBtn";
            this.disariAktarBtn.Size = new System.Drawing.Size(102, 55);
            this.disariAktarBtn.TabIndex = 3;
            this.disariAktarBtn.Text = "Dışarı Aktar";
            this.disariAktarBtn.UseVisualStyleBackColor = true;
            this.disariAktarBtn.Click += new System.EventHandler(this.disariAktarBtn_Click);
            // 
            // eklemeBtn
            // 
            this.eklemeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eklemeBtn.Location = new System.Drawing.Point(849, 114);
            this.eklemeBtn.Name = "eklemeBtn";
            this.eklemeBtn.Size = new System.Drawing.Size(103, 53);
            this.eklemeBtn.TabIndex = 4;
            this.eklemeBtn.Text = "Ekle";
            this.eklemeBtn.UseVisualStyleBackColor = true;
            this.eklemeBtn.Click += new System.EventHandler(this.eklemeBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.silBtn.Location = new System.Drawing.Point(849, 205);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(103, 53);
            this.silBtn.TabIndex = 5;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guncelleBtn.Location = new System.Drawing.Point(849, 299);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(103, 53);
            this.guncelleBtn.TabIndex = 6;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            // 
            // OtoparkPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 505);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.eklemeBtn);
            this.Controls.Add(this.disariAktarBtn);
            this.Controls.Add(this.iceriAktarBtn);
            this.Controls.Add(this.geriBtn);
            this.Controls.Add(this.otoparkDgv);
            this.Name = "OtoparkPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Personel Listesi";
            this.Load += new System.EventHandler(this.OtoparkPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView otoparkDgv;
        private Button geriBtn;
        private Button iceriAktarBtn;
        private Button disariAktarBtn;
        private ToolTip toolTip1;
        private Button eklemeBtn;
        private Button silBtn;
        private Button guncelleBtn;
    }
}