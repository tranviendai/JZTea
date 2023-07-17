using System.ComponentModel.DataAnnotations;

namespace JZTea.Models
{
    public class Category
    {
        [Key]
        [MaxLength(20)]
        public string? id { get; set; }
        [MaxLength(25)]
        public string? name { get; set; }
        public string? icon { get; set; }
        public List<Product>? products { get; set; } = new List<Product>();
    }
}
