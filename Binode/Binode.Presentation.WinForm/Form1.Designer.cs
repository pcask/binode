namespace Binode.Presentation.WinForm
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
            this.grpKategori = new System.Windows.Forms.GroupBox();
            this.treeKategori = new System.Windows.Forms.TreeView();
            this.grpIcerik = new System.Windows.Forms.GroupBox();
            this.lstViewIcerik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpKategori.SuspendLayout();
            this.grpIcerik.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKategori
            // 
            this.grpKategori.Controls.Add(this.treeKategori);
            this.grpKategori.Location = new System.Drawing.Point(12, 12);
            this.grpKategori.Name = "grpKategori";
            this.grpKategori.Size = new System.Drawing.Size(200, 430);
            this.grpKategori.TabIndex = 0;
            this.grpKategori.TabStop = false;
            this.grpKategori.Text = "Kategori";
            // 
            // treeKategori
            // 
            this.treeKategori.Location = new System.Drawing.Point(6, 19);
            this.treeKategori.Name = "treeKategori";
            this.treeKategori.Size = new System.Drawing.Size(188, 405);
            this.treeKategori.TabIndex = 0;
            this.treeKategori.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeKategori_AfterSelect);
            this.treeKategori.DoubleClick += new System.EventHandler(this.treeKategori_DoubleClick);
            // 
            // grpIcerik
            // 
            this.grpIcerik.Controls.Add(this.lstViewIcerik);
            this.grpIcerik.Location = new System.Drawing.Point(218, 12);
            this.grpIcerik.Name = "grpIcerik";
            this.grpIcerik.Size = new System.Drawing.Size(566, 430);
            this.grpIcerik.TabIndex = 1;
            this.grpIcerik.TabStop = false;
            this.grpIcerik.Text = "İçerik";
            // 
            // lstViewIcerik
            // 
            this.lstViewIcerik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstViewIcerik.Location = new System.Drawing.Point(6, 19);
            this.lstViewIcerik.Name = "lstViewIcerik";
            this.lstViewIcerik.Size = new System.Drawing.Size(554, 405);
            this.lstViewIcerik.TabIndex = 0;
            this.lstViewIcerik.UseCompatibleStateImageBehavior = false;
            this.lstViewIcerik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Eklenme Tarihi";
            this.columnHeader2.Width = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.grpIcerik);
            this.Controls.Add(this.grpKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKategori.ResumeLayout(false);
            this.grpIcerik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKategori;
        private System.Windows.Forms.TreeView treeKategori;
        private System.Windows.Forms.GroupBox grpIcerik;
        private System.Windows.Forms.ListView lstViewIcerik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

