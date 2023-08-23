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
            ((System.ComponentModel.ISupportInitialize)(this.QrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // QrPic
            // 
            this.QrPic.Location = new System.Drawing.Point(147, 51);
            this.QrPic.Name = "QrPic";
            this.QrPic.Size = new System.Drawing.Size(491, 357);
            this.QrPic.TabIndex = 0;
            this.QrPic.TabStop = false;
            this.QrPic.Click += new System.EventHandler(this.QrPic_Click);
            // 
            // QRScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QrPic);
            this.Name = "QRScreen";
            this.Text = "QRScreen";
            this.Load += new System.EventHandler(this.QRScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QrPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox QrPic;
    }
}