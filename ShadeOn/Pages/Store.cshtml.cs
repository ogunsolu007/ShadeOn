using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShadeOn.Models;

namespace ShadeOn.Pages
{

   
    public class StoreModel : PageModel
    {


        public IList<Product> Product { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Brands { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Brand { get; set; }

        private AppDataContext _db;

        public StoreModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

            // using LINQ to get list of brandname in the database

            IQueryable<string> productQuery = from m in _db.Products
                                            orderby m.Brandname
                                            select m.Brandname;



            var product = from m in _db.Products
                          select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                product = product.Where(s => s.Description.Contains(SearchString) || s.Productname.Contains(SearchString));

            }
            if (!string.IsNullOrEmpty(Brand))
            {
                product = product.Where(x => x.Brandname == Brand);

            }

            Brands = new SelectList( productQuery.Distinct().ToList());
            Product = product.ToList();
        }
    }
}

