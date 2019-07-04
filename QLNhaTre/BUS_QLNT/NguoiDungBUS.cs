using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using System.Data;

namespace BUS_QLNT
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;

        public static NguoiDungBUS Instance
        {
            get { if (instance == null) instance = new NguoiDungBUS(); return NguoiDungBUS.instance; }
            private set { NguoiDungBUS.instance = value; }
        }

        //public List<NguoiDung> GetListUsers()
        //{
        //    return NguoiDungDAL.Instance.GetListUsers();
        //}
        
        public DataTable GetDSNguoiDung()
        {
            return NguoiDungDAL.Instance.GetDSNguoiDung();
        }
        public NguoiDung GetUsersById(int id)
        {
            return NguoiDungDAL.Instance.GetUsersById(id);
        }
        public bool ThemUsers(string taiKhoan, int maGV, string quyen)
        {
            bool kq = NguoiDungDAL.Instance.ThemUsers(taiKhoan, maGV, quyen);
            return kq;
        }
        public bool SuaUsers(int id, string taiKhoan, int maGV, string quyen)
        {
            bool kq = NguoiDungDAL.Instance.SuaUsers(id, taiKhoan, maGV, quyen);
            return kq;
        }
        public bool XoaUsers(int id)
        {
            bool kq = NguoiDungDAL.Instance.XoaUsers(id);
            return kq;
        }
        public bool Check(string taikhoan)
        {
            bool kq = NguoiDungDAL.Instance.Check(taikhoan);
            return kq;
        }

        public bool Login(string taikhoan, string matkhau)
        {
            return NguoiDungDAL.Instance.Login(taikhoan, matkhau);
        }
    }
}
