using Moamen_0522036.Dtos.MoveDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.CategoryDto
{
    public class CreateCategoryDto
    {
       
        [Required]
        public string Name { get; set; } = string.Empty;
      }
}
