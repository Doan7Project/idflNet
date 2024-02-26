using Core.Models;
using Core.Resutls;
using idflNet.Core.Dtos;

namespace idflNet.auth
{
    public interface IUserService
    {
        AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model);
        IEnumerable<UserModel> GetAll();
        UserModel? GetById(Guid id);
    }
}