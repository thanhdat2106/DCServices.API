using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DCServices.Data.Models
{
    public class Tho_DichVu
    {

        [Key]
        public int MaTho  { get; set; }

        public int MaDV { get; set; }

    }
}
