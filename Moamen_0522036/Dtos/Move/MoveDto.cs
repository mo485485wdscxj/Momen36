using Moamen_0522036.Dtos.CategoryDto;
using Moamen_0522036.Dtos.DirectoryDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.MoveDto
{
    public class MoveDto
    {
       
         public string? Title { get; set; }=string.Empty;
         public DateTime ReleaseYear { get; set; } 
        public ICollection<DirectoryDtos>? Directors { get; set; }
        public ICollection<CategoryDtos>? categories { get; set; }

    }
}
