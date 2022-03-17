using System.ComponentModel.DataAnnotations;

namespace BasicWebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}
