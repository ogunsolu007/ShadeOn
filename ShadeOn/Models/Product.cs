namespace ShadeOn.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public string Description { get; set; }
       
        public string Brandname { get; set; }

        public string Image { get; set; }   
        public int Price { get; set; }
    }
}
