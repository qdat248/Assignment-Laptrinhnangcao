using System.ComponentModel.DataAnnotations;

namespace WebBanDoAn.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int? ProductID { get; set; } // FK từ Product
        public int? ComboID { get; set; }   // FK từ Combo [cite: 57, 61]
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public virtual Order Order { get; set; }
    }
}