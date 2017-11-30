namespace WindowsFormIlkProje
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSeciliItem = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veriler :";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(82, 28);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(252, 20);
            this.txtSehir.TabIndex = 1;
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.Location = new System.Drawing.Point(82, 66);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.Size = new System.Drawing.Size(252, 134);
            this.lstSehirler.TabIndex = 2;
            this.lstSehirler.SelectedIndexChanged += new System.EventHandler(this.lstSehirler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(259, 231);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSeciliItem
            // 
            this.lblSeciliItem.AutoSize = true;
            this.lblSeciliItem.Location = new System.Drawing.Point(25, 236);
            this.lblSeciliItem.Name = "lblSeciliItem";
            this.lblSeciliItem.Size = new System.Drawing.Size(35, 13);
            this.lblSeciliItem.TabIndex = 4;
            this.lblSeciliItem.Text = "label2";
            this.lblSeciliItem.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(259, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 442);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSeciliItem);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.ListBox lstSehirler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSeciliItem;
        private System.Windows.Forms.Button btnSil;
    }
}

