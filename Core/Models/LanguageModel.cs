using idflNet.Core.Models.Interfaces;

namespace idflNet.Core.Models
{
    public class LanguageModel : BaseInterface
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool IsActive { get; set; }
        public ICollection<PageMetaDataModel> PageMetaDataModels { get; set; }
        public ICollection<CategoryModel> CategoryModels { get; set; }
        public ICollection<StandardModel> StandardModels { get; set; }
    }
}