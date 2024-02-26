using Core.Models;
using Core.Resutls;
using idflNet.Constants;
using idflNet.Core.Dtos;
using idflNet.Utils;

namespace idflNet.auth
{

    public class UserService : IUserService
    {
        private readonly IJwtUtils _jwtUtils;

        public UserService(IJwtUtils jwtUtils)
        {
            _jwtUtils = jwtUtils;
        }
        private List<UserModel> _users = new List<UserModel>
        {
            new UserModel { Id = Guid.Parse("b34f8c35-0917-42f7-bb57-e17528b793f2"), Name = "Test", Email = "doanpham@gmail.com", Roles = Role.User, Password = "test123" }
        };
        public AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model)
        {
            var user = _users.SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponseResult(user, token);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _users;
        }

        public UserModel? GetById(Guid id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

    }
}