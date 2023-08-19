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
            this.UrovoEnvanterBtn = new System.Windows.Forms.Button();
            this.UrovoOnarimTakipBtn = new System.Windows.Forms.Button();
            this.HyteraEnvanterBtn = new System.Windows.Forms.Button();
            this.UrovoGarantiTakipBtn = new System.Windows.Forms.Button();
            this.YaziciSeriNoBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrovoEnvanterBtn
            // 
            this.UrovoEnvanterBtn.Location = new System.Drawing.Point(3, 315);
            this.UrovoEnvanterBtn.Name = "UrovoEnvanterBtn";
            this.UrovoEnvanterBtn.Size = new System.Drawing.Size(215, 97);
            this.UrovoEnvanterBtn.TabIndex = 0;
            this.UrovoEnvanterBtn.Text = "Urovo Envanter";
            this.UrovoEnvanterBtn.UseVisualStyleBackColor = true;
            this.UrovoEnvanterBtn.Click += new System.EventHandler(this.UrovoEnvanterBtn_Click);
            // 
            // UrovoOnarimTakipBtn
            // 
            this.UrovoOnarimTakipBtn.Location = new System.Drawing.Point(3, 3);
            this.UrovoOnarimTakipBtn.Name = "UrovoOnarimTakipBtn";
            this.UrovoOnarimTakipBtn.Size = new System.Drawing.Size(215, 97);
            this.UrovoOnarimTakipBtn.TabIndex = 1;
            this.UrovoOnarimTakipBtn.Text = "Urovo Onarım Takip";
            this.UrovoOnarimTakipBtn.UseVisualStyleBackColor = true;
            this.UrovoOnarimTakipBtn.Click += new System.EventHandler(this.UrovoOnarimTakipBtn_Click);
            // 
            // HyteraEnvanterBtn
            // 
            this.HyteraEnvanterBtn.Location = new System.Drawing.Point(391, 315);
            this.HyteraEnvanterBtn.Name = "HyteraEnvanterBtn";
            this.HyteraEnvanterBtn.Size = new System.Drawing.Size(215, 97);
            this.HyteraEnvanterBtn.TabIndex = 2;
            this.HyteraEnvanterBtn.Text = "Hytera Envanter";
            this.HyteraEnvanterBtn.UseVisualStyleBackColor = true;
            this.HyteraEnvanterBtn.Click += new System.EventHandler(this.HyteraEnvanterBtn_Click);
            // 
            // UrovoGarantiTakipBtn
            // 
            this.UrovoGarantiTakipBtn.Location = new System.Drawing.Point(3, 165);
            this.UrovoGarantiTakipBtn.Name = "UrovoGarantiTakipBtn";
            this.UrovoGarantiTakipBtn.Size = new System.Drawing.Size(215, 97);
            this.UrovoGarantiTakipBtn.TabIndex = 3;
            this.UrovoGarantiTakipBtn.Text = "Urovo Garanti Takip";
            this.UrovoGarantiTakipBtn.UseVisualStyleBackColor = true;
            this.UrovoGarantiTakipBtn.Click += new System.EventHandler(this.UrovoGarantiTakipBtn_Click);
            // 
            // YaziciSeriNoBtn
            // 
            this.YaziciSeriNoBtn.Location = new System.Drawing.Point(391, 3);
            this.YaziciSeriNoBtn.Name = "YaziciSeriNoBtn";
            this.YaziciSeriNoBtn.Size = new System.Drawing.Size(215, 97);
            this.YaziciSeriNoBtn.TabIndex = 4;
            this.YaziciSeriNoBtn.Text = "Yazıcı ve Seri No";
            this.YaziciSeriNoBtn.UseVisualStyleBackColor = true;
            this.YaziciSeriNoBtn.Click += new System.EventHandler(this.YaziciSeriNoBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HyteraEnvanterBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.YaziciSeriNoBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UrovoEnvanterBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UrovoOnarimTakipBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UrovoGarantiTakipBtn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.5583F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.01413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.42756F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 469);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UrovoEnvanterBtn;
        private Button UrovoOnarimTakipBtn;
        private Button HyteraEnvanterBtn;
        private Button UrovoGarantiTakipBtn;
        private Button YaziciSeriNoBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}