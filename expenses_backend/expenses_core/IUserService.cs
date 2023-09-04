using expenses_core.DTO;
using expenses_db;

namespace expenses_core;

public interface IUserService
{
    Task<AuthenticatedUser> SignUp(User user);
    Task<AuthenticatedUser> SignIn(User user);
}