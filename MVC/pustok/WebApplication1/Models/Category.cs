using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(16)]
        public string Name { get; set; }

    }
}
