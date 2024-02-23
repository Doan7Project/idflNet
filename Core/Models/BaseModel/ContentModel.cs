using System.ComponentModel.DataAnnotations;

namespace idflNet.Core.Models.BaseModel
{
    public class ContentModel : BaseModel
    {
        [Required, MinLength(5), MaxLength(100)]
        public string? Name { get; set; }
        [MinLength(5)]
        public string? Description { get; set; }
    }
}