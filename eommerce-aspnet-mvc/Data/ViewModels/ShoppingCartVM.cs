using eTickets.Data.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public ShoppingCartService ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
