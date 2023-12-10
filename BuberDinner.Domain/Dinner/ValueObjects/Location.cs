using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Dinner.ValueObjects;

public class Location : ValueObject
{
    public string Name { get; }
    public string Address { get; }
    public float Latitude { get; }
    public float Longitude { get; }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Address;
        yield return Latitude;
        yield return Longitude;
    }
}
