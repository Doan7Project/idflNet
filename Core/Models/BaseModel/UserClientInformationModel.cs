using Core.Models;
using idflNet.Core.Models.BaseModel;

namespace idflNet.Core.Models.BaseModel
{
    public class UserClientInformationModel : ContentModel
    {
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Dob { get; set; }
        public string? CompanyName { get; set; }
        public Guid UserId { get; set; }
        public UserModel UserModel { get; set; }
    }
}