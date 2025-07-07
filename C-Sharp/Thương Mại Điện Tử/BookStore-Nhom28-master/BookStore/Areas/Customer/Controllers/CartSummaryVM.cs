using BookStore.Models;
using System.Collections.Generic;

namespace BookStore.Areas.Customer.Controllers
{
    public class CartSummaryVM
    {
        public List<ShoppingCart> CartItems { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
