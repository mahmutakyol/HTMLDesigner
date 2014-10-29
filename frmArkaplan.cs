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
    public partial class frmArkaplan : Form
    {
        public static String renkKodu;
        public frmArkaplan()
        {
            InitializeComponent();
            renkKodu = "";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            clr.ShowDialog();
            BackColor = clr.Color;
            renkKodu = Convert.ToString(clr.GetHashCode());
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
