using System.ComponentModel.DataAnnotations;

namespace AnNhanhOnline.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public ICollection<ComboDetail> ComboDetails { get; set; } = new List<ComboDetail>();
    }
}
