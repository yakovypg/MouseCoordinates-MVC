using MouseCoordinates.DataAccess;

namespace MouseCoordinates.Services;

public static class DatabaseConnectionService
{
    static DatabaseConnectionService()
    {
        CoordinatesRepository = new CoordinatesRepository();
    }

    public static ICoordinatesRepository CoordinatesRepository { get; }
}
