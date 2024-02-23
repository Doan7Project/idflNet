using idflNet.Core.Models.BaseModel;

namespace Core.Models
{
    public class UserModel : BaseModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVerified { get; set; }
        public ICollection<UserClientInformationModel> UserClientInformationModels { get; set; }
    }
}