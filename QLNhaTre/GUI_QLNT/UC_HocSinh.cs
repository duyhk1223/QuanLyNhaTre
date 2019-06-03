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

        private void uC_DSHS_Load(object sender, EventArgs e)
        {

        }

        private void tabctrlHocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHocsinh.SelectedTab == tabDSHS)
            {
                btnLuu.Hide();
                btnThem.Show();
                btnSua.Show();
                btnXoa.Show();
            }
            else
            {
                btnLuu.Show();
                btnThem.Hide();
                btnSua.Hide();
                btnXoa.Hide();
            }
        }
    }
    
}
