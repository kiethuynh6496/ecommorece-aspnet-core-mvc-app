using eTickets.Data.Cart;
using eTickets.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBooking.Data.Services;

namespace eTickets.Controllers
{
    public class OrdersControllers : Controller
    {
        private readonly IMoviesService _moviesService;
        private readonly ShoppingCartService _shoppingCart;
        public OrdersControllers(IMoviesService moviesService, ShoppingCartService shoppingCart)
        {
            _moviesService = moviesService;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }
    }
}
