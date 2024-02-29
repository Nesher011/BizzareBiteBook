using System.Data.Common;

namespace BizzareBiteBook.Application.FunctionalTests;

public interface ITestDatabase
{
    Task InitialiseAsync();

    DbConnection GetConnection();

    Task ResetAsync();

    Task DisposeAsync();
}
