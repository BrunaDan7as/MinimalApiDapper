
namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "Default");
        Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "Default");
    }
}