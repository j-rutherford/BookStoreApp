using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ExceptionServices;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Data
{
    [Index(nameof(Isbn), Name = "UQ__Books__447D36EAFBEA181D", IsUnique = true)]
    public partial class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        public int? Year { get; set; }
        [Column("ISBN")]
        [StringLength(50)]
        public string Isbn { get; set; } = null!;
        [StringLength(250)]
        public string? Summary { get; set; }
        [StringLength(50)]
        public string? Image { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        public int? AuthorId { get; set; }



        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Books")]
        public virtual Author? Author { get; set; }
    }
}
