using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using Xunit.Sdk;

namespace ShadeOn.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        [ForeignKey(nameof(ProductID))] 
        public Product Product { get; set; }
        [Range(1,100, ErrorMessage = "Please select a count between 1 and 100")]
        public int Count { get; set; }

        public string AppUserID { get; set; }
        [ForeignKey(nameof(AppUserID))]
        public AppUser AppUser { get; set; }
    }
}
