using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            //örnek müşteri oluşturma
            var customer = new Customer
            {
                Id=1,
                FirstName= "İrem",
                LastName="Yakıncan",
                Email="iremyakincan@gmail.com"
            };

            //örnek siparişler oluşturma
            var orders = new List<Order>()
            {
                new Order{OrderId =1, ProductName="Telefon", Price=90000, Quantity = 5},
                new Order{OrderId =2, ProductName="Laptop", Price=150000, Quantity = 9},
                new Order{OrderId =3, ProductName="Televizyon", Price=170000, Quantity = 6},
            };

            //CustomerOrderViewModel oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            //viewa ViewModel ekleme
            return View(viewModel);


        }
    }
}
