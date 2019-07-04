using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;



namespace GUI_QLNT
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string ID_USER = string.Empty;


        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaikhoan.Text;
            string matKhau = txtMatkhau.Text;
            if (NguoiDungBUS.Instance.Login(taiKhoan,matKhau))
            {
                frmMain fm = new frmMain();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        
        
    }
}
