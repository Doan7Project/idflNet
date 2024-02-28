using Core.Models;
using Core.Resutls;
using idflNet.Constants;
using idflNet.Core.Dtos;
using idflNet.Data;
using idflNet.Repository;

namespace Services
{
    public class UserService : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IJwtUtilRepository _jwtUtils;

        public UserService(IJwtUtilRepository jwtUtils, ApplicationDbContext context)
        {
            _jwtUtils = jwtUtils;
            _context = context;
        }
        public AuthenticateResponseResult? Authenticate(AuthenticateRequestDto model)
        {
            var user = _context.User.SingleOrDefault(x => x.Email == model.Email && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtUtils.GenerateJwtToken(user);

            return new AuthenticateResponseResult(user, token);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _context.User.ToList();
        }

        public UserModel? GetById(Guid id)
        {
            return _context.User.FirstOrDefault(x => x.Id == id);
        }
    }
}