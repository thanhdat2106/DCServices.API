using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class PhuongXa
    {
        [Key]
        public int MaPX { get; set; }

        [Display(Name = "Tên Phường/Xã")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenPX { get; set; }

        [Display(Name = "Mã Quận/Huyện")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaQH { get; set; }
    }
}
