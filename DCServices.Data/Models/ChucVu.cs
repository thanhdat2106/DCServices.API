using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class ChucVu
    {
        [Key]
        public int MaCV { get; set; }

        [Display(Name = "Tên Chức Vụ")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenCV { get; set; }

    }
}
