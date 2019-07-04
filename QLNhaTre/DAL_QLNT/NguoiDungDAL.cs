using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class NguoiDungDAL
    {
        private static NguoiDungDAL instance;
        public static NguoiDungDAL Instance
        {
            get { if (instance == null) instance = new NguoiDungDAL(); return NguoiDungDAL.instance; }
            private set { NguoiDungDAL.instance = value; }
        }
        private NguoiDungDAL() { }

        //public List<NguoiDung> GetListUsers()
        //{
        //    List<NguoiDung> list = new List<NguoiDung>();
        //    string query = string.Format("SELECT * FROM NGUOIDUNG Where QUYEN = N'Giáo viên' OR QUYEN = N'Ban giám hiệu' ORDER BY QUYEN");
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        NguoiDung user = new NguoiDung(item);
        //        list.Add(user);
        //    }
        //    return list;
        //}
        
        public DataTable GetDSNguoiDung()
        {
            DataTable dt = new DataTable();
            string query = string.Empty;

            query += "SELECT ID, TAIKHOAN, NGUOIDUNG.MAGV, GIAOVIEN.HOTEN, QUYEN ";
            query += "FROM NGUOIDUNG, GIAOVIEN ";
            query += "WHERE NGUOIDUNG.MAGV=GIAOVIEN.MAGV and (QUYEN = N'Giáo viên' or QUYEN = N'Ban giám hiệu') ORDER BY QUYEN";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public NguoiDung GetUsersById(int id)
        {
            string query = string.Format("SELECT ID, TAIKHOAN, MAGV, QUYEN FROM NGUOIDUNG WHERE ID={0}", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            NguoiDung us = new NguoiDung(dt.Rows[0]);
            return us;
        }



        public bool ThemUsers(string taiKhoan, int maGV, string quyen)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO NGUOIDUNG(TAIKHOAN,MAGV,QUYEN) VALUES ('{0}','{1}',N'{2}')", taiKhoan, maGV, quyen);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool SuaUsers(int id, string taiKhoan, int maGV, string quyen)
        {
            int kq = 0;
            string query = string.Format("UPDATE NGUOIDUNG SET TAIKHOAN = '{0}', MAGV = '{1}', QUYEN = N'{2}' WHERE ID = {3}", taiKhoan, maGV, quyen, id);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool XoaUsers(int id)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM NGUOIDUNG WHERE ID={0}", id);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        
        public bool Check(string taikhoan)
        {
            int kq = 0;
            string query = string.Format("SELECT COUNT(ID) from NGUOIDUNG WHERE TAIKHOAN = '{0}'", taikhoan);
            kq = (int)DataProvider.Instance.ExecuteScalar(query);
            return kq > 0;
        }

        public bool Login(string taikhoan, string matkhau)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(matkhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = string.Format("SELECT * FROM NGUOIDUNG WHERE TAIKHOAN = '{0}' AND MATKHAU = '{1}'", taikhoan, hasPass);

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
