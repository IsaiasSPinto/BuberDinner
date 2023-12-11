using BuberDinner.Domain.Menu;

namespace BuberDinner.Application.Commom.Interfaces.Persistence;

public interface IMenuRepository
{
    void Add(Menu menu);
}
