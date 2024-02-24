using idflNet.Core.Models.BaseModel;

namespace Core.Models
{
    public class PageMetaDataModel : BaseModel
    {
        public string? Key { get; set; }
        public string? Session { get; set; }
        public string? Field { get; set; }
        public string? Value { get; set; }
        public Guid LanguageId { get; set; }
        public LanguageModel LanguageModel { get; set; }
    }
}