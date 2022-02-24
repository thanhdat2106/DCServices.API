using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class DichVu
    {
        [Key]
        public int MaDV { get; set; }

        [Display(Name = "Tên Dịch Vụ")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenDV { get; set; }

        [Display(Name = "Mã Loại DV")]
        [Required(ErrorMessage = "NOT NULL")]
        public int MaLoaiDV { get; set; }
    }
}
