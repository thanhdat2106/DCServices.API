using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class Chartmobile
    {
        [Key]
        public string Ngay { get; set; }

        public int SLHoaDon { get; set; }
    }
}
