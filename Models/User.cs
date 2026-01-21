using System.ComponentModel.DataAnnotations;

namespace WebBanDoAn.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        [StringLength(100)]
        public string FullName { get; set; } // Thông tin 1

        [Required]
        [EmailAddress]
        public string Email { get; set; } // Thông tin 2

        [Required]
        [MinLength(6)]
        public string Pass { get; set; } // Thông tin 3

        public string Address { get; set; } // Thông tin 4

        public string NumberPhone { get; set; } // Thông tin 5

        public string Role { get; set; } // Thông tin 6 (Admin/Customer) [cite: 50, 40]

        public string? GoogleID { get; set; } // Phục vụ đăng nhập Google [cite: 41]
    }
}