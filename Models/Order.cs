using System.ComponentModel.DataAnnotations;

namespace WebBanDoAn.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; } // Ví dụ: Đã giao, Chưa giao [cite: 59]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}