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
    public partial class frmTablo : Form
    {
        public static string satir;
        public static string sütun;
        public static string sütunGenisliği;
        public static string satırGenisliği;

        public frmTablo()
        {
            InitializeComponent();
            satir = "";
            sütun = "";
            satırGenisliği = "";
            sütunGenisliği = "";
        }

        private void btnBaslikOlustur_Click(object sender, EventArgs e)
        {
            satir = txtSatir.Text;
            sütun = txtSütun.Text;
            satırGenisliği = txtStrSayısı.Text;
            sütunGenisliği = txtStnSayısı.Text;
            this.Close();
        }
    }
}
