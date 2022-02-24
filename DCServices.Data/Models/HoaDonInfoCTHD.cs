using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class HoaDonInfoCTHD
    {
        [Key]
        public int MaDV { get; set; }

        public string TenKH { get; set; }

        public string TenTho { get; set; }


        public string TenDV { get; set; }

        public DateTime HanBaoHanh { get; set; }

        public double ThanhTien { get; set; }
    }
}
