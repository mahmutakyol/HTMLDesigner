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
    public partial class frmOnizle : Form
    {
        public frmOnizle()
        {
            InitializeComponent();
        }

        private void frmOnizle_Load(object sender, EventArgs e)
        {
            w.Navigate(Application.StartupPath + "/index.html");
        }
    }
}
