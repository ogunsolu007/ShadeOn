using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShadeOn.Models;

namespace ShadeOn.Pages
{
    public class AddProductModel : PageModel
    {
        public readonly AppDataContext _db;

        [BindProperty]
        public Product products { get; set; }

        public AddProductModel(AppDataContext db)
        {
            _db = db;
        
        }

            public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            var product = new Product()
            {
                Productname = products.Productname,
                Brandname = products.Brandname,
                Price = products.Price,
                Description = products.Description,
                Image = products.Image,
            };
            _db.Products.Add(products);
            _db.SaveChanges();
            return Redirect("Admin");
        }
    }
 }
