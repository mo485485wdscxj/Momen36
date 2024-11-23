using Moamen_0522036.Dtos.MoveDto;
using Moamen_0522036.Dtos.NationalDto;
using Moamen_0522036.Models;
using System.ComponentModel.DataAnnotations;

namespace Moamen_0522036.Dtos.DirectoryDto
{
    public class UpdateDirectoryDto
    {
         public int Id { get; set; }
        [Required]
        public string? Name { get; set; }=string.Empty;

        [Required, Phone]
        public string? Contact { get; set; }=string.Empty;
        [Required, EmailAddress]
        public string? Email { get; set; }=string.Empty;
        public ICollection<UpdateMoveDto>? Movies { get; set; }  
        public UpdateNationalityDto? updateNationalitydto { get; set; }  
     }
}
