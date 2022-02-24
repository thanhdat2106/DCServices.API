using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class TinhThanh
    {
        [Key]
        public int MaTinh { get; set; }

        [Display(Name = "Tên Tỉnh/Thành")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenTinh { get; set; }

    }
}
