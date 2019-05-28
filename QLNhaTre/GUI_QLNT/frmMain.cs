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
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn3);
        }
    }
}
