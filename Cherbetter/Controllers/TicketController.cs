using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cherbetter.Models;
using Cherbetter.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Cherbetter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        private readonly ITicketDataService ticketData;

        public TicketController(ITicketDataService ticketData)
        {
            this.ticketData = ticketData;
        }

        [HttpGet]
        public IEnumerable<Ticket> GetTicketsAll()
        {
            return ticketData.GetTicketsAll();
        }

        [HttpGet("{id}")]
        public Ticket GetTicketByID(int id)
        {
            return ticketData.GetTicketByID(id);
        }
        
        [HttpDelete("{id}")]
        public string DeleteTicketByID(int id)
        {
            int result = ticketData.DeleteTicketByID(id);

            if (result == 1)
            {
                return "Delete worked correctly";
            }
            else
            {
                return "Delete did not go through";
            }
        }

        [HttpPost("{ticket/new}")] //idk if this is right or not
        public string AddTicket(Ticket t)
        {
            int result = ticketData.AddTicket(t);

            if (result == 1)
            {
                return "Ticket added";
            }
            else
            {
                return "Something went wrong, ticket not added";
            }
        }

        [HttpPost("{ticket/edit}")] //idk if this is right either
        public string UpdateTicket(Ticket t)
        {
            int result = ticketData.UpdateTicket(t);

            if (result == 1)
            {
                return "Ticket updated";
            }
            else
            {
                return "Something went wrong, ticket did not update";
            }
        }
    }
}