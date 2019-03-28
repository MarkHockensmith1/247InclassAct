using Activity7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity7.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            // Create a List of Customers
            customers.Add(new CustomerModel(0, "Mark", 23));
            customers.Add(new CustomerModel(1, "Duane", 22));
            customers.Add(new CustomerModel(2, "Josh", 19));
        }

        // GET: Display Main Customer Page
        [HttpGet]
        public ActionResult Index()
        {
            // Display Customer View and pass the List of Customers to the View
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);
            return View("Customer", tuple);
        }

        // POST: On Select of Customer Radio Button (Non AJAX Form with Partial View and Full Page Update)
        [HttpPost]
        public ActionResult OnSelectCustomer(string Customer)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(Customer)]);
            return View("Customer", tuple);
        }

        // POST: On Select of Customer Radio Button (AJAX Form with Partial View and Partial Page Update)
        [HttpPost]
        public PartialViewResult OnSelectCustomer2(string Customer)
        {
            return PartialView("_CustomerDetails", customers[Int32.Parse(Customer)]);
        }

        // POST: Get some data from this Controller method
        [HttpPost]
        public string GetMoreInfo(string Customer)
        {
            // Return some test data back to the Browser
            return "Hello this is some test data";
        }
    }
}