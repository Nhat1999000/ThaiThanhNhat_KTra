using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiThanhNhat_KTra
{
    public class Sach
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public decimal GiaBan { get; set; }

        public Sach(string tenSach, string tacGia, decimal giaBan)
        {
            TenSach = tenSach;
            TacGia = tacGia;
            GiaBan = giaBan;
        }

    }
}
