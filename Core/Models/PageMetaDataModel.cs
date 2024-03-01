using idflNet.Core.Models.Interfaces;

namespace idflNet.Core.Models
{
    public class PageMetaDataModel : BaseInterface
    {
        public string? Key { get; set; }
        public string? Session { get; set; }
        public string? Field { get; set; }
        public string? Value { get; set; }
        public Guid LanguageId { get; set; }
        public LanguageModel LanguageModel { get; set; }
    }
}