using BUS_QLNT;
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
    public partial class frmThemGV : Form
    {
        public frmThemGV()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private string GetGioiTinh()
        {
            if (rbtnNam.Checked == true)
            {
                return rbtnNam.Text;
            }
            else
            {
                return rbtnNu.Text;
            }

        }
        private void ThemGiaoVien(string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tongiao)
        {
            if (GiaoVienBUS.Instance.ThemGiaoVien(hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tongiao))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm Thất bại");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string gioitinh = GetGioiTinh();
            string ngaysinh = dtpkNgaySinh.Value.Date.ToString("MM/dd/yyyy");
            string dantoc = txtDanToc.Text;
            string tongiao = txtTonGiao.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string ngayvaolam = dtpkNgayVaoLam.Value.Date.ToString("MM/dd/yyyy");
            string trinhdo = txtTrinhDo.Text;
            ThemGiaoVien(hoTen, gioitinh, ngaysinh, dantoc, diachi, sdt, trinhdo, ngayvaolam, tongiao);
            this.Dispose();
        }
    }
}
