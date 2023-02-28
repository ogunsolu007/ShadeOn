using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShadeOn.Models;

namespace ShadeOn.Pages
{
    public class StoreModel : PageModel
    {


        public List<Product> products { get; set; }

        private AppDataContext _db;

        public StoreModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            products = _db.Products.ToList();
        }
    }
}
