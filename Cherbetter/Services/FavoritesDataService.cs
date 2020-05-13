using Cherbetter.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cherbetter.Services
{
    public class FavoritesDataService : IFavoritesDataService
    {
        private readonly string connString;

        public FavoritesDataService(IConfiguration config)
        {
            connString = config.GetConnectionString("default");
        }

        public int AddFavorite(Favorite favorite)
        {
            int result = 0;

            using (var conn = new SqlConnection(connString))
            {
                string command = "insert into Favorites (Email, TicketID) ";
                command += "VALUES (@Email, @TicketID)";

                result = conn.Execute(command, favorite);
            }

            return result;
        }

        public int DeleteFavorite(Favorite favorite)
        {
            int result = 0;

            using (var conn = new SqlConnection(connString))
            {
                string command = "delete from Favorites ";
                command += "where email like @Email and TicketID = @TicketID ";

                result = conn.Execute(command, favorite);
            }

            return result;
        }

        public IEnumerable<Favorite> GetFavoritesByEmail(string email)
        {
            IEnumerable<Favorite> result;

            using (var conn = new SqlConnection(connString))
            {
                string command = "select * from Favorites where email = @email";

                result = conn.Query<Favorite>(command, new { email });
            }

            return result;
        }

        public IEnumerable<Favorite> GetFavoritesByTicketID(int TicketID)
        {
            IEnumerable<Favorite> result;

            using (var conn = new SqlConnection(connString))
            {
                string command = "select * from Favorites where TicketID = @TicketID";

                result = conn.Query<Favorite>(command, new { TicketID });
            }

            return result;
        }
    }
}
