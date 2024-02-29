using idflNet.Core.Models.Interfaces;

namespace idflNet.Core.Models
{
    public class CategoryModel : ContentModel
    {
        public string? Thumbnail { get; set; }
        public Guid LanguageId { get; set; }
        public bool IsActive { get; set; }
        public LanguageModel LanguageModel { get; set; }
        public ICollection<StandardModel> StandardModels { get; set; }
    }
}