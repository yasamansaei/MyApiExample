using Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Role : BaseEntity 
    {
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }=String.Empty;
        [StringLength(100)]
        [Required]
        public string? Description { get; set; }

    }
}