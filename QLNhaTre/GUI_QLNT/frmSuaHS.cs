﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;
using System.Text.RegularExpressions;

namespace GUI_QLNT
{
    public partial class frmSuaHS : Form
    {
        public frmSuaHS()
        {
            InitializeComponent();
        }
        private int mahs;
        
        public frmSuaHS(HocSinh hs, int manamhoc)
        {
            
            InitializeComponent();
            mahs = hs.MaHS;
            txtHoTen.Text = hs.HoTen;

            if (hs.GioiTinh == "Nam")
                rbtnNam.Checked = true;
            else rbtnNu.Checked = true;

            dtpkNgaySinh.Value = hs.NgaySinh;

            
            cbNamHoc.DisplayMember = "NamBDKT";
            cbNamHoc.ValueMember = "MaNamHoc";
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.SelectedValue = manamhoc;

            
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc(manamhoc);
            cbLop.SelectedValue = hs.MaLop;

            dtpkNgayVaoHoc.Value = hs.NgayVaoHoc;

            txtDiaChi.Text = hs.DiaChi;
            txtHoTenCha.Text = hs.HoTenCha;
            txtSDTCha.Text = hs.SdtCha;
            txtHoTenMe.Text = hs.HoTenMe;
            txtSDTMe.Text = hs.SdtMe;
        }


        bool kq;

        #region phương thức

        bool CheckData()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || isName(txtHoTen.Text) == false)
            {
                MessageBox.Show("Họ tên không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (isDoB(dtpkNgaySinh.Value.Date) == false)
            {
                MessageBox.Show("Độ tuổi phải từ 3-5 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpkNgaySinh.Focus();
                return false;
            }
            if (IsNgayVaoHoc(dtpkNgayVaoHoc.Value.Date) == false)
            {
                MessageBox.Show("Ngày vào học không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpkNgayVaoHoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoTenCha.Text) || isName(txtHoTenCha.Text) == false)
            {
                MessageBox.Show("họ tên cha không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenCha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDTCha.Text) || isPhoneNumber(txtSDTCha.Text) == false)
            {
                MessageBox.Show("sdt hợp lệ là từ 9-11 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDTCha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoTenMe.Text) || isName(txtHoTenMe.Text) == false)
            {
                MessageBox.Show("tên mẹ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenMe.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDTMe.Text) || isPhoneNumber(txtSDTMe.Text) == false)
            {
                MessageBox.Show(" sdt hợp lệ là từ 9-11 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDTMe.Focus();
                return false;
            }
            return true;
        }

        private void SuaHocSinh(int mahs, string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            try
            {
                kq = HocSinhBUS.Instance.SuaHocSinh(mahs, ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            }
            catch (SqlException sqlex)
            {

                if (sqlex.Procedure == "SiSoToiDa" || sqlex.Message.Contains("lop full"))
                {
                    MessageBox.Show("Đã đạt tối đa học sinh trong lớp này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Có lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (kq)
                {
                    MessageBox.Show("Cập nhật học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void LoadLoptoCombobox()
        {
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((int)cbNamHoc.SelectedValue);
        }
        // chuẩn hóa họ tên
        public static string FormatProperCase(string str)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);
            // Replace multiple white space to 1 white  space
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");
            //Upcase like Title
            return textInfo.ToTitleCase(str);
        }

        //kiểm tra sdt
        private bool isPhoneNumber(string pText)
        {
            Regex regex = new Regex(@"^\d{9,11}$");
            return regex.IsMatch(pText);
        }
        //kierm tra tên
        private bool isName(string pText)
        {
            Regex regex = new Regex(@"\D[^~!@#$%^&*()_+-=\]{}|:'<>,.?`\/\\]{1,}$");
            return regex.IsMatch(pText);
        }
        private bool isDoB(DateTime date)
        {
            DateTime now = DateTime.Now;
            if (2 < now.Year - date.Year && now.Year - date.Year < 6)
                return true;
            else return false;
        }
        private bool IsNgayVaoHoc(DateTime dt)
        {
            if (dt.Year == DateTime.Now.Year)
            {
                if (dt.Month == DateTime.Now.Month)
                {
                    if (DateTime.Now.Day - dt.Day >= 0)
                        return true;
                    else
                        return false;
                }

            }

            if (dt.Year == DateTime.Now.Year)
            {
                if (dt.Month <= DateTime.Now.Month)
                    return true;
                else return false;
            }
            if (dt.Year <= DateTime.Now.Year)
                return true;
            else
                return false;
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
                string hoten = txtHoTen.Text.Trim();
                string gioitinh;
                if (rbtnNam.Checked)
                    gioitinh = rbtnNam.Text.Trim();
                else gioitinh = rbtnNu.Text.Trim();
                string ngaysinh = dtpkNgaySinh.Value.ToString("MM/dd/yyyy");

                int malop = (cbLop.SelectedItem as Lop).MaLop;
                string ngayvaohoc = dtpkNgayVaoHoc.Value.ToString("MM/dd/yyyy");
                string diachi = txtDiaChi.Text.Trim();
                string tencha = txtHoTenCha.Text.Trim();
                string sdtcha = txtSDTCha.Text.Trim();
                string tenme = txtHoTenMe.Text.Trim();
                string sdtme = txtSDTMe.Text.Trim();
                SuaHocSinh(mahs, hoten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
                this.Dispose();
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.Text = FormatProperCase(txtHoTen.Text);
        }

        private void txtHoTenCha_Validated(object sender, EventArgs e)
        {
            txtHoTenCha.Text = FormatProperCase(txtHoTenCha.Text);
        }

        private void txtHoTenMe_Validated(object sender, EventArgs e)
        {
            txtHoTenMe.Text = FormatProperCase(txtHoTenMe.Text);
        }

        #endregion

    }
}
