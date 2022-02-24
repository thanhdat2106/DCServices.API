using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class HopDong
    {
        [Key]
        public int MaHopDong { get; set; }

        [Display(Name = "Mã Thợ")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaTho { get; set; }

        [Display(Name = "Mã Nhân Viên")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaNV { get; set; }

        [Display(Name = "Ngày Kí Kết")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayKiKet { get; set; }

        [Display(Name = "Ngày Bắt Đầu")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayBD { get; set; }

        [Display(Name = "Ngày Kết Thúc")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayKT { get; set; }
    }
}
