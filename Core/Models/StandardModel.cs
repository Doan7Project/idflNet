using Core.Models;
using idflNet.Core.Models.Interfaces;

namespace idflNet.Core.Models
{
    public class StandardModel : ContentModel
    {
        public Guid CategoryId { get; set; }
        public CategoryModel CategoryModel { get; set; }
        public bool IsActive { get; set; }
        public Guid LanguageId { get; set; }
        public LanguageModel LanguageModel { get; set; }
        public Guid MediaId { get; set; }
        public MediaModel MediaModel { get; set; }
    }
}