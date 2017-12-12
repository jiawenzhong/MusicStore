using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web3.Models;

namespace Web3.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}