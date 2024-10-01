using Microsoft.EntityFrameworkCore;
using MouseCoordinates.Models;

namespace MouseCoordinates.DataAccess;

public class ApplicationContext : DbContext
{
    private const string _port = "5432";
    private const string _host = "localhost";
    private const string _database = "mousecoordinates";
    private const string _username = "postgres";
    private const string _password = "postgres";

    private const string _databaseConnection =
        $"Host={_host};" +
        $"Port={_port};" +
        $"Database={_database};" +
        $"Username={_username};" +
        $"Password={_password}";

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<CoordinatesViewModel> Coordinates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_databaseConnection);
    }
}
