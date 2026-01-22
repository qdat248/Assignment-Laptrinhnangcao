using System.ComponentModel.DataAnnotations;

namespace AnNhanhOnline.Models
{
    public class Combo
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; } = string.Empty;
        public decimal OriginalPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal DiscountPercent => OriginalPrice > 0 ? (OriginalPrice - DiscountPrice) / OriginalPrice * 100 : 0;
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<ComboDetail> ComboDetails { get; set; } = new List<ComboDetail>();
    }
}
