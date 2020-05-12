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

        [HttpPost] //idk if this is right or not
        public object AddTicket(Ticket t)
        {
            int result = ticketData.AddTicket(t);

            if (result == 1)
            {
                return new { Success = true, Message = "Ticket Added"};
            }
            else
            {
                return new { Success = false, Message = "Ticket was not added" };
            }
        }

        [HttpPut] //idk if this is right either
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