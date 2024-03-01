using Core.Resutls;
using idflNet.Core.Dtos;
using idflNet.Core.Models;

namespace idflNet.Repository
{
    public interface IUserRepository
    {
        AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model);
        IEnumerable<UserModel> GetAll();
        UserModel? GetById(Guid id);
    }
}