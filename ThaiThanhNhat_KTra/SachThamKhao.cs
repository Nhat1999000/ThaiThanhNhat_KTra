using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiThanhNhat_KTra
{
    public class SachThamKhao : Sach
    {
        public string LinhVuc { get; set; }
        public string NhaXuatBan { get; set; }

        public SachThamKhao(string tenSach, string tacGia, decimal giaBan, string linhVuc, string nhaXuatBan)
            : base(tenSach, tacGia, giaBan)
        {
            LinhVuc = linhVuc;
            NhaXuatBan = nhaXuatBan;
        }

    }
}
