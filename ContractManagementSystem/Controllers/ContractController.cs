using ContractManagementSystem.Data;
using ContractManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ContractManagementSystem.Controllers
{
    public class ContractController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContractController(ApplicationDbContext Db, ILogger<HomeController> logger) //dependency injection
        {
            _context = Db;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateContract()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContract(Contract obj)
        {
            if (!ModelState.IsValid)
            {
                // model validation failed, return the view with validation errors
                return View(obj);
            }

            // Model validation passed, add the contract to the database and save changes
            _context.Contracts.Add(obj);
            _context.SaveChanges();

            // Redirect the user to a success page or another action
            return RedirectToAction("CreateContract");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
