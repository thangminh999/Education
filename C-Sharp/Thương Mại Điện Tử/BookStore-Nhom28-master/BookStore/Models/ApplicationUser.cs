using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required(ErrorMessage ="Ad Alanı boş geçilemez.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Tối thiểu 2 - 30 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı boş geçilemez.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Tối thiểu 2 - 30 ký tự")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Thành phố không được để trống")]
        public string City { get; set; }
        [Required(ErrorMessage = "Huyện/Phường không được để trống.")]
        public string District { get; set; }
        [Required(ErrorMessage = "Mã bưu điện không được để trống")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Mã bưu điện không hợp lệ !")]
        public string PostCode { get; set; }
        [NotMapped]
        public string Role { get; set; }
    }
}
