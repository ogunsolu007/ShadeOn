using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShadeOn.Models;

namespace ShadeOn.Pages
{
    public class ProductModel : PageModel
    {

        public Product? product { get; set; }

        private AppDataContext _db;

        public ProductModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            product = _db.Products.SingleOrDefault(n => n.Id == id);
        }
    }
}
