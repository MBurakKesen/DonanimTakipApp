namespace ConsoleUI
{
    partial class Anasayfa
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
            this.urovo = new System.Windows.Forms.Button();
            this.yazicilarVeSeriNo = new System.Windows.Forms.Button();
            this.ucretliOnarimTakip = new System.Windows.Forms.Button();
            this.htyeraEnvanter = new System.Windows.Forms.Button();
            this.urovaGarantiTakip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urovo
            // 
            this.urovo.Location = new System.Drawing.Point(101, 246);
            this.urovo.Name = "urovo";
            this.urovo.Size = new System.Drawing.Size(148, 74);
            this.urovo.TabIndex = 9;
            this.urovo.Text = "Urovo Envanter";
            this.urovo.UseVisualStyleBackColor = true;
            this.urovo.Click += new System.EventHandler(this.urovo_Click);
            // 
            // yazicilarVeSeriNo
            // 
            this.yazicilarVeSeriNo.Location = new System.Drawing.Point(552, 236);
            this.yazicilarVeSeriNo.Name = "yazicilarVeSeriNo";
            this.yazicilarVeSeriNo.Size = new System.Drawing.Size(148, 74);
            this.yazicilarVeSeriNo.TabIndex = 8;
            this.yazicilarVeSeriNo.Text = "Yazıcılar";
            this.yazicilarVeSeriNo.UseVisualStyleBackColor = true;
            this.yazicilarVeSeriNo.Click += new System.EventHandler(this.yazicilarVeSeriNo_Click);
            // 
            // ucretliOnarimTakip
            // 
            this.ucretliOnarimTakip.Location = new System.Drawing.Point(327, 131);
            this.ucretliOnarimTakip.Name = "ucretliOnarimTakip";
            this.ucretliOnarimTakip.Size = new System.Drawing.Size(148, 74);
            this.ucretliOnarimTakip.TabIndex = 7;
            this.ucretliOnarimTakip.Text = "Ücretli Onarim Takip";
            this.ucretliOnarimTakip.UseVisualStyleBackColor = true;
            this.ucretliOnarimTakip.Click += new System.EventHandler(this.ucretliOnarimTakip_Click);
            // 
            // htyeraEnvanter
            // 
            this.htyeraEnvanter.Location = new System.Drawing.Point(101, 131);
            this.htyeraEnvanter.Name = "htyeraEnvanter";
            this.htyeraEnvanter.Size = new System.Drawing.Size(148, 74);
            this.htyeraEnvanter.TabIndex = 6;
            this.htyeraEnvanter.Text = "Hytera Envanter";
            this.htyeraEnvanter.UseVisualStyleBackColor = true;
            this.htyeraEnvanter.Click += new System.EventHandler(this.htyeraEnvanter_Click);
            // 
            // urovaGarantiTakip
            // 
            this.urovaGarantiTakip.Location = new System.Drawing.Point(552, 131);
            this.urovaGarantiTakip.Name = "urovaGarantiTakip";
            this.urovaGarantiTakip.Size = new System.Drawing.Size(148, 74);
            this.urovaGarantiTakip.TabIndex = 5;
            this.urovaGarantiTakip.Text = "Urovo Garanti Takip";
            this.urovaGarantiTakip.UseVisualStyleBackColor = true;
            this.urovaGarantiTakip.Click += new System.EventHandler(this.urovaGarantiTakip_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.urovo);
            this.Controls.Add(this.yazicilarVeSeriNo);
            this.Controls.Add(this.ucretliOnarimTakip);
            this.Controls.Add(this.htyeraEnvanter);
            this.Controls.Add(this.urovaGarantiTakip);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button urovo;
        private System.Windows.Forms.Button yazicilarVeSeriNo;
        private System.Windows.Forms.Button ucretliOnarimTakip;
        private System.Windows.Forms.Button htyeraEnvanter;
        private System.Windows.Forms.Button urovaGarantiTakip;
    }
}

