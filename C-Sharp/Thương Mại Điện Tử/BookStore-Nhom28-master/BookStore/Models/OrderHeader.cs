using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace BookStore.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        [Required(ErrorMessage = "Tên người dùng không thể để trống.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Tối thiểu 2 - 30 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Họ của người dùng không được để trống.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Tối thiểu 2 - 30 ký tự")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại không hợp lệ !")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Thành phố không được để trống")]
        public string City { get; set; }
        [Required(ErrorMessage = "Huyện/Phường không được để trống.")]
        public string District { get; set; }
        [Required(ErrorMessage = "Mã bưu điện không được để trống")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Mã bưu điện không hợp lệ !")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Tên chủ thẻ không được để trống.")]
        public string CartName { get; set; }
        [Required(ErrorMessage = "Số thẻ không được để trống.")]
        public string CartNumber { get; set; }
        [Required(ErrorMessage = "Tháng không được để trống.")]
        [Range(1,12,ErrorMessage = "Nhập giá trị từ 1 đến 12.")]
        public string ExpirationMonth { get; set; }
        [Required(ErrorMessage = "Năm không thể để trống.")]
        [Range(22, 99, ErrorMessage = "Nhập giá trị có 2 chữ số lớn hơn 22.")]
        public string ExpirationYear { get; set; }
        [Required(ErrorMessage = "Cvc không được để trống.")]
        [Range(100, 999, ErrorMessage = "Nhập giá trị có 3 chữ số.")]
        public string Cvc { get; set; }
    }
}
