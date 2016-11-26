using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetMvcMinSample.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "ログインID")]
        //[EmailAddress]
        public string LoginId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード")]
        public string Password { get; set; }
    }
}
