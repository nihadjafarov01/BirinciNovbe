using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Helpers
{
    public class SqlHelper
    {
        const string _connectionString = @"Server = DESKTOP-41FVTKL\SQLEXPRESS; Database = AzMB101_Nihad; Trusted_Connection=True;";
        
        public static async Task<DataTable> GetDatas(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            DataTable dt = new DataTable();
            using SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            sda.Fill(dt);
            connection.Close();
            return dt;
        }

        public static async Task<int> Exec(string query)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new SqlCommand(query, connection);
            int result = await command.ExecuteNonQueryAsync();
            await connection.CloseAsync();
            return result;

        }
    }
}
