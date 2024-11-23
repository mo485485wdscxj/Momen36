using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Models
{
    public class MoviesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public List<DirectorModel>? Directors { get; set; }=new List<DirectorModel>();
        public List <CategoryMode>? categories   { get; set; } = new List<CategoryMode>();


    }
}
