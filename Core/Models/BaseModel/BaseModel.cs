using System.ComponentModel.DataAnnotations;

namespace idflNet.Core.Models.BaseModel
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}