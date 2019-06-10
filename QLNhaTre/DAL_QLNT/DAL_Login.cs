using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
 public class DAL_Login
    {
        private static DAL_Login instance;

        public static DAL_Login Instance
        {
            get { if (instance == null) instance = new DAL_Login(); return instance; }
            private set { instance = value; }
        }
        private DAL_Login()
        {

        }
        public bool Login(string useName,string passWord)
        {
            string query = "select* from dbo.NGUOIDUNG where TAIKHOAN=N'"+useName+"'and MATKHAU=N'"+passWord+"'";//tai khoan mat khau phan biec hoa thuong,muon ko phan biec thi them like vao nha
            DataTable result = DataProvider.Instance.ExecuteQuery(query);


            return result.Rows.Count>0;
        }
      
    }
}
