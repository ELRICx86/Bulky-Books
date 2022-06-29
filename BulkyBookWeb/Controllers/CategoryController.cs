using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDBcontext _db;

        public CategoryController(AppDBcontext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category>  objCategoryList = _db.Categories;
            return View();
        }
    }
}
