using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }

        [Display(Name = "Mã Khách Hàng")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaKH { get; set; }

        [Display(Name = "Ngày Lập")]
        [Required(ErrorMessage = "NOT NULL")]
        public DateTime NgayLap { get; set; }

        [Display(Name = "Chiết Khấu")]
        [Required(ErrorMessage = "NOT NULL")]
        public double ChietKhau { get; set; }

        [Display(Name = "Thuế VAT")]
        [Required(ErrorMessage = "NOT NULL")]
        public double ThueVAT { get; set; }

        [Display(Name = "Phí Di Chuyển")]
        [Required(ErrorMessage = "NOT NULL")]
        public double PhiDiChuyen { get; set; }

        [Display(Name = "Phí Di Chuyển")]
        [Required(ErrorMessage = "NOT NULL")]
        public double PhiDichVu { get; set; }

        [Display(Name = "Tổng Tiền")]
        [Required(ErrorMessage = "NOT NULL")]
        public double TongTien { get; set; }

        [Display(Name = "Trạng Thái")]
        [Required(ErrorMessage = "NOT NULL")]
        public int TrangThai { get; set; }
    }
       
}
