using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class DanhGia
    {
        [Key]
        public int MaDG { get; set; }

        [Display(Name = "Mã Hóa Đơn")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaHD { get; set; }

        [Display(Name = "Điểm Đánh Giá KH")]
        [Required(ErrorMessage = "NOT NULL")]
        public double DiemDGKhachHang { get; set; }

        [Display(Name = "Điểm Đánh Giá Tho")]
        [Required(ErrorMessage = "NOT NULL")]
        public double DiemDGTho { get; set; }

        [Display(Name = "Nhận Xét Khách Hàng")]
        public string NhanXetKhachHang { get; set; }

        [Display(Name = "Nhận Xét Thợ")]
        public string NhanXetTho { get; set; }
    }
}
