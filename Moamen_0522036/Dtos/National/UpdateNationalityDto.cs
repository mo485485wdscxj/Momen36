using Moamen_0522036.Dtos.DirectoryDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.NationalDto
{
    public class UpdateNationalityDto
    {
         public int Id { get; set; }
        [Required]
        public string? Name { get; set; }=string.Empty;
     }
}
