using Core.Models;

namespace idflNet.Utils
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(UserModel user);
        public Guid? ValidateJwtToken(string? token);
    }
}