using System.ComponentModel.DataAnnotations;

namespace JZTea.Models
{
    public class MLoginModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Vui lòng nhập username")]

        public string? Username { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(100)]
        public string? PasswordHash { get; set; }
    }
}
