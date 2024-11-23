using Moamen_0522036.Dtos.NationalDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.DirectoryDto
{
    public class CreateDirectoryDto
    {
      
        [Required]
        public string Name { get; set; }= string.Empty;

        [Required, Phone]
        public string Contact { get; set; }=string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        public CreateNationakityDto? Nationality { get; set; } 
        //
 

    }
}
