using BiblioNetAPP.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BiblioNetAPP.Services
{
    public interface IRepositorieBooks
    {
        void Create(Books books);
    }
    public class RepositorieBooks : IRepositorieBooks
    {
        private readonly string connectionString;

        public RepositorieBooks(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public void Create(Books books)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO Books (Name_book, Author, Price) 
                                                 VALUES (@Name_book, @Author, @Price); SELECT SCOPE_IDENTITY();", books);
            books.Id = id;
        }
    }
}
