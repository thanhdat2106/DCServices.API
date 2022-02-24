using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class DiaChi
    {
        [Key]
        public int MaPX { get; set; }

        [Display(Name = "Tên Phường/Xã")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenPX { get; set; }

        public int MaQH { get; set; }

        [Display(Name = "Tên Quận/Huyện")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenQH { get; set; }

        public int MaTinh { get; set; }

        [Display(Name = "Tên Tỉnh/Thành")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenTinh { get; set; }


    }
}
