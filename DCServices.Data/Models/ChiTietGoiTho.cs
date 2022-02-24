using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class ChiTietGoiTho
    {
        
        public int MaGT { get; set; }
        [Key]
        public int MaDV { get; set; }
    }
}
