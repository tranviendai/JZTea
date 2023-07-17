using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JZTea.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        [MaxLength(100)]
        public string? name { get; set; }
        public string? image { get; set; }
        [Range(1, 100)]
        public int? discount { get; set; }
        [Range(0.1,50)]
        public double? price { get; set; }
        [MaxLength(1000)]
        public string? description { get; set; }
        public DateTime? postDate { get; set; }
        public bool? isPublish { get; set; }

        [ForeignKey("id")]
        public string? categoryID { get; set; }
        public Category? category { get; set; }
        public List<Voucher>? vouchers { get; set; } = new List<Voucher>();
    }
}
