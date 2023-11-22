using System.ComponentModel.DataAnnotations;

namespace JZTea.Models
{
    public class MSignUpModel
    {
        [StringLength(100)]
        public string? UserName { get; set; }
        [StringLength(42)]
        public string? FullName { get; set; }

        [StringLength(100)]
        public string? Password { get; set; }
    }
}
