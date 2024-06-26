using mgmtsys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace mgmtsys.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepo.GetCategories();
            return View(categories);
        }
        public IActionResult Edit(int? id)
        {
            var category = CategoriesRepo.GetCategoryById(id.HasValue?id.Value:0);
           return View(category);

        }
        public IActionResult Edit(Category category)
        {
        }   
    }
}
