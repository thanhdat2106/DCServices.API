using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class ChiTietHDDATA
    {
        public int MaTho { get; set; }
        [Key]
        public int MaDV { get; set; }
        public string TenDV { get; set; }
        public string TenTho { get; set; }
        public string Anh { get; set; }
        public string SDT { get; set; }
        public double ThanhTien { get; set; }

        public DateTime HanBaoHanh { get; set; }
    }
}
