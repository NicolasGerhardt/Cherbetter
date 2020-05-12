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
    public class TicketDataService : ITicketDataService
    {
        private readonly string connString;

        public TicketDataService(IConfiguration config)
        {
            connString = config.GetConnectionString("default");
        }

        public int AddTicket(Ticket ticket)
        {
            int result = 0;

            using (var conn = new SqlConnection(connString))
            {
                string command = "INSERT INTO Tickets (Title, TDescription, TStatus, Resolution) ";
                command += "VALUES (@Title, @TDescription, @TStatus, @Resolution)";

                result = conn.Execute(command, ticket);
            }

            return result;
        }

        public int DeleteTicketByID(int id)
        {
            //DELETE FROM Tickets WHERE TID=@id;

            int result = 0;

            using (var conn = new SqlConnection(connString))
            {
                string command = "DELETE FROM Tickets WHERE TID=@id";

                result = conn.Execute(command, new { id });
            }

            return result;
        }

        public Ticket GetTicketByID(int id)
        {
            Ticket result;

            using (var conn = new SqlConnection(connString))
            {
                string command = "select * from Tickets where TID = @id";

                result = conn.QueryFirstOrDefault<Ticket>(command, new { id });
            }

            return result;
        }

        public IEnumerable<Ticket> GetTicketsAll()
        {
            IEnumerable<Ticket> result;

            using (var conn = new SqlConnection(connString))
            {
                string command = "select * from Tickets";

                result = conn.Query<Ticket>(command);
            }

            return result;
        }

        public int UpdateTicket(Ticket ticket)
        {
            int result = 0;

            using (var conn = new SqlConnection(connString))
            {
                string command = "UPDATE Tickets ";
                command += "SET Title = @Title, TDescription =  @TDescription, TStatus = @TStatus, Resolution = @Resolution ";
                command += "WHERE TID = @TID";

                result = conn.Execute(command, ticket);
            }

            return result;
        }
    }
}
