using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DTO_QLNT
{
    public class Lop
    {
        public Lop(DataRow row)
        {
            this.MaLop = (int)row["MALOP"];
            this.TenLop = row["TENLOP"].ToString();
            this.MaKhoi = row["MAKHOI"].ToString();
            this.NamHoc = row["NAMHOC"].ToString();
        }
        public Lop(int malop,string tenlop,string khoilop,string namhoc)
        {
            this.MaLop = malop;
            this.TenLop = tenlop;
            this.MaKhoi = khoilop;
            this.NamHoc = namhoc;
        }

        private int maLop;

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        private string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        private string maKhoi;

        public string MaKhoi
        {
            get { return maKhoi; }
            set { maKhoi = value; }
        }


        private string namHoc;

        public string NamHoc
        {
            get { return namHoc; }
            set { namHoc = value; }
        }


    }
}
