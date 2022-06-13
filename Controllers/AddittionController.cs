using Microsoft.AspNetCore.Mvc;
using Lap1signalr.Models;

namespace Lap1signalr.Controllers
{
    public class AddittionController : Controller
    {
        EmployeeContext db;
        public AddittionController(EmployeeContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Employee.ToList());
        }
        public IActionResult add()
        {
            return View();
        }
    }
}
