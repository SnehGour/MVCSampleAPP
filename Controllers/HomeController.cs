using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using MVCSampleAPP.Data;
using MVCSampleAPP.Models;
using MVCSampleAPP.ViewModel;
using System.Diagnostics;

namespace MVCSampleAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            string connectionStatus;
            List<Customer> data = null;

            try
            {
                // Attempt to fetch data. If successful, connection is established.
                data = _context.Customers.ToList();
                connectionStatus = "Connected";
            }
            catch (Exception ex)
            {
                connectionStatus = $"Error connecting to database: {ex.Message}";
            }

            CustomerViewModel customerViewModel = new CustomerViewModel
            {
                Customers = data,
                Connection = connectionStatus
            };
            return View(customerViewModel);
        }

    }
}
