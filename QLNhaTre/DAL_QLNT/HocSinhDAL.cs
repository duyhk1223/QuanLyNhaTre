using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class HocSinhDAL
    {
        private static HocSinhDAL instance;

        public static HocSinhDAL Instance
        {
            get { if (instance == null) instance = new HocSinhDAL(); return HocSinhDAL.instance; }
            private set { HocSinhDAL.instance = value; }
        }

        private HocSinhDAL() { }


        public List<HocSinh> GetHocSinhByMaLop(int malop)
        {
            List<HocSinh> list = new List<HocSinh>();
            string query = "SELECT * FROM HOCSINH WHERE MALOP=" + malop; /*ROW_NUMBER() OVER(ORDER BY HOTEN) AS STT,MAHS,HOTEN,GIOITINH,NGAYSINH,MALOP,NGAYVAOHOC,DIACHI,HOTENCHA,SDTCHA,HOTENME,SDTME*/
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                HocSinh hocSinh = new HocSinh(item);
                list.Add(hocSinh);
            }
            return list;
        }

        public bool ThemHocSinh(string ten,string gioitinh,DateTime ngaysinh,int malop,DateTime ngayvaohoc,string diachi,string tencha,string sdtcha,string tenme, string sdtme)
        {
            int kq = 0;
            string query = string.Format("INSERT INTO HOCSINH VALUES (N'{0}',N'{1}','{2}',{3},'{4}',N'{5}',N'{6}','{7}',N'{8}','{9}')", ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq>0;
        }
    }
}
