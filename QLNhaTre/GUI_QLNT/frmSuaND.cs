using BUS_QLNT;
using DTO_QLNT;
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
    public partial class frmSuaND : Form
    {
        public frmSuaND()
        {
            InitializeComponent();
        }

        int Id;
        
        public frmSuaND(NguoiDung gv)
        {
            InitializeComponent();
            LoadTenGvtoCombobox();

            Id = gv.Id;
            txtTaiKhoan.Text = gv.TaiKhoan;
            cbGiaoVien.SelectedValue = gv.MaGV;
            cbQuyen.SelectedItem = gv.Quyen;
        }

      

        #region phương thức

        private void SuaUsers(int id, string taiKhoan, int maGV, string quyen)
        {
            if (NguoiDungBUS.Instance.SuaUsers(id, taiKhoan, maGV, quyen))
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool CheckData()
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return false;
            }
            return true;
        }

        private void LoadTenGvtoCombobox()
        {
            cbGiaoVien.DisplayMember = "HoTen";
            cbGiaoVien.ValueMember = "MaGV";
            cbGiaoVien.DataSource = GiaoVienBUS.Instance.GetGiaoVien();
        }

        #endregion

        #region sự kiện

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string taiKhoan = txtTaiKhoan.Text;
                string quyen = cbQuyen.SelectedItem.ToString();
                int magv = (int)cbGiaoVien.SelectedValue;
                SuaUsers(Id, taiKhoan, magv, quyen);
                this.Dispose();
            }
        }

        #endregion








        
    }
}
