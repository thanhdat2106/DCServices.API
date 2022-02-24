using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class QuanHuyen
    {
        [Key]
        public int MaQH { get; set; }

        [Display(Name = "Tên Quận/Huyện")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenQH { get; set; }

        [Display(Name = "Mã Tỉnh/Thành")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaTinh { get; set; }
    }
}
