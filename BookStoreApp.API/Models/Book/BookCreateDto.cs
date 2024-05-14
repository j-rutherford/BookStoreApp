using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book
{
    public class BookCreateDto
    {
        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1800, 2100)]
        public int Year { get; set; }

        [Required]
        [StringLength(50)]
        public string Isbn { get; set; }


        [StringLength(250)]
        [Required]
        public string Summary { get; set; }

        [StringLength(50)]
        public string? Image { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }

    }
}
