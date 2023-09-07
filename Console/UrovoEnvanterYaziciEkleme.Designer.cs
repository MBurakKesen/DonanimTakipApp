namespace Console
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModelTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SeriNumarasıTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TeslimTarihiDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.MarkaCbx = new System.Windows.Forms.ComboBox();
            this.YazıcıEkleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // ModelTxt
            // 
            this.ModelTxt.Location = new System.Drawing.Point(97, 153);
            this.ModelTxt.Name = "ModelTxt";
            this.ModelTxt.Size = new System.Drawing.Size(193, 27);
            this.ModelTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // SeriNumarasıTxt
            // 
            this.SeriNumarasıTxt.Location = new System.Drawing.Point(97, 337);
            this.SeriNumarasıTxt.Name = "SeriNumarasıTxt";
            this.SeriNumarasıTxt.Size = new System.Drawing.Size(193, 27);
            this.SeriNumarasıTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri Numarası";
            // 
            // TeslimTarihiDtp
            // 
            this.TeslimTarihiDtp.Location = new System.Drawing.Point(97, 241);
            this.TeslimTarihiDtp.Name = "TeslimTarihiDtp";
            this.TeslimTarihiDtp.Size = new System.Drawing.Size(193, 27);
            this.TeslimTarihiDtp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teslim Tarihi";
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(345, 385);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(94, 77);
            this.EkleBtn.TabIndex = 8;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // MarkaCbx
            // 
            this.MarkaCbx.FormattingEnabled = true;
            this.MarkaCbx.Items.AddRange(new object[] {
            "UROVO",
            "ZEBRA"});
            this.MarkaCbx.Location = new System.Drawing.Point(97, 53);
            this.MarkaCbx.Name = "MarkaCbx";
            this.MarkaCbx.Size = new System.Drawing.Size(193, 28);
            this.MarkaCbx.TabIndex = 9;
            // 
            // YazıcıEkleBtn
            // 
            this.YazıcıEkleBtn.Location = new System.Drawing.Point(345, 53);
            this.YazıcıEkleBtn.Name = "YazıcıEkleBtn";
            this.YazıcıEkleBtn.Size = new System.Drawing.Size(94, 28);
            this.YazıcıEkleBtn.TabIndex = 10;
            this.YazıcıEkleBtn.Text = "Ekle";
            this.YazıcıEkleBtn.UseVisualStyleBackColor = true;
            // 
            // UrovoEnvanterYaziciEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 474);
            this.Controls.Add(this.YazıcıEkleBtn);
            this.Controls.Add(this.MarkaCbx);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeslimTarihiDtp);
            this.Controls.Add(this.SeriNumarasıTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrovoEnvanterYaziciEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EKLEME SAYFASI";
            this.Load += new System.EventHandler(this.UrovoEnvanterYaziciEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox ModelTxt;
        private Label label2;
        private TextBox SeriNumarasıTxt;
        private Label label3;
        private DateTimePicker TeslimTarihiDtp;
        private Label label4;
        private Button EkleBtn;
        private ComboBox MarkaCbx;
        private Button YazıcıEkleBtn;
    }
}