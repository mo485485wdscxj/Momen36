using Moamen_0522036.Dtos.CategoryDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.MoveDto
{
    public class UpdateMoveDto
    {
         public int Id { get; set; }
        [Required]
        public string? Title { get; set; }=string .Empty;
        [Required]
        public DateTime ReleaseYear { get; set; }
        public ICollection<UpdateCategoryDto>? categories { get; set; } 
     }
}
