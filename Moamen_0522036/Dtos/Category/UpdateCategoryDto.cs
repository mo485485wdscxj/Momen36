using Moamen_0522036.Dtos.MoveDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.CategoryDto
{
    public class UpdateCategoryDto
    {
         public int Id { get; set; }
        [Required]
        public string? Name { get; set; }= string.Empty;
      }
}
