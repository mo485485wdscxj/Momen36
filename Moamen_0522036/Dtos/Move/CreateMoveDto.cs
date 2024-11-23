using Moamen_0522036.Dtos.CategoryDto;
using Moamen_0522036.Dtos.DirectoryDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.MoveDto
{
    public class CreateMoveDto
    {

        [Required]
        public string? Title { get; set; }=string.Empty;
        public DateTime ReleaseYear { get; set; }
        public ICollection<CreateDirectoryDto>? Directors { get; set; } 
        public ICollection<CreateCategoryDto>? Categorydto { get; set; }
    }
}
