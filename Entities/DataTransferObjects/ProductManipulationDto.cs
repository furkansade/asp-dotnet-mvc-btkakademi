using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public record ProductManipulationDto
    {
        [Required(ErrorMessage = "Ürün İsmi Gerekli!")]
        public String? ProductName { get; set; } // default : null

        [Required(ErrorMessage = "Fiyat Gerekli!")]
        public Decimal Price { get; set; }  // default: 0

        public String? ImageUrl { get; set; }

        public String? Description { get; set; }

        public int? CategoryId { get; set; }
    }
}
