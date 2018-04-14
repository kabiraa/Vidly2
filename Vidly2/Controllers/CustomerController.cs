using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModel;

namespace Vidly2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("customers/Index")]
        public ActionResult Index()
        {
            var customers = GetCustomers();
            var viewModel = new GetCustomersViewModel
            {
                Customers = customers.ToList()
            };
            return View(viewModel);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> {
                    new Customer { Name = "Gaurav", CustomerId = 1 },
                    new Customer { Name = "Abhishek", CustomerId = 2 }
                };
        }

        public ActionResult CustomerDetail(int id)
        {
            var customer = GetCustomers().SingleOrDefault(cust => cust.CustomerId == id);
            if (customer == null)
                return HttpNotFound();

            return Content(customer.Name);
        }
    }
}