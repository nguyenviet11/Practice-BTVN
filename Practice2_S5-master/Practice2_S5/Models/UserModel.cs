using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice2_S5.Models
{
    public class UserModel
    {
        [Required]
        public int Idd { get; set; }


        [Required(ErrorMessage = "Bạn phải nhập tên")]
        [StringLength(30, MinimumLength = 6)]
        [DisplayName("Họ và tên")]

        public string Name { set; get; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Bạn phải nhập password")]
        [StringLength(30, MinimumLength = 5)]
        [DisplayName("Mật khẩu")]
        public string Password { set; get; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        [DisplayName("Re Mật khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập password")]
        public string ConfirmPassword { set; get; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Bạn phải nhập email")]
        [EmailAddress]
        public string Email { set; get; }

    }
}