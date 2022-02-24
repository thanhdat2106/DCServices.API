using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class HoaDonInfo
    {
        [Key]
        public int MaDV { get; set; }

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

        [Display(Name = "Tổng Tiền")]
        [Required(ErrorMessage = "NOT NULL")]
        public double TongTien { get; set; }

        public string TenKH { get; set; }

        public int MaPX { get; set; }

        public string SoNha { get; set; }

        public string TenDV { get; set; }

        public string SDT { get; set; }

        public double ThanhTien { get; set; }

        public DateTime HanBaoHanh { get; set; }

    
    }
}
