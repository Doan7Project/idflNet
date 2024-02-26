using Core.Models;
using Core.Resutls;
using idflNet.Core.Dtos;

namespace idflNet.Repository
{
    public interface IUserRepository
    {
        AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model);
        IEnumerable<UserModel> GetAll();
        UserModel? GetById(Guid id);
    }
}