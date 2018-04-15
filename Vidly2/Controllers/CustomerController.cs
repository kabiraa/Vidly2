using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModel;

namespace Vidly2.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        [Route("Customers/Index")]
        public ActionResult Index()
        {
            var customers = _context.Customer.Include(c => c.MembershipType).ToList();
            var viewModel = new GetCustomersViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            var customer = _context.Customer.Include(c=>c.MembershipType).SingleOrDefault(cust => cust.CustomerId == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}