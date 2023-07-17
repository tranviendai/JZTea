using System.ComponentModel.DataAnnotations;

namespace JZTea.Models
{
    public class Topping
    {
        [Key]
        public int? id { get; set; }
        public string? name { get; set; }
        public string? image { get; set; }
        [Range(0,5)]
        public double? price { get; set; }
    }
}
