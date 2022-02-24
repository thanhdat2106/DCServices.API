using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class LoaiDV
    {
        [Key]
        public int MaLoaiDV { get; set; }

        [Display(Name = "Ten Loai DV")]
        [Required(ErrorMessage = "NOT NULL")]
        public string TenLoaiDV { get; set; }
    }
}
