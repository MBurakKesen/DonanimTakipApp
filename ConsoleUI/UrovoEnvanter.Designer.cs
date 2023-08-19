namespace ConsoleUI
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
            this.geriDon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YaziciEklemeBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geriDon
            // 
            this.geriDon.Location = new System.Drawing.Point(12, 12);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(75, 23);
            this.geriDon.TabIndex = 1;
            this.geriDon.Text = "Geri";
            this.geriDon.UseVisualStyleBackColor = true;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marka,
            this.Model,
            this.TeslimTarihi,
            this.SeriNumarasi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 386);
            this.dataGridView1.TabIndex = 2;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.Width = 125;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.Width = 125;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.HeaderText = "Teslim Tarihi";
            this.TeslimTarihi.MinimumWidth = 6;
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.Width = 125;
            // 
            // SeriNumarasi
            // 
            this.SeriNumarasi.HeaderText = "SeriNumarasi";
            this.SeriNumarasi.MinimumWidth = 6;
            this.SeriNumarasi.Name = "SeriNumarasi";
            this.SeriNumarasi.Width = 125;
            // 
            // YaziciEklemeBtn
            // 
            this.YaziciEklemeBtn.Location = new System.Drawing.Point(599, 54);
            this.YaziciEklemeBtn.Name = "YaziciEklemeBtn";
            this.YaziciEklemeBtn.Size = new System.Drawing.Size(180, 49);
            this.YaziciEklemeBtn.TabIndex = 3;
            this.YaziciEklemeBtn.Text = "Yazıcı Ekle";
            this.YaziciEklemeBtn.UseVisualStyleBackColor = true;
            this.YaziciEklemeBtn.Click += new System.EventHandler(this.YaziciEklemeBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(599, 145);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(180, 49);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // UrovoEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.YaziciEklemeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geriDon);
            this.Name = "UrovoEnvanter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrovoEnvanter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeslimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNumarasi;
        private System.Windows.Forms.Button YaziciEklemeBtn;
        private System.Windows.Forms.Button SilBtn;
    }
}