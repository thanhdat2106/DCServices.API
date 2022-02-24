using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class GoiThoKhachHang
    {
        [Key]
        public int MaGT { get; set; }

        public int MaKH { get; set; }

        public DateTime NgayGoi { get; set; }

        public string GhiChu { get; set; }

        public int TrangThai { get; set; }

        public string TenKH { get; set; }

        public string SDT { get; set; }
    }
}
