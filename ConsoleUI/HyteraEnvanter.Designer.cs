﻿namespace ConsoleUI
{
    partial class HyteraEnvanter
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
            this.SuspendLayout();
            // 
            // geriDon
            // 
            this.geriDon.Location = new System.Drawing.Point(0, 0);
            this.geriDon.Name = "geriDon";
            this.geriDon.Size = new System.Drawing.Size(75, 23);
            this.geriDon.TabIndex = 0;
            this.geriDon.Text = "Geri";
            this.geriDon.UseVisualStyleBackColor = true;
            this.geriDon.Click += new System.EventHandler(this.geriDon_Click);
            // 
            // HyteraEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geriDon);
            this.Name = "HyteraEnvanter";
            this.Text = "HyteraEnvanter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button geriDon;
    }
}