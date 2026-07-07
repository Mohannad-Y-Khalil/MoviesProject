using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MoviesProject.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped] // هذه السمة مهمة لتجاهل الخاصية عند حفظها في قاعدة البيانات
        [Display(Name = "Movie Poster")]
        public IFormFile ImageFile { get; set; }

        [Range(1, 10)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
    }
}