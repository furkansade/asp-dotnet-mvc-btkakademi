using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage ="Kategori İsmi Gerekli!")]
        [MinLength(5, ErrorMessage = "Kategori Adı en az 5 karakterden oluşmalıdır.")]
        public String? CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
