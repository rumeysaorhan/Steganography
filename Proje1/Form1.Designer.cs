namespace Proje1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDosyaAc = new System.Windows.Forms.Button();
            this.textBoxDosyaAc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.buttonGizle = new System.Windows.Forms.Button();
            this.buttonCoz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDosyaAc
            // 
            this.buttonDosyaAc.Location = new System.Drawing.Point(26, 12);
            this.buttonDosyaAc.Name = "buttonDosyaAc";
            this.buttonDosyaAc.Size = new System.Drawing.Size(75, 23);
            this.buttonDosyaAc.TabIndex = 1;
            this.buttonDosyaAc.Text = "Dosya Aç";
            this.buttonDosyaAc.UseVisualStyleBackColor = false;
            this.buttonDosyaAc.Click += new System.EventHandler(this.buttonDosyaAc_Click);
            // 
            // textBoxDosyaAc
            // 
            this.textBoxDosyaAc.Location = new System.Drawing.Point(130, 12);
            this.textBoxDosyaAc.Name = "textBoxDosyaAc";
            this.textBoxDosyaAc.Size = new System.Drawing.Size(170, 20);
            this.textBoxDosyaAc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesajı Girin:";
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(93, 205);
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(207, 20);
            this.textBoxMesaj.TabIndex = 4;
            // 
            // buttonGizle
            // 
            this.buttonGizle.Location = new System.Drawing.Point(26, 258);
            this.buttonGizle.Name = "buttonGizle";
            this.buttonGizle.Size = new System.Drawing.Size(75, 23);
            this.buttonGizle.TabIndex = 5;
            this.buttonGizle.Text = "Gizle";
            this.buttonGizle.UseVisualStyleBackColor = false;
            this.buttonGizle.Click += new System.EventHandler(this.buttonGizle_Click);
            // 
            // buttonCoz
            // 
            this.buttonCoz.Location = new System.Drawing.Point(225, 258);
            this.buttonCoz.Name = "buttonCoz";
            this.buttonCoz.Size = new System.Drawing.Size(75, 23);
            this.buttonCoz.TabIndex = 6;
            this.buttonCoz.Text = "Çöz";
            this.buttonCoz.UseVisualStyleBackColor = false;
            this.buttonCoz.Click += new System.EventHandler(this.buttonCoz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 302);
            this.Controls.Add(this.buttonCoz);
            this.Controls.Add(this.buttonGizle);
            this.Controls.Add(this.textBoxMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDosyaAc);
            this.Controls.Add(this.buttonDosyaAc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDosyaAc;
        private System.Windows.Forms.TextBox textBoxDosyaAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMesaj;
        private System.Windows.Forms.Button buttonGizle;
        private System.Windows.Forms.Button buttonCoz;
    }
}

