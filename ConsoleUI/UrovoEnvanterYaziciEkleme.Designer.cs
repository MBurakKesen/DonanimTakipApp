namespace ConsoleUI
{
    partial class UrovoEnvanterYaziciEkleme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Marka = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.TeslimTarihi = new System.Windows.Forms.Label();
            this.SeriNumarasi = new System.Windows.Forms.Label();
            this.UrovoEnvanterYaziciEklemeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 412);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 22);
            this.textBox3.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 314);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(85, 108);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(45, 16);
            this.Marka.TabIndex = 4;
            this.Marka.Text = "Marka";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(85, 200);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(45, 16);
            this.Model.TabIndex = 5;
            this.Model.Text = "Model";
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.AutoSize = true;
            this.TeslimTarihi.Location = new System.Drawing.Point(85, 295);
            this.TeslimTarihi.Name = "TeslimTarihi";
            this.TeslimTarihi.Size = new System.Drawing.Size(85, 16);
            this.TeslimTarihi.TabIndex = 6;
            this.TeslimTarihi.Text = "Teslim Tarihi";
            // 
            // SeriNumarasi
            // 
            this.SeriNumarasi.AutoSize = true;
            this.SeriNumarasi.Location = new System.Drawing.Point(85, 393);
            this.SeriNumarasi.Name = "SeriNumarasi";
            this.SeriNumarasi.Size = new System.Drawing.Size(109, 16);
            this.SeriNumarasi.TabIndex = 7;
            this.SeriNumarasi.Text = "Teslim Numarası";
            // 
            // UrovoEnvanterYaziciEklemeBtn
            // 
            this.UrovoEnvanterYaziciEklemeBtn.Location = new System.Drawing.Point(311, 454);
            this.UrovoEnvanterYaziciEklemeBtn.Name = "UrovoEnvanterYaziciEklemeBtn";
            this.UrovoEnvanterYaziciEklemeBtn.Size = new System.Drawing.Size(113, 67);
            this.UrovoEnvanterYaziciEklemeBtn.TabIndex = 8;
            this.UrovoEnvanterYaziciEklemeBtn.Text = "EKLE";
            this.UrovoEnvanterYaziciEklemeBtn.UseVisualStyleBackColor = true;
            this.UrovoEnvanterYaziciEklemeBtn.Click += new System.EventHandler(this.UrovoEnvanterYaziciEklemeBtn_Click);
            // 
            // UrovoEnvanterYaziciEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 557);
            this.Controls.Add(this.UrovoEnvanterYaziciEklemeBtn);
            this.Controls.Add(this.SeriNumarasi);
            this.Controls.Add(this.TeslimTarihi);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UrovoEnvanterYaziciEkleme";
            this.Text = "UrovoEnvanterYaziciEkleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label TeslimTarihi;
        private System.Windows.Forms.Label SeriNumarasi;
        private System.Windows.Forms.Button UrovoEnvanterYaziciEklemeBtn;
    }
}