using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace BookStore.Controllers
{
    public class PaymentController : Controller
    {
        private readonly BookStoreDbContext _context; // Sử dụng DbContext thay vì IUnitOfWork

        public PaymentController(BookStoreDbContext context) // Sử dụng ApplicationDbContext thay vì IUnitOfWork
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Summary()
        {
            // Lấy thông tin giỏ hàng từ cơ sở dữ liệu hoặc bất kỳ nguồn dữ liệu nào phù hợp.
            var shoppingCart = _context.ShoppingCarts; // Thay yourShoppingCartData bằng dữ liệu thực tế.

            // Tạo một đối tượng ShoppingCartVM và thiết lập các thuộc tính của nó.
            var viewModel = new ShoppingCartVM
            {
                ListCart = shoppingCart, // Điền dữ liệu giỏ hàng vào đây
                OrderHeader = new OrderHeader() // Khởi tạo OrderHeader theo nhu cầu của bạn
            };

            // Trả về trang Razor "Summary" và truyền ViewModel đã tạo vào trang.
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompletePayment(OrderHeader orderHeader)
        {
            // Xử lý thanh toán ở đây, thêm đơn hàng và sản phẩm đã mua vào cơ sở dữ liệu, gửi email xác nhận, v.v.

            // Ví dụ:
            _context.OrderHeaders.Add(orderHeader); // Thêm orderHeader vào cơ sở dữ liệu
            await _context.SaveChangesAsync(); // Lưu thay đổi vào cơ sở dữ liệu

            // Sau khi xử lý xong, bạn có thể chuyển hướng người dùng đến trang hoàn thành đơn hàng.
            return RedirectToAction("OrderCompleted");
        }

        public IActionResult OrderCompleted()
        {
            // Trang thông báo đơn hàng đã được tạo thành công.
            return View();
        }
        public async Task<IActionResult> ProcessOrder(ShoppingCartVM viewModel)
        {
            if (ModelState.IsValid)
            {
                // Xử lý thanh toán ở đây, thêm thông tin đặt hàng vào cơ sở dữ liệu, gửi email xác nhận, v.v.

                // Ví dụ:
                // Lấy danh sách sản phẩm từ giỏ hàng
                var cartItems = viewModel.ListCart;

                // Tính tổng tiền từ giỏ hàng
                decimal totalAmount = (decimal)cartItems.Sum(item => item.Count * (double)item.Book.Price);

                // Tạo OrderHeader từ dữ liệu trong viewModel
                var orderHeader = viewModel.OrderHeader;
                orderHeader.OrderTotal = (double)totalAmount;

                // Thêm thông tin đặt hàng vào cơ sở dữ liệu
                _context.OrderHeaders.Add(orderHeader);
                await _context.SaveChangesAsync();

                // Xử lý các bước thanh toán khác nếu cần

                // Sau khi xử lý xong, bạn có thể chuyển hướng người dùng đến trang hoàn thành đặt hàng.
                return RedirectToAction("OrderCompleted");
            }

            // Nếu ModelState không hợp lệ, hiển thị trang xem trước với thông báo lỗi.
            return View("Summary", viewModel);
        }
    }
}
