using Cherbetter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cherbetter.Services
{
    public interface ITicketDataService
    {
        public IEnumerable<Ticket> GetTicketsAll();
        public int AddTicket(Ticket Ticket);
        public int DeleteTicketByID(int id);
        public Ticket GetTicketByID(int id);
        public int UpdateTicket(Ticket ticket);
    }
}
