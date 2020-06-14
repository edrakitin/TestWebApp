using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class CreateViewModel
    {
        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Год выпуска")]
        public int ReleaseYear { get; set; }

        [Required]
        [Display(Name = "Режиссер")]
        public string Director { get; set; }
                
        public IFormFile Poster { get; set; }

        public int FilmId { get; set; }
    }
}
