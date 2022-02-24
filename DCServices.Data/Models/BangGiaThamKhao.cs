using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class BangGiaThamKhao
    {
        [Key]
        public int MaGiaThamKhao { get; set; }

        [Display(Name = "Mã Dịch Vụ")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaDV { get; set; }

        [Display(Name = "Mô Tả")]
        [Required(ErrorMessage = "NOT NULL")]
        public string MoTa { get; set; }

        [Display(Name = "Đơn Vị")]
        [Required(ErrorMessage = "NOT NULL")]
        public string DonVi { get; set; }

        [Display(Name = "Giá Cao Nhất")]
        [Required(ErrorMessage = "NOT NULL")]
        public double GiaCaoNhat { get; set; }

        [Display(Name = "Giá Thấp Nhất")]
        [Required(ErrorMessage = "NOT NULL")]
        public double GiaThapNhat { get; set; }
    }
}
