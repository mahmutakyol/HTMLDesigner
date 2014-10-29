namespace HTMLDesigner
{
    partial class frmOnizle
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
            this.w = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.Dock = System.Windows.Forms.DockStyle.Fill;
            this.w.Location = new System.Drawing.Point(0, 0);
            this.w.MinimumSize = new System.Drawing.Size(20, 20);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(648, 432);
            this.w.TabIndex = 0;
            // 
            // frmOnizle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 432);
            this.Controls.Add(this.w);
            this.Name = "frmOnizle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Önizleme";
            this.Load += new System.EventHandler(this.frmOnizle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser w;
    }
}