namespace AnNhanhOnline.Models
{
    public class ComboDetail
    {
        public int ComboId { get; set; }
        public Combo Combo { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; } = 1;
    }
}
