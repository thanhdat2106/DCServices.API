using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCServices.Data.Models
{
    public class ThoSua
    {
        [Key]
        public int MaTho { get; set; }

        [Display(Name = "Tên Thợ")]

        public string TenTho { get; set; }

        [Display(Name = "Mã Phường/Xã")]
        
        public int MaPX { get; set; }

        [Display(Name = "Số Nhà")]
    
        public string SoNha { get; set; }

        [Display(Name = "Số Điện Thoại")]
 
        public string SDT { get; set; }

        [Display(Name = "Ngày Sinh")]
  
        public DateTime NgaySinh { get; set; }

        [Display(Name = "Ảnh")]

        public string Anh { get; set; }

        [Display(Name = "Email")]
  
        public string Email { get; set; }

        [Display(Name = "Điểm Đánh giá")]
   
        public double DiemDanhGia { get; set; }

        [Display(Name = "Số Tài Khoản")]

        public string SoTaiKhoan { get; set; }

        [Display(Name = "Số Dư")]
        
        public double SoDu { get; set; }

        [Display(Name = "Loại Thợ")]
       
        public int LoaiTho { get; set; }

        [Display(Name = "Active")]
        
        public int Active { get; set; }

        [Display(Name = "Password")]
     
        public string Password { get; set; }
    }
    public class ThoSuaData
    {
        [Key]
        public int MaTho { get; set; }
        public string TenTho { get; set; }
        public string DiaChi { get; set; }
        public double DiemDanhGia { get; set; }
    }
}
