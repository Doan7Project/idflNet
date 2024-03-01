using idflNet.Core.Models;
using idflNet.Core.Models.Interfaces;

namespace Core.Models
{
    public class MediaModel : BaseInterface
    {
        public string? Url { get; set; }
        public ICollection<StandardModel> StandardModels { get; set; }
    }
}