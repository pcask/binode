namespace WindowsFormIlkProje
{
    partial class Form3
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
            this.tvKategoriler = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriGiris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnAnaKategori = new System.Windows.Forms.RadioButton();
            this.rdBtnAltKategori = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnGizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvKategoriler
            // 
            this.tvKategoriler.Location = new System.Drawing.Point(12, 40);
            this.tvKategoriler.Name = "tvKategoriler";
            this.tvKategoriler.Size = new System.Drawing.Size(192, 342);
            this.tvKategoriler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Kategoriler";
            // 
            // txtKategoriGiris
            // 
            this.txtKategoriGiris.Location = new System.Drawing.Point(222, 40);
            this.txtKategoriGiris.Name = "txtKategoriGiris";
            this.txtKategoriGiris.Size = new System.Drawing.Size(239, 20);
            this.txtKategoriGiris.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Kategori Giriş";
            // 
            // rdBtnAnaKategori
            // 
            this.rdBtnAnaKategori.AutoSize = true;
            this.rdBtnAnaKategori.Location = new System.Drawing.Point(222, 67);
            this.rdBtnAnaKategori.Name = "rdBtnAnaKategori";
            this.rdBtnAnaKategori.Size = new System.Drawing.Size(86, 17);
            this.rdBtnAnaKategori.TabIndex = 4;
            this.rdBtnAnaKategori.TabStop = true;
            this.rdBtnAnaKategori.Text = "Ana Katagori";
            this.rdBtnAnaKategori.UseVisualStyleBackColor = true;
            // 
            // rdBtnAltKategori
            // 
            this.rdBtnAltKategori.AutoSize = true;
            this.rdBtnAltKategori.Location = new System.Drawing.Point(222, 91);
            this.rdBtnAltKategori.Name = "rdBtnAltKategori";
            this.rdBtnAltKategori.Size = new System.Drawing.Size(79, 17);
            this.rdBtnAltKategori.TabIndex = 5;
            this.rdBtnAltKategori.TabStop = true;
            this.rdBtnAltKategori.Text = "Alt Kategori";
            this.rdBtnAltKategori.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(333, 67);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 41);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(222, 142);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(222, 171);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 8;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGizle
            // 
            this.btnGizle.Location = new System.Drawing.Point(222, 201);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(75, 23);
            this.btnGizle.TabIndex = 9;
            this.btnGizle.Text = "GİZLE";
            this.btnGizle.UseVisualStyleBackColor = true;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 384);
            this.Controls.Add(this.btnGizle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.rdBtnAltKategori);
            this.Controls.Add(this.rdBtnAnaKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvKategoriler);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvKategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBtnAnaKategori;
        private System.Windows.Forms.RadioButton rdBtnAltKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGizle;
    }
}