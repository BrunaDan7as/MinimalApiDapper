using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {

        private readonly IConfiguration _configuration;
        // construtor
        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }   

        ///// <summary>
        ///// Carrega dados do banco de dados utilizando uma stored procedure.
        ///// </summary>
        ///// <typeparam name="T">O tipo dos objetos a serem retornados.</typeparam>
        ///// <typeparam name="U">O tipo dos parâmetros da stored procedure.</typeparam>
        ///// <param name="storedProcedure">O nome da stored procedure a ser executada.</param>
        ///// <param name="parameters">Os parâmetros a serem passados para a stored procedure.</param>
        ///// <param name="connectionName">O nome da conexão com o banco de dados (padrão é "Default").</param>
        ///// <returns>Uma coleção de objetos do tipo T.</returns>
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

            return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionName));

            await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
