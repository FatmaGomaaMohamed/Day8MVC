using System.ComponentModel.DataAnnotations.Schema;

namespace Day8MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int price { get; set; }

        [ForeignKey("Owner")]
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}
