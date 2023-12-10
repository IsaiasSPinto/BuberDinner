using BuberDinner.Domain.User;

namespace BuberDinner.Application.Commom.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    void Add(User user);
}
