using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;
namespace BUS_QLNT
{
    public class HocSinhBUS
    {
        private static HocSinhBUS instance;

        public static HocSinhBUS Instance
        {
            get { if (instance == null) instance = new HocSinhBUS(); return HocSinhBUS.instance; }
            private set { HocSinhBUS.instance = value; }
        }



        public List<HocSinh> GetHocSinhByMaLop(int malop)
        {
            return HocSinhDAL.Instance.GetHocSinhByMaLop(malop);
        }

        public bool ThemHocSinh(string ten, string gioitinh, DateTime ngaysinh, int malop, DateTime ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            bool kq = HocSinhDAL.Instance.ThemHocSinh(ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            return kq;
        }
    }
}
