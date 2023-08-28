namespace Console
{
    partial class QRScreen
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
            this.QrPic = new System.Windows.Forms.PictureBox();
            this.qrPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.QrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // QrPic
            // 
            this.QrPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrPic.Location = new System.Drawing.Point(122, 163);
            this.QrPic.Name = "QrPic";
            this.QrPic.Size = new System.Drawing.Size(463, 400);
            this.QrPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QrPic.TabIndex = 0;
            this.QrPic.TabStop = false;
            this.QrPic.Click += new System.EventHandler(this.QrPic_Click);
            // 
            // QRScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.QrPic);
            this.Name = "QRScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRScreen";
            this.Load += new System.EventHandler(this.QRScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QrPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox QrPic;
        private System.Drawing.Printing.PrintDocument qrPrint;
    }
}