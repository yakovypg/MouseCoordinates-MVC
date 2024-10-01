using MouseCoordinates.Models;

namespace MouseCoordinates.DataAccess;

public interface ICoordinatesRepository
{
    Task AddAsync(CoordinatesViewModel coordinates);
}
