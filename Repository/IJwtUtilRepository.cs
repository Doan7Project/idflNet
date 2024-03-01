using Core.Models;
using idflNet.Core.Models;

namespace idflNet.Repository
{
    public interface IJwtUtilRepository
    {
        public string GenerateJwtToken(UserModel user);
        public Guid? ValidateJwtToken(string? token);
    }
}