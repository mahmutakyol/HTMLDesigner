namespace HTMLDesigner
{
    partial class frmTablo
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
            this.btnTabloOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.txtSütun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStrSayısı = new System.Windows.Forms.TextBox();
            this.txtStnSayısı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTabloOlustur
            // 
            this.btnTabloOlustur.Location = new System.Drawing.Point(120, 131);
            this.btnTabloOlustur.Name = "btnTabloOlustur";
            this.btnTabloOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnTabloOlustur.TabIndex = 4;
            this.btnTabloOlustur.Text = "Oluştur";
            this.btnTabloOlustur.UseVisualStyleBackColor = true;
            this.btnTabloOlustur.Click += new System.EventHandler(this.btnBaslikOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Satır Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sütun Sayısı:";
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(15, 25);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(100, 20);
            this.txtSatir.TabIndex = 7;
            // 
            // txtSütun
            // 
            this.txtSütun.Location = new System.Drawing.Point(15, 76);
            this.txtSütun.Name = "txtSütun";
            this.txtSütun.Size = new System.Drawing.Size(100, 20);
            this.txtSütun.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Satır Yüksekliği  :";
            // 
            // txtStrSayısı
            // 
            this.txtStrSayısı.Location = new System.Drawing.Point(193, 24);
            this.txtStrSayısı.Name = "txtStrSayısı";
            this.txtStrSayısı.Size = new System.Drawing.Size(100, 20);
            this.txtStrSayısı.TabIndex = 10;
            // 
            // txtStnSayısı
            // 
            this.txtStnSayısı.Location = new System.Drawing.Point(193, 76);
            this.txtStnSayısı.Name = "txtStnSayısı";
            this.txtStnSayısı.Size = new System.Drawing.Size(100, 20);
            this.txtStnSayısı.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sütun genişliği :";
            // 
            // frmTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 166);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStnSayısı);
            this.Controls.Add(this.txtStrSayısı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSütun);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTabloOlustur);
            this.Name = "frmTablo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Başlık Özellikleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTabloOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.TextBox txtSütun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStrSayısı;
        private System.Windows.Forms.TextBox txtStnSayısı;
        private System.Windows.Forms.Label label4;
    }
}