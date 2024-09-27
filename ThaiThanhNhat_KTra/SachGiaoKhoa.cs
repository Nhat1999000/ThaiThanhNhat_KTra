using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiThanhNhat_KTra
{
    public class SachGiaoKhoa : Sach
    {
        public string MonHoc { get; set; }
        public string TinhTrang { get; set; } 

        public SachGiaoKhoa(string tenSach, string tacGia, decimal giaBan, string monHoc, string tinhTrang)
            : base(tenSach, tacGia, giaBan)
        {
            MonHoc = monHoc;
            TinhTrang = tinhTrang;
            if (TinhTrang == "Cũ")
                GiaBan *= 0.8m; 
        }
    }

}
