namespace Console
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrovoOnarimTakipBtn = new System.Windows.Forms.Button();
            this.HyteraEnvanterBtn = new System.Windows.Forms.Button();
            this.UrovoGarantiTakipBtn = new System.Windows.Forms.Button();
            this.YaziciSeriNoBtn = new System.Windows.Forms.Button();
            this.AnasayfaLbl = new System.Windows.Forms.Label();
            this.YaziciVeSeriNumaraBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrovoOnarimTakipBtn
            // 
            this.UrovoOnarimTakipBtn.AutoSize = true;
            this.UrovoOnarimTakipBtn.Location = new System.Drawing.Point(21, 37);
            this.UrovoOnarimTakipBtn.Name = "UrovoOnarimTakipBtn";
            this.UrovoOnarimTakipBtn.Size = new System.Drawing.Size(215, 97);
            this.UrovoOnarimTakipBtn.TabIndex = 1;
            this.UrovoOnarimTakipBtn.Text = "Urovo Onarım Takip";
            this.UrovoOnarimTakipBtn.UseVisualStyleBackColor = true;
            this.UrovoOnarimTakipBtn.Click += new System.EventHandler(this.UrovoOnarimTakipBtn_Click);
            // 
            // HyteraEnvanterBtn
            // 
            this.HyteraEnvanterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HyteraEnvanterBtn.AutoSize = true;
            this.HyteraEnvanterBtn.Location = new System.Drawing.Point(362, 37);
            this.HyteraEnvanterBtn.Name = "HyteraEnvanterBtn";
            this.HyteraEnvanterBtn.Size = new System.Drawing.Size(215, 97);
            this.HyteraEnvanterBtn.TabIndex = 2;
            this.HyteraEnvanterBtn.Text = "Hytera Envanter";
            this.HyteraEnvanterBtn.UseVisualStyleBackColor = true;
            this.HyteraEnvanterBtn.Click += new System.EventHandler(this.HyteraEnvanterBtn_Click);
            // 
            // UrovoGarantiTakipBtn
            // 
            this.UrovoGarantiTakipBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UrovoGarantiTakipBtn.Location = new System.Drawing.Point(21, 192);
            this.UrovoGarantiTakipBtn.Name = "UrovoGarantiTakipBtn";
            this.UrovoGarantiTakipBtn.Size = new System.Drawing.Size(215, 97);
            this.UrovoGarantiTakipBtn.TabIndex = 3;
            this.UrovoGarantiTakipBtn.Text = "Urovo Garanti Takip";
            this.UrovoGarantiTakipBtn.UseVisualStyleBackColor = true;
            this.UrovoGarantiTakipBtn.Click += new System.EventHandler(this.UrovoGarantiTakipBtn_Click);
            // 
            // YaziciSeriNoBtn
            // 
            this.YaziciSeriNoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YaziciSeriNoBtn.Location = new System.Drawing.Point(362, 192);
            this.YaziciSeriNoBtn.Name = "YaziciSeriNoBtn";
            this.YaziciSeriNoBtn.Size = new System.Drawing.Size(215, 97);
            this.YaziciSeriNoBtn.TabIndex = 4;
            this.YaziciSeriNoBtn.Text = "Urovo Envanter";
            this.YaziciSeriNoBtn.UseVisualStyleBackColor = true;
            this.YaziciSeriNoBtn.Click += new System.EventHandler(this.YaziciSeriNoBtn_Click);
            // 
            // AnasayfaLbl
            // 
            this.AnasayfaLbl.AutoSize = true;
            this.AnasayfaLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnasayfaLbl.Location = new System.Drawing.Point(595, 427);
            this.AnasayfaLbl.Name = "AnasayfaLbl";
            this.AnasayfaLbl.Size = new System.Drawing.Size(198, 28);
            this.AnasayfaLbl.TabIndex = 6;
            this.AnasayfaLbl.Text = "Developed by Stajyer";
            // 
            // YaziciVeSeriNumaraBtn
            // 
            this.YaziciVeSeriNumaraBtn.Location = new System.Drawing.Point(21, 329);
            this.YaziciVeSeriNumaraBtn.Name = "YaziciVeSeriNumaraBtn";
            this.YaziciVeSeriNumaraBtn.Size = new System.Drawing.Size(215, 97);
            this.YaziciVeSeriNumaraBtn.TabIndex = 7;
            this.YaziciVeSeriNumaraBtn.Text = "Yazici Ve Numaralari";
            this.YaziciVeSeriNumaraBtn.UseVisualStyleBackColor = true;
            this.YaziciVeSeriNumaraBtn.Click += new System.EventHandler(this.YaziciVeSeriNumaraBtn_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 473);
            this.Controls.Add(this.YaziciVeSeriNumaraBtn);
            this.Controls.Add(this.YaziciSeriNoBtn);
            this.Controls.Add(this.AnasayfaLbl);
            this.Controls.Add(this.HyteraEnvanterBtn);
            this.Controls.Add(this.UrovoOnarimTakipBtn);
            this.Controls.Add(this.UrovoGarantiTakipBtn);
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button UrovoOnarimTakipBtn;
        private Button HyteraEnvanterBtn;
        private Button UrovoGarantiTakipBtn;
        private Button YaziciSeriNoBtn;
        private Label AnasayfaLbl;
        private Button YaziciVeSeriNumaraBtn;
    }
}