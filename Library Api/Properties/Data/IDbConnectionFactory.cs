using System.Data;
namespace Library_Api.Properties.Data;
public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateConnectionAsync();
}