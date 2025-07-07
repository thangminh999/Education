using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Tên sách không được để trống.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên sách phải tối thiểu 2 đến tối đa 100 ký tự.")]
        public string Title { get; set; }
       [Required(ErrorMessage = "Số trang không được để trống")]
        public int PageCount { get; set; }
        [Required(ErrorMessage = "Ngày không thể để trống")]
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "Mô tả không thể để trống")]
        [StringLength(500, MinimumLength = 2, ErrorMessage = "Mô tả phải tối thiểu 2 đến 500 ký tự")]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(1, 6000, ErrorMessage = "Nhập giá trị trong khoảng 1 đến 6000")]
        public double Price { get; set; }
        public int StockCount { get; set; } = 100;
        public int SellCount { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public Category Category  { get; set;}
        public Author Author  { get; set;}
    }
}
