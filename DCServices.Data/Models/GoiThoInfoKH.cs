using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class GoiThoInfoKH
    {
        [Key]
        public int MaGT { get; set; }
        [Required(ErrorMessage = "NOT NULL")]
        public int MaKH { get; set; }
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayGoi { get; set; }
        [Required(ErrorMessage = "NOT NULL")]
        public string GhiChu { get; set; }
        [Required(ErrorMessage = "NOT NULL")]
        public string TenKH { get; set; }
        [Required(ErrorMessage = "NOT NULL")]
        public string SoNha { get; set; }
        [Required(ErrorMessage = "NOT NULL")]
        public int MaPX { get; set; }

        public string TenPX { get; set; }

        public string TenQH { get; set; }

        public string TenTinh { get; set; }
    }
    
}
