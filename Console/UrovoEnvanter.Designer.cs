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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNumarası = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marka,
            this.Model,
            this.TeslimTarihi,
            this.SeriNumarası});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // Marka
            // 
            this.Marka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeslimTarihi.HeaderText = "Teslim Tarihi";
            this.TeslimTarihi.MinimumWidth = 6;
            this.TeslimTarihi.Name = "TeslimTarihi";
            // 
            // SeriNumarası
            // 
            this.SeriNumarası.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeriNumarası.HeaderText = "Seri Numarası";
            this.SeriNumarası.MinimumWidth = 6;
            this.SeriNumarası.Name = "SeriNumarası";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(101, 454);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(94, 29);
            this.EkleBtn.TabIndex = 2;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(627, 454);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(94, 29);
            this.SilBtn.TabIndex = 3;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Location = new System.Drawing.Point(371, 454);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(94, 29);
            this.GüncelleBtn.TabIndex = 4;
            this.GüncelleBtn.Text = "GÜNCELLE";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            // 
            // UrovoEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.GüncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrovoEnvanter";
            this.Text = "UrovoEnvanter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Marka;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn TeslimTarihi;
        private DataGridViewTextBoxColumn SeriNumarası;
        private Button button1;
        private Button EkleBtn;
        private Button SilBtn;
        private Button GüncelleBtn;
    }
}