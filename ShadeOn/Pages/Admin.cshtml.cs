using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShadeOn.Models;

namespace ShadeOn.Pages
{
    public class AdminModel : PageModel
    {
  public List<Product> products { get; set; }

        private AppDataContext _db;
      
        public AdminModel(AppDataContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            products = _db.Products.ToList();
        }

    }
}
