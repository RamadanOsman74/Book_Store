using Book.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.ViewModel
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> CartsList { get; set; }
        public decimal Totalcarts { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
