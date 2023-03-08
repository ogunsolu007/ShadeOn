using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShadeOn.Models;

namespace ShadeOn.Pages.admin
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ShadeOn.Models.AppDataContext _context;

        public IndexModel(ShadeOn.Models.AppDataContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
