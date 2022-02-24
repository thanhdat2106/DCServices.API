using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class GoiTho_TT
    {
        public int MaGT { get; set; }

        public int MaKH { get; set; }
        [Key]
        public int MaDV { get; set; }

        public DateTime NgayGoi { get; set; }

        public string SDT { get; set; }
        public string GhiChu { get; set; }

        public string TenKH { get; set; }

        public string SoNha { get; set; }

        public int MaPX { get; set; }

        public string TenDV { get; set; }

        public int TrangThai { get; set; }

    }
}
