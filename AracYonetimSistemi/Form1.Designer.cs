namespace AracYonetimSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdminGirisi = new System.Windows.Forms.Button();
            this.buttonKulaniciGirisi = new System.Windows.Forms.Button();
            this.textBoxKulaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdminGirisi
            // 
            this.buttonAdminGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdminGirisi.BackgroundImage")));
            this.buttonAdminGirisi.Location = new System.Drawing.Point(155, 435);
            this.buttonAdminGirisi.Name = "buttonAdminGirisi";
            this.buttonAdminGirisi.Size = new System.Drawing.Size(124, 28);
            this.buttonAdminGirisi.TabIndex = 0;
            this.buttonAdminGirisi.Text = "Admin";
            this.buttonAdminGirisi.UseVisualStyleBackColor = true;
            this.buttonAdminGirisi.Click += new System.EventHandler(this.buttonAdminGirisi_Click);
            // 
            // buttonKulaniciGirisi
            // 
            this.buttonKulaniciGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKulaniciGirisi.BackgroundImage")));
            this.buttonKulaniciGirisi.Location = new System.Drawing.Point(299, 435);
            this.buttonKulaniciGirisi.Name = "buttonKulaniciGirisi";
            this.buttonKulaniciGirisi.Size = new System.Drawing.Size(123, 27);
            this.buttonKulaniciGirisi.TabIndex = 1;
            this.buttonKulaniciGirisi.Text = "Kulanıcı";
            this.buttonKulaniciGirisi.UseVisualStyleBackColor = true;
            this.buttonKulaniciGirisi.Click += new System.EventHandler(this.buttonKulaniciGirisi_Click);
            // 
            // textBoxKulaniciAdi
            // 
            this.textBoxKulaniciAdi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxKulaniciAdi.Location = new System.Drawing.Point(155, 311);
            this.textBoxKulaniciAdi.Name = "textBoxKulaniciAdi";
            this.textBoxKulaniciAdi.Size = new System.Drawing.Size(267, 22);
            this.textBoxKulaniciAdi.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(155, 360);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(267, 22);
            this.textBoxSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kulanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKulaniciAdi);
            this.Controls.Add(this.buttonKulaniciGirisi);
            this.Controls.Add(this.buttonAdminGirisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aracım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminGirisi;
        private System.Windows.Forms.Button buttonKulaniciGirisi;
        private System.Windows.Forms.TextBox textBoxKulaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

