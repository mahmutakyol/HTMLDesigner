using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTMLDesigner
{
    public partial class frmResim : Form
    {
        public static string url;
        public frmResim()
        {
            InitializeComponent();
            url = "";
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFyolu.Text = openFileDialog1.FileName;
            label1.Text = openFileDialog1.SafeFileName;
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            url = txtFyolu.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
