using System.ComponentModel.DataAnnotations;

namespace idflNet.Core.Models.Interfaces
{
    public class BaseInterface
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}