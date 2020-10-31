using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces.Services.User;
using Domain.Repository;
using System.Threading.Tasks;

namespace Service.Services.User
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> FindByLogin(LoginDTO user)
        {
            var baseUser = new UserEntity();
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                baseUser = await _repository.FindByLogin(user.Email); ;

                if (baseUser == null)
                {
                    return null;
                }
                else
                {
                    return baseUser;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
