using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class UC_GiaoVien : UserControl
    {
        public UC_GiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemGV fthemgv = new frmThemGV();
            fthemgv.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaGV fsuagv = new frmSuaGV();
            fsuagv.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

            }
            else
            {

            }
        }
    }
}
