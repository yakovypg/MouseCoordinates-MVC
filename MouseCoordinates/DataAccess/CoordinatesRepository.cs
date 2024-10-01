using MouseCoordinates.Models;

namespace MouseCoordinates.DataAccess;

public class CoordinatesRepository : ICoordinatesRepository
{
    public async Task AddAsync(CoordinatesViewModel coordinates)
    {
        ArgumentNullException.ThrowIfNull(coordinates, nameof(coordinates));

        using var db = new ApplicationContext();
        db.Coordinates.Add(coordinates);

        await db.SaveChangesAsync().ConfigureAwait(false);
    }
}
