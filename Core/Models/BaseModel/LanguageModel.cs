using Core.Models;

namespace idflNet.Core.Models.BaseModel
{
    public class LanguageModel : BaseModel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool IsActive { get; set; }
        public ICollection<PageMetaDataModel> PageMetaDataModels { get; set; }
    }
}