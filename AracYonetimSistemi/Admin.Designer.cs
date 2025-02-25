namespace AracYonetimSistemi
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxAracFiltreleme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGüncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.comboBoxAracTürü = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxYakit = new System.Windows.Forms.TextBox();
            this.textBoxYil = new System.Windows.Forms.TextBox();
            this.textBoxAracDurumu = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.comboBoxAracFiltreleme);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ARAÇLAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxAracFiltreleme
            // 
            this.comboBoxAracFiltreleme.FormattingEnabled = true;
            this.comboBoxAracFiltreleme.Items.AddRange(new object[] {
            "",
            "Car",
            "Truck",
            "Boat",
            "Airplane"});
            this.comboBoxAracFiltreleme.Location = new System.Drawing.Point(132, 297);
            this.comboBoxAracFiltreleme.Name = "comboBoxAracFiltreleme";
            this.comboBoxAracFiltreleme.Size = new System.Drawing.Size(183, 24);
            this.comboBoxAracFiltreleme.TabIndex = 21;
            this.comboBoxAracFiltreleme.SelectedIndexChanged += new System.EventHandler(this.comboBoxAracFiltreleme_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(45, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Arac Türü";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(48, 342);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(777, 277);
            this.treeView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.buttonGüncelle);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.buttonEkle);
            this.groupBox1.Controls.Add(this.comboBoxAracTürü);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxYakit);
            this.groupBox1.Controls.Add(this.textBoxYil);
            this.groupBox1.Controls.Add(this.textBoxAracDurumu);
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Controls.Add(this.textBoxMarka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(146, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "s";
            // 
            // buttonGüncelle
            // 
            this.buttonGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGüncelle.BackgroundImage")));
            this.buttonGüncelle.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonGüncelle.Location = new System.Drawing.Point(346, 245);
            this.buttonGüncelle.Name = "buttonGüncelle";
            this.buttonGüncelle.Size = new System.Drawing.Size(170, 34);
            this.buttonGüncelle.TabIndex = 28;
            this.buttonGüncelle.Text = "Güncelle";
            this.buttonGüncelle.UseVisualStyleBackColor = true;
            this.buttonGüncelle.Click += new System.EventHandler(this.buttonGüncelle_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(315, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 156);
            this.panel1.TabIndex = 22;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEkle.BackgroundImage")));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonEkle.Location = new System.Drawing.Point(138, 245);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(170, 34);
            this.buttonEkle.TabIndex = 21;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // comboBoxAracTürü
            // 
            this.comboBoxAracTürü.FormattingEnabled = true;
            this.comboBoxAracTürü.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Boat",
            "Airplane"});
            this.comboBoxAracTürü.Location = new System.Drawing.Point(94, 26);
            this.comboBoxAracTürü.Name = "comboBoxAracTürü";
            this.comboBoxAracTürü.Size = new System.Drawing.Size(183, 24);
            this.comboBoxAracTürü.TabIndex = 19;
            this.comboBoxAracTürü.SelectedIndexChanged += new System.EventHandler(this.comboBoxAracTürü_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(26, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Arac Türü";
            // 
            // textBoxYakit
            // 
            this.textBoxYakit.Location = new System.Drawing.Point(89, 191);
            this.textBoxYakit.Multiline = true;
            this.textBoxYakit.Name = "textBoxYakit";
            this.textBoxYakit.Size = new System.Drawing.Size(188, 29);
            this.textBoxYakit.TabIndex = 15;
            // 
            // textBoxYil
            // 
            this.textBoxYil.Location = new System.Drawing.Point(89, 148);
            this.textBoxYil.Multiline = true;
            this.textBoxYil.Name = "textBoxYil";
            this.textBoxYil.Size = new System.Drawing.Size(188, 29);
            this.textBoxYil.TabIndex = 14;
            // 
            // textBoxAracDurumu
            // 
            this.textBoxAracDurumu.Location = new System.Drawing.Point(442, 195);
            this.textBoxAracDurumu.Multiline = true;
            this.textBoxAracDurumu.Name = "textBoxAracDurumu";
            this.textBoxAracDurumu.Size = new System.Drawing.Size(177, 29);
            this.textBoxAracDurumu.TabIndex = 25;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(89, 102);
            this.textBoxModel.Multiline = true;
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(188, 29);
            this.textBoxModel.TabIndex = 13;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(89, 61);
            this.textBoxMarka.Multiline = true;
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(188, 29);
            this.textBoxMarka.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(343, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Arac Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(26, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yakıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(26, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 658);
            this.tabControl1.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 659);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxAracFiltreleme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ComboBox comboBoxAracTürü;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxYakit;
        private System.Windows.Forms.TextBox textBoxYil;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonGüncelle;
        private System.Windows.Forms.TextBox textBoxAracDurumu;
    }
}