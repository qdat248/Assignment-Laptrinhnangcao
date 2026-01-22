namespace AnNhanhOnline.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty; // Link với IdentityUser
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Chưa giao"; // Chưa giao, Đang giao, Đã giao
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
