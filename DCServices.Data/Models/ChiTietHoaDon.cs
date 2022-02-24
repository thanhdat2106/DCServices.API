using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        public int MaHD { get; set; }
        
        [Display(Name = "Mã Dịch Vụ")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaDV { get; set; }

        [Display(Name = "Mã Thợ")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaTho { get; set; }

        [Display(Name = "Thành Tiền")]
        [Required(ErrorMessage = "NOT NULL")]
        public double ThanhTien { get; set; }

        [Display(Name = "Hạn bảo hành")]
        public DateTime HanBaoHanh { get; set; }
    }
}
