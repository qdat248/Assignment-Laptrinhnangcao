using System.ComponentModel.DataAnnotations;

namespace WebBanDoAn.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
