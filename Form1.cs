using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace HTMLDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ResumeLayout(false);
        }
        public static bool clicked = false;
        public static int iOldX, iOldY, iClickX, iClickY;

        private void btnDugme_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Left = 0;
            btn.Top = 0;
            btn.AutoSize = true;
            string dugmeMetni = Interaction.InputBox("Düğme metnini yazınız:","","Düğme");
            if (dugmeMetni.Trim() == "")
            {
                dugmeMetni = "Düğme";
            }
            btn.Text = dugmeMetni; 
            btn.MouseDown += kontrolMouseDown;
            btn.MouseMove += kontrolMouseMove;
            btn.MouseUp += kontrolMouseUp;
            pnlForm.Controls.Add(btn);
        }

        public void kontrolMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = ConvertFromChildToForm(e.X, e.Y, (Control)sender);
                iOldX = p.X;
                iOldY = p.Y;
                iClickX = e.X;
                iClickY = e.Y;
                clicked = true;
            }
        }

        public void kontrolMouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == true)
            {
                Control control = (Control)sender;
                Point p = new Point();
                p.X = e.X + control.Left;
                p.Y = e.Y + control.Top;
                control.Left = p.X - iClickX;
                control.Top = p.Y - iClickY;
            }
        }

        public void kontrolMouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        public Point ConvertFromChildToForm(int x, int y, Control control)
        {
            Point p = new Point(x, y);
            control.Location = p;
            return p;
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            string htmlDokumani = "";
            foreach(Control c in pnlForm.Controls){
                if (c is Button)
                {
                    htmlDokumani += "<input type='submit' style='position:absolute; left:" + c.Left + "; top:" + c.Top + "' value='" + c.Text + "'/>";
                }
                else if (c is LinkLabel)
                {
                    htmlDokumani += "<a style='position:absolute; left:" + c.Left + "; top:" + c.Top + "' href='" + c.Tag + "'>" + c.Text + "</a>";
                }
                else if (c is CheckBox)
                {
                    htmlDokumani += "<label style='position:absolute; left:" + c.Left + "; top:" + c.Top + "'><input type='checkbox' value='" + c.Text + "'/>" + c.Text + "</label>";
                }
                else if (c is RadioButton)
                {
                    htmlDokumani += "<label style='position:absolute; left:" + c.Left + "; top:" + c.Top + "'><input type='radio' value='" + c.Text + "'/>" + c.Text + "</label>";
                }
                else if (c is PictureBox)
                {
                    htmlDokumani += "<img style='position:absolute; left:"+c.Left+"; top:"+c.Top+"' src=" + frmResim.url + " >";
                }
                else if (c is TextBox)
                {
                    htmlDokumani += "<input type='text' size='24' style='position:absolute; left:"+c.Left+"; top:"+c.Top+"'>";
                }
                else if (c is TableLayoutPanel)
                {
                    htmlDokumani += "<table cellpadding=0 cellspacing=0 border=1>";
                    for (int i = 0; i < Convert.ToInt32(frmTablo.satir); i++)
                    {
                        htmlDokumani += "<tr style='height:"+frmTablo.satırGenisliği+"'>";
                        for (int j = 0; j < Convert.ToInt32(frmTablo.sütun); j++)
                        {
                            htmlDokumani += "<td style='width:"+frmTablo.sütunGenisliği+"'>"+(i+1)+". satır - "+(j+1)+". sütün</td>";
                        }
                        htmlDokumani += "</tr>";
                    }
                    htmlDokumani += "</table>";
                }

            }

            StreamWriter yaz = File.CreateText("index.html");
            yaz.WriteLine("<html>");
            yaz.WriteLine("<head>");
            yaz.WriteLine("<meta charset='utf-8'>");
            yaz.WriteLine("</head>");
            yaz.WriteLine("<body bgcolor='" + Convert.ToString(ColorTranslator.ToHtml(pnlForm.BackColor)) + "'>");
            yaz.WriteLine(htmlDokumani);
            yaz.WriteLine("</body>");
            yaz.WriteLine("</html>");
            yaz.Close();

            frmOnizle f = new frmOnizle();
            f.ShowDialog();
        }
                                    
        private void btnBaglanti_Click(object sender, EventArgs e)
        {
            frmBaglanti f = new frmBaglanti();
            f.ShowDialog();
            if (frmBaglanti.baslik.Trim() != "" && frmBaglanti.url.Trim() != "")
            {
                LinkLabel l = new LinkLabel();
                l.Left = 0;
                l.Top = 0;
                l.AutoSize = true;
                l.Text = frmBaglanti.baslik;
                l.Tag = frmBaglanti.url;
                l.MouseDown += kontrolMouseDown;
                l.MouseMove += kontrolMouseMove;
                l.MouseUp += kontrolMouseUp;
                pnlForm.Controls.Add(l);
            }
        }

        private void btnTablo_Click(object sender, EventArgs e)
        {
            frmTablo f = new frmTablo();
            f.ShowDialog();
            if (Convert.ToInt32(frmTablo.satir) > 0 && Convert.ToInt32(frmTablo.sütun) > 0)
            {
                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.Left = 0;
                tlp.Top = 0;
                tlp.AutoSize = true;
                tlp.ColumnCount = Convert.ToInt32(frmTablo.sütun);
                tlp.RowCount = Convert.ToInt32(frmTablo.satir);
                tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
                tlp.ColumnStyles.Clear();
                tlp.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
                for (int i = 0; i < tlp.ColumnCount; i++)
                {
                    ColumnStyle cs = new ColumnStyle(SizeType.Absolute, Convert.ToInt32(frmTablo.sütunGenisliği));
                    tlp.ColumnStyles.Add(cs);
                }
                tlp.RowStyles.Clear();
                for (int i = 0; i < tlp.RowCount; i++)
                {
                    RowStyle cs = new RowStyle(SizeType.Absolute, Convert.ToInt32(frmTablo.satırGenisliği));
                    tlp.RowStyles.Add(cs);
                }
                tlp.MouseDown += kontrolMouseDown;
                tlp.MouseMove += kontrolMouseMove;
                tlp.MouseUp += kontrolMouseUp;
                pnlForm.Controls.Add(tlp);
            }
        }

        private void btnArkaPlanOzellikleri_Click(object sender, EventArgs e)
        {
            frmArkaplan f = new frmArkaplan();
            f.ShowDialog();
                Color clr = new Color();
                clr= f.BackColor;
                pnlForm.BackColor = clr;
            
            
        }

        private void btnRadyoDugmesi_Click(object sender, EventArgs e)
        {
            RadioButton btn = new RadioButton();
            btn.Left = 0;
            btn.Top = 0;
            btn.AutoSize = true;
            string dugmeMetni = Interaction.InputBox("Radio Düğmesi metnini yazınız:", "", "Radio Düğmesi");
            if (dugmeMetni.Trim() == "")
            {
                dugmeMetni = "Radio Düğmesi";
            }
            btn.Text = dugmeMetni;
            btn.MouseDown += kontrolMouseDown;
            btn.MouseMove += kontrolMouseMove;
            btn.MouseUp += kontrolMouseUp;
            pnlForm.Controls.Add(btn);
        }

        private void btnSecimKutusu_Click(object sender, EventArgs e)
        {
            CheckBox chbx = new CheckBox();
            chbx.Left = 0;
            chbx.Top = 0;
            chbx.AutoSize = true;
            string dugmeMetni = Interaction.InputBox("Seçim Kutusu metnini yazınız:", "", "Seçim Kutusu");
            if (dugmeMetni.Trim() == "")
            {
                dugmeMetni = "Seçim Kutusu";
            }
            chbx.Text = dugmeMetni;
            chbx.MouseDown += kontrolMouseDown;
            chbx.MouseMove += kontrolMouseMove;
            chbx.MouseUp += kontrolMouseUp;
            pnlForm.Controls.Add(chbx);
        }

        private void btnMetinKutusu_Click(object sender, EventArgs e)
        {
            TextBox Txtbx = new TextBox();
            Txtbx.Left = 0;
            Txtbx.Top = 0;
            Txtbx.AutoSize = true;
            string metin = Interaction.InputBox("Metin Kutusu için isim yazınız:", "", "Metin Kutusu");
            if (metin.Trim() == "")
            {
                metin = "metin kutusu";
            }
            Txtbx.Text = metin;
            Txtbx.MouseDown += kontrolMouseDown;
            Txtbx.MouseMove += kontrolMouseMove;
            Txtbx.MouseUp += kontrolMouseUp;
            pnlForm.Controls.Add(Txtbx);
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            frmResim f = new frmResim();
            f.ShowDialog();
            PictureBox p = new PictureBox();
            p.Left = 0;
            p.Top = 0;
            p.AutoSize = true;
            p.MouseDown += kontrolMouseDown;
            p.MouseMove += kontrolMouseMove;
            p.MouseUp += kontrolMouseUp;
            p.ImageLocation = frmResim.url;
            pnlForm.Controls.Add(p);
        }

    }
}
