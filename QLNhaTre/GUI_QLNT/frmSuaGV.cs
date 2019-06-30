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
    public partial class frmSuaGV : Form
    {
        public frmSuaGV()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int maGV;
        public frmSuaGV(DTO_QLNT.GiaoVien gv)
        {
            InitializeComponent();

            maGV = gv.MaGiaoVien;
            txtHoTen.Text = gv.HoTen;
            dtpkNgaySinh.Value = gv.NgaySinh;
            if (gv.GioiTinh == "Nam")
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;
            txtDanToc.Text = gv.DanToc;
            txtTonGiao.Text = gv.TonGiao;
            txtDiaChi.Text = gv.DiaChi;
            txtSDT.Text = gv.Sdt;
            txtTrinhDo.Text = gv.TrinhDo;
            dtpkNgayVaoLam.Value = gv.NgayVaoLam;
        }



        private void SuaGiaoVien(int maGiaoVien, string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            if (GiaoVienBUS.Instance.SuaGiaoVien(maGiaoVien, hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tonGiao))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
                MessageBox.Show("Sửa Thất Bại");
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {

            string hoTen = txtHoTen.Text;
            string gioitinh;
            if (rbtnNam.Checked == true)
            {
                gioitinh = rbtnNam.Text;

            }
            else
                gioitinh = rbtnNu.Text;
            string ngaysinh = dtpkNgaySinh.Value.Date.ToString("MM/dd/yyyy");
            string dantoc = txtDanToc.Text;
            string tongiao = txtTonGiao.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string ngayvaolam = dtpkNgayVaoLam.Value.Date.ToString("MM/dd/yyyy");
            string trinhdo = txtTrinhDo.Text;
            SuaGiaoVien(maGV, hoTen, gioitinh, ngaysinh, dantoc, diachi, sdt, trinhdo, ngayvaolam, tongiao);
            this.Dispose();
        }

    }
}
