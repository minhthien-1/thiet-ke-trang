using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace thiet_ke_trang.Models.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Tên đăng nhập không được để trống.")]
        [Display(Name ="Tên đăng nhập")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [DataType(DataType.Password)]
        [Display(Name ="Mật khẩu")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage ="Mật khẩu không trùng khớp.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name ="Họ tên")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name ="Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string CustomerPhone { get; set; }
        [Required(ErrorMessage = "Email không được để trống.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
        [Required]
        [Display(Name = "Địa chỉ")]
        public string CustomerAddress { get; set; }


    }
}