using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_QLNT
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UC_HocSinh uC_HocSinh = new UC_HocSinh();
            AddControlsToPanel(uC_HocSinh);
        }

        private void moveSidePanel(Control btn)
        {
            pnlSide.Top = btn.Top;
            pnlSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {

            while (pnlControl.Controls.Count > 0)
            {
                pnlControl.Controls[0].Dispose();
            }
            c.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(c);
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHocsinh);
            UC_HocSinh uC_HocSinh = new UC_HocSinh();
            AddControlsToPanel(uC_HocSinh);
        }

        private void btnHethong_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHethong);
            UC_HeThong uC_HeThong = new UC_HeThong();
            AddControlsToPanel(uC_HeThong);
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnGiaovien);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
