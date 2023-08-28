namespace Console
{
    partial class UrovoK239GarantiTakip
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
            this.GeriBtn = new System.Windows.Forms.Button();
            this.GonderBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(990, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // GeriBtn
            // 
            this.GeriBtn.Location = new System.Drawing.Point(12, 12);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(70, 30);
            this.GeriBtn.TabIndex = 1;
            this.GeriBtn.Text = "GERİ";
            this.GeriBtn.UseVisualStyleBackColor = true;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // GonderBtn
            // 
            this.GonderBtn.Location = new System.Drawing.Point(104, 446);
            this.GonderBtn.Name = "GonderBtn";
            this.GonderBtn.Size = new System.Drawing.Size(133, 58);
            this.GonderBtn.TabIndex = 2;
            this.GonderBtn.Text = "GÖNDER";
            this.GonderBtn.UseVisualStyleBackColor = true;
            this.GonderBtn.Click += new System.EventHandler(this.GonderBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Location = new System.Drawing.Point(440, 446);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(133, 58);
            this.GuncelleBtn.TabIndex = 3;
            this.GuncelleBtn.Text = "GÜNCELLE";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            this.GuncelleBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(799, 446);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(133, 58);
            this.SilBtn.TabIndex = 4;
            this.SilBtn.Text = "SİL";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // UrovoK239GarantiTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 516);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.GonderBtn);
            this.Controls.Add(this.GeriBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrovoK239GarantiTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrovoK239GarantiTakip";
            this.Load += new System.EventHandler(this.UrovoK239GarantiTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button GeriBtn;
        private Button GonderBtn;
        private Button GuncelleBtn;
        private Button SilBtn;
    }
}