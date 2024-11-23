using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moamen_0522036.Models
{
    public class NationalityModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [ForeignKey("DirectorModel")]
        public int? DirectorModelId {  get; set; }
        public DirectorModel? Director { get; set; } 
    }
}
