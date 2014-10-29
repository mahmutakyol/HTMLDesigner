namespace HTMLDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDugme = new System.Windows.Forms.Button();
            this.btnEtiket = new System.Windows.Forms.Button();
            this.btnArkaPlanOzellikleri = new System.Windows.Forms.Button();
            this.btnMetinKutusu = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnBaglanti = new System.Windows.Forms.Button();
            this.btnRadyoDugmesi = new System.Windows.Forms.Button();
            this.btnSecimKutusu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOnizle = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnDugme);
            this.flowLayoutPanel1.Controls.Add(this.btnEtiket);
            this.flowLayoutPanel1.Controls.Add(this.btnArkaPlanOzellikleri);
            this.flowLayoutPanel1.Controls.Add(this.btnMetinKutusu);
            this.flowLayoutPanel1.Controls.Add(this.btnResim);
            this.flowLayoutPanel1.Controls.Add(this.btnBaglanti);
            this.flowLayoutPanel1.Controls.Add(this.btnRadyoDugmesi);
            this.flowLayoutPanel1.Controls.Add(this.btnSecimKutusu);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnOnizle);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 607);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDugme
            // 
            this.btnDugme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDugme.Location = new System.Drawing.Point(8, 8);
            this.btnDugme.Name = "btnDugme";
            this.btnDugme.Size = new System.Drawing.Size(180, 25);
            this.btnDugme.TabIndex = 0;
            this.btnDugme.Text = "Düğme";
            this.btnDugme.UseVisualStyleBackColor = true;
            this.btnDugme.Click += new System.EventHandler(this.btnDugme_Click);
            // 
            // btnEtiket
            // 
            this.btnEtiket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtiket.Location = new System.Drawing.Point(8, 39);
            this.btnEtiket.Name = "btnEtiket";
            this.btnEtiket.Size = new System.Drawing.Size(180, 25);
            this.btnEtiket.TabIndex = 1;
            this.btnEtiket.Text = "Tablo";
            this.btnEtiket.UseVisualStyleBackColor = false;
            this.btnEtiket.Click += new System.EventHandler(this.btnTablo_Click);
            // 
            // btnArkaPlanOzellikleri
            // 
            this.btnArkaPlanOzellikleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArkaPlanOzellikleri.Location = new System.Drawing.Point(8, 70);
            this.btnArkaPlanOzellikleri.Name = "btnArkaPlanOzellikleri";
            this.btnArkaPlanOzellikleri.Size = new System.Drawing.Size(180, 25);
            this.btnArkaPlanOzellikleri.TabIndex = 9;
            this.btnArkaPlanOzellikleri.Text = "Arkaplan";
            this.btnArkaPlanOzellikleri.UseVisualStyleBackColor = true;
            this.btnArkaPlanOzellikleri.Click += new System.EventHandler(this.btnArkaPlanOzellikleri_Click);
            // 
            // btnMetinKutusu
            // 
            this.btnMetinKutusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMetinKutusu.Location = new System.Drawing.Point(8, 101);
            this.btnMetinKutusu.Name = "btnMetinKutusu";
            this.btnMetinKutusu.Size = new System.Drawing.Size(180, 25);
            this.btnMetinKutusu.TabIndex = 2;
            this.btnMetinKutusu.Text = "Metin Kutusu";
            this.btnMetinKutusu.UseVisualStyleBackColor = true;
            this.btnMetinKutusu.Click += new System.EventHandler(this.btnMetinKutusu_Click);
            // 
            // btnResim
            // 
            this.btnResim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResim.Location = new System.Drawing.Point(8, 132);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(180, 25);
            this.btnResim.TabIndex = 3;
            this.btnResim.Text = "Resim";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnBaglanti
            // 
            this.btnBaglanti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaglanti.Location = new System.Drawing.Point(8, 163);
            this.btnBaglanti.Name = "btnBaglanti";
            this.btnBaglanti.Size = new System.Drawing.Size(180, 25);
            this.btnBaglanti.TabIndex = 4;
            this.btnBaglanti.Text = "Bağlantı";
            this.btnBaglanti.UseVisualStyleBackColor = true;
            this.btnBaglanti.Click += new System.EventHandler(this.btnBaglanti_Click);
            // 
            // btnRadyoDugmesi
            // 
            this.btnRadyoDugmesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRadyoDugmesi.Location = new System.Drawing.Point(8, 194);
            this.btnRadyoDugmesi.Name = "btnRadyoDugmesi";
            this.btnRadyoDugmesi.Size = new System.Drawing.Size(180, 25);
            this.btnRadyoDugmesi.TabIndex = 5;
            this.btnRadyoDugmesi.Text = "Radyo Düğmesi";
            this.btnRadyoDugmesi.UseVisualStyleBackColor = true;
            this.btnRadyoDugmesi.Click += new System.EventHandler(this.btnRadyoDugmesi_Click);
            // 
            // btnSecimKutusu
            // 
            this.btnSecimKutusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSecimKutusu.Location = new System.Drawing.Point(8, 225);
            this.btnSecimKutusu.Name = "btnSecimKutusu";
            this.btnSecimKutusu.Size = new System.Drawing.Size(180, 25);
            this.btnSecimKutusu.TabIndex = 6;
            this.btnSecimKutusu.Text = "Seçim Kutusu";
            this.btnSecimKutusu.UseVisualStyleBackColor = true;
            this.btnSecimKutusu.Click += new System.EventHandler(this.btnSecimKutusu_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 298);
            this.panel2.TabIndex = 10;
            // 
            // btnOnizle
            // 
            this.btnOnizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnizle.Location = new System.Drawing.Point(8, 560);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(180, 25);
            this.btnOnizle.TabIndex = 11;
            this.btnOnizle.Text = "Önizle";
            this.btnOnizle.UseVisualStyleBackColor = true;
            this.btnOnizle.Click += new System.EventHandler(this.btnOnizle_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Location = new System.Drawing.Point(218, 12);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(764, 607);
            this.pnlForm.TabIndex = 1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(994, 631);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTMLDesigner";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnDugme;
        private System.Windows.Forms.Button btnEtiket;
        private System.Windows.Forms.Button btnMetinKutusu;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnBaglanti;
        private System.Windows.Forms.Button btnRadyoDugmesi;
        private System.Windows.Forms.Button btnSecimKutusu;
        private System.Windows.Forms.Button btnArkaPlanOzellikleri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOnizle;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

