using Microsoft.Data.SqlClient;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    internal class MessageController
    {
        SqlConnection _connection;

        public MessageController(SqlConnection sqlcon)
        {
            this._connection = sqlcon;
        }

        public List<Message> Get(int id)
        {

            SqlCommand com = new SqlCommand($"exec getMessages @chat = {id};"), _connection);
            SqlDataReader reader = _connection.ExecuteReader();

            return null;
        }
    }
}
