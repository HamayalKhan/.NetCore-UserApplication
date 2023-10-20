using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {

            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Users users)
        {
            if (ModelState.IsValid)
            {
                Users obj = new Users()
                {
                    Name = users.Name,
                    Email = users.Email,
                    Password = users.Password,
                    PhoneNumber = users.PhoneNumber,
                    Status = users.Status,
                };
                this._context.TBLusers.Add(obj);
                this._context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}