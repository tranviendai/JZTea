using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZTea.Models
{
    public class User
    {
        [Key]
        [StringLength(256)]
        public string? Id { get; set; }
        [Required]
        [StringLength(72)]
        public string? UserName { get; set; }
        [StringLength(100)]
        [Required]
        public string? PasswordHash { get; set; }
        [StringLength(int.MaxValue)]
        public string? Image { get; set; }
        [StringLength(42)]
        public string? FullName { get; set; }

        [StringLength(256)]
        public string? Email { get; set; }
        [StringLength(10)]
        public string? PhoneNumber { get; set; }
        [StringLength(100)]
       
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateCreated { get; set; }

        [StringLength(20)]
        public string? Role { get; set; }

        public bool? IsActive { get; set; }
    }
}
