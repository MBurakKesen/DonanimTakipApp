namespace Console
{
    partial class YaziciVeSeriNumaralarıEkleme
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
            this.SicilNotxt = new System.Windows.Forms.TextBox();
            this.PersonelTxt = new System.Windows.Forms.TextBox();
            this.AmirTxt = new System.Windows.Forms.TextBox();
            this.SeriNumarasiTxt = new System.Windows.Forms.TextBox();
            this.YaziciCbx = new System.Windows.Forms.ComboBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SicilNotxt
            // 
            this.SicilNotxt.Location = new System.Drawing.Point(86, 44);
            this.SicilNotxt.Name = "SicilNotxt";
            this.SicilNotxt.PlaceholderText = "Sicil No";
            this.SicilNotxt.Size = new System.Drawing.Size(166, 27);
            this.SicilNotxt.TabIndex = 0;
            // 
            // PersonelTxt
            // 
            this.PersonelTxt.Location = new System.Drawing.Point(86, 126);
            this.PersonelTxt.Name = "PersonelTxt";
            this.PersonelTxt.PlaceholderText = "Personel";
            this.PersonelTxt.Size = new System.Drawing.Size(166, 27);
            this.PersonelTxt.TabIndex = 1;
            // 
            // AmirTxt
            // 
            this.AmirTxt.Location = new System.Drawing.Point(86, 195);
            this.AmirTxt.Name = "AmirTxt";
            this.AmirTxt.PlaceholderText = "Amir";
            this.AmirTxt.Size = new System.Drawing.Size(166, 27);
            this.AmirTxt.TabIndex = 2;
            // 
            // SeriNumarasiTxt
            // 
            this.SeriNumarasiTxt.Location = new System.Drawing.Point(86, 367);
            this.SeriNumarasiTxt.Name = "SeriNumarasiTxt";
            this.SeriNumarasiTxt.PlaceholderText = "Seri Numarası";
            this.SeriNumarasiTxt.Size = new System.Drawing.Size(166, 27);
            this.SeriNumarasiTxt.TabIndex = 4;
            // 
            // YaziciCbx
            // 
            this.YaziciCbx.DisplayMember = "Zebra";
            this.YaziciCbx.FormattingEnabled = true;
            this.YaziciCbx.Items.AddRange(new object[] {
            "ZEBRA",
            "OROVO"});
            this.YaziciCbx.Location = new System.Drawing.Point(86, 281);
            this.YaziciCbx.Name = "YaziciCbx";
            this.YaziciCbx.Size = new System.Drawing.Size(166, 28);
            this.YaziciCbx.TabIndex = 5;
            this.YaziciCbx.Tag = "Yazıcı";
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(319, 383);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(69, 43);
            this.EkleBtn.TabIndex = 6;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 32);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YaziciVeSeriNumaralarıEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.YaziciCbx);
            this.Controls.Add(this.SeriNumarasiTxt);
            this.Controls.Add(this.AmirTxt);
            this.Controls.Add(this.PersonelTxt);
            this.Controls.Add(this.SicilNotxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YaziciVeSeriNumaralarıEkleme";
            this.Text = "EKLEME SAYFASI";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.Load += new System.EventHandler(this.YaziciVeSeriNumaralarıEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SicilNotxt;
        private TextBox PersonelTxt;
        private TextBox AmirTxt;
        private TextBox SeriNumarasiTxt;
        private ComboBox YaziciCbx;
        private Button EkleBtn;
        private Button button1;
    }
}