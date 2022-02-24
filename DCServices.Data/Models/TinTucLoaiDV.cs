using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class TinTucLoaiDV
    {
        [Key]
        public int MaTT { get; set; }

        [Display(Name = "Mã Loại Dịch Vụ")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaLoaiDV { get; set; }

        [Display(Name = "Tiêu Đề")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TieuDe { get; set; }

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "NOT NULL")]
        public string MoTa { get; set; }

        [Display(Name = "Ngày Đăng")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayDang { get; set; }

        [Display(Name = "Tác Giả")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TacGia { get; set; }

        [Display(Name = "Hình Ảnh")]
        [Required(ErrorMessage = "NOT NULL")]
        public string HinhAnh { get; set; }

        [Display(Name = "Ten Loai DV")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenLoaiDV { get; set; }
    }
}
