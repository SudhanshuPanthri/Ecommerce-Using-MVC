using Ecommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory Category { get; set; }
    }
}
