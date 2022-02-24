

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class NhanVien
    {
        [Key]
        public int MaNV { get; set; }

        [Display(Name = "Mã Chức Vụ")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaCV { get; set; }

        [Display(Name = "Tên Nhân Viên")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenNV { get; set; }

        [Display(Name = "Chứng Minh Nhân Dân")]
        [Required(ErrorMessage = "NOT NULL")]
        public string CMND { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [Required(ErrorMessage = "NOT NULL")]
        public string SDT { get; set; }

        [Display(Name = "Mã Phường/Xã")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaPX { get; set; }

        [Display(Name = "Số Nhà")]
        [Required(ErrorMessage = "NOT NULL")]
        public string SoNha { get; set; }

        [Display(Name = "Ảnh")]
        [Required(ErrorMessage = "NOT NULL")]
        public string Anh { get; set; }

        [Display(Name = "Ngày Sinh")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgaySinh { get; set; }

        [Display(Name = "Giới Tính")]
        [Required(ErrorMessage = "NOT NULL")]
        public string GioiTinh { get; set; }

        [Display(Name = "Ngày Vào Làm")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayVL { get; set; }

        [Display(Name = "Lương")]
        [Required(ErrorMessage = "NOT NULL")]
        public int Luong { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "NOT NULL")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "NOT NULL")]
        public string Password { get; set; }
    }
}
