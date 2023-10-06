using eShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ViewModels.Sales
{
    public class OrderVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetailVm> OrderDetails { get; set; } = new List<OrderDetailVm>();
    }
}