using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKH { get; set; }

        [Display(Name = "Tên Thợ")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenKH { get; set; }

        [Display(Name = "Mã Phường/Xã")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaPX { get; set; }

        [Display(Name = "Số Nhà")]
        [Required(ErrorMessage = "NOT NULL")]
        public string SoNha { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [Required(ErrorMessage = "NOT NULL")]
        public string SDT { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "NOT NULL")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "NOT NULL")]
        public string Password { get; set; }

        [Display(Name = "Điểm Tích Lũy")]
        [Required(ErrorMessage = "NOT NULL")]
        public int DiemTichLuy { get; set; }

        [Display(Name = "Điểm Đánh giá")]
        [Required(ErrorMessage = "NOT NULL")]
        public double DiemDanhGia { get; set; }

        [Display(Name = "Ảnh")]
        [Required(ErrorMessage = "NOT NULL")]
        public string Anh { get; set; }
    }
}
