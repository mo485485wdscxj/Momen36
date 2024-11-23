using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Models
{
    public class CategoryMode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public ICollection<MoviesModel>? Movies { get; set; }=new List<MoviesModel>();



    }
}
