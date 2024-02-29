using System.Text.Json.Serialization;
using idflNet.Constants;
using idflNet.Core.Models.BaseModel;
using idflNet.Core.Models.Interfaces;

namespace idflNet.Core.Models
{
    public class UserModel : BaseInterface
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Role Roles { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVerified { get; set; }
        [JsonIgnore]
        public required string Password { get; set; }
        public ICollection<UserClientInformationModel>? UserClientInformationModels { get; set; }
    }
}