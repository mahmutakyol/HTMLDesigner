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
    public partial class frmBaglanti : Form
    {
        public static string baslik, url;

        public frmBaglanti()
        {
            InitializeComponent();
            baslik = "";
            url = "";
        }        

        private void btnURLOlustur_Click(object sender, EventArgs e)
        {
            baslik = txtBaslik.Text;
            url = txtURL.Text;
            this.Close();
        }
    }
}
