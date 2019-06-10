using DAL_QLNT;
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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string useName = txtTaikhoan.Text;
            string passWord = txtMatkhau.Text;
            if (Login(useName,passWord))
            {
                frmMain fm = new frmMain();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tai khoan hoac mat khau sai xin nhap lai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        bool Login(string useName,string passWord)
        {
            return DAL_Login.Instance.Login(useName, passWord);
        }
    }
}
