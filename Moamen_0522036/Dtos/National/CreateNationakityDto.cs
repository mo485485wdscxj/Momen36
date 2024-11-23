using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.NationalDto
{
    public class CreateNationakityDto
    {
        
        [Required]
        public string? Name { get; set; }=string .Empty;
     }
}
