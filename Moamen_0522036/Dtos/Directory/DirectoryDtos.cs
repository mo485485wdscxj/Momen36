using Moamen_0522036.Dtos.NationalDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace Moamen_0522036.Dtos.DirectoryDto
{
    public class DirectoryDtos
    {
      
     
        public string? Name { get; set; }= string.Empty;

        [Phone]
        public string? Contact { get; set; } = string.Empty;
        [EmailAddress]
        public string? Email { get; set; }=string.Empty;
        public NationalityDto? Nationality { get; set; }
    }
}
