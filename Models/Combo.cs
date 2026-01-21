using System.ComponentModel.DataAnnotations;

namespace WebBanDoAn.Models
{
    public class Combo
    {
        [Key]
        public int ComboID { get; set; }
        [Required]
        public string ComboName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
