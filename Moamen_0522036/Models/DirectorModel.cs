using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Models
{
    public class DirectorModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [Required,Phone]
        public string? Contact { get; set; }
        [Required,EmailAddress]
        public string? Email { get; set; }
        public ICollection<MoviesModel>? Movies { get; set; } = new List<MoviesModel>();
        public NationalityModel? Nationality { get; set; } 
    }
}
