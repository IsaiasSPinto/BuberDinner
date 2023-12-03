using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Commom.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetByEmail(string email);
    void Add(User user);
}
