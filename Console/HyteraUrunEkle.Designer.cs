namespace Console
{
    partial class HyteraUrunEkle
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
            this.SeriNoLbl = new System.Windows.Forms.Label();
            this.IsimVeSoyisimLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.YaziciLbl = new System.Windows.Forms.Label();
            this.GönderBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 27);
            this.textBox1.TabIndex = 0;
            // 
            // SeriNoLbl
            // 
            this.SeriNoLbl.AutoSize = true;
            this.SeriNoLbl.Location = new System.Drawing.Point(53, 70);
            this.SeriNoLbl.Name = "SeriNoLbl";
            this.SeriNoLbl.Size = new System.Drawing.Size(58, 20);
            this.SeriNoLbl.TabIndex = 1;
            this.SeriNoLbl.Text = "Seri No";
            // 
            // IsimVeSoyisimLbl
            // 
            this.IsimVeSoyisimLbl.AutoSize = true;
            this.IsimVeSoyisimLbl.Location = new System.Drawing.Point(35, 176);
            this.IsimVeSoyisimLbl.Name = "IsimVeSoyisimLbl";
            this.IsimVeSoyisimLbl.Size = new System.Drawing.Size(110, 20);
            this.IsimVeSoyisimLbl.TabIndex = 3;
            this.IsimVeSoyisimLbl.Text = "İsim ve Soyisim";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 27);
            this.textBox2.TabIndex = 2;
            // 
            // YaziciLbl
            // 
            this.YaziciLbl.AutoSize = true;
            this.YaziciLbl.Location = new System.Drawing.Point(53, 295);
            this.YaziciLbl.Name = "YaziciLbl";
            this.YaziciLbl.Size = new System.Drawing.Size(46, 20);
            this.YaziciLbl.TabIndex = 5;
            this.YaziciLbl.Text = "Yazici";
            // 
            // GönderBtn
            // 
            this.GönderBtn.Location = new System.Drawing.Point(225, 378);
            this.GönderBtn.Name = "GönderBtn";
            this.GönderBtn.Size = new System.Drawing.Size(94, 29);
            this.GönderBtn.TabIndex = 6;
            this.GönderBtn.Text = "GÖNDER";
            this.GönderBtn.UseVisualStyleBackColor = true;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(392, 288);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(94, 29);
            this.EkleBtn.TabIndex = 7;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ZEBRA",
            "UROVO"});
            this.comboBox1.Location = new System.Drawing.Point(188, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // HyteraUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.GönderBtn);
            this.Controls.Add(this.YaziciLbl);
            this.Controls.Add(this.IsimVeSoyisimLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SeriNoLbl);
            this.Controls.Add(this.textBox1);
            this.Name = "HyteraUrunEkle";
            this.Text = "HyteraUrunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label SeriNoLbl;
        private Label IsimVeSoyisimLbl;
        private TextBox textBox2;
        private Label YaziciLbl;
        private Button GönderBtn;
        private Button EkleBtn;
        private ComboBox comboBox1;
    }
}