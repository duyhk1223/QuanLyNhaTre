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
    public partial class UC_HocSinh : UserControl
    {
        public UC_HocSinh()
        {
            InitializeComponent();
        }

        

        private void tabctrlHocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHocsinh.SelectedTab == tabDSHS)
            {
                btnLuu.Hide();
                label3.Hide();
                cbThangdo.Hide();
                button1.Hide();
                btnThem.Show();
                btnSua.Show();
                btnXoa.Show();
            }
            else
            {
                
                btnLuu.Show();
                label3.Show();
                cbThangdo.Show();
                button1.Show();
                btnThem.Hide();
                btnSua.Hide();
                btnXoa.Hide();
            }
        }

        private void UC_HocSinh_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHS fthem = new frmThemHS();
            fthem.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaHS fsua = new frmSuaHS();
            fsua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?","Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
            }
            else
            {
                
            }
        }
    }
    
}
