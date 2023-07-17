using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JZTea.Models
{
    public class Voucher
    {
        [Key]
        [StringLength(10)]
        public string? id { get; set; }
        [StringLength(20)]
        public string? name { get; set; }
        public decimal? price { get; set; }
        [Range(0, 100)]
        public int? limit { get; set; }
        [StringLength(250)]
        public string? description { get; set; }

        [ForeignKey("id")]
        public int productID { get; set; }
        public Product? product { get; set; }
    }
}
