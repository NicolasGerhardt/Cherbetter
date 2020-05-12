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
        public object DeleteTicketByID(int id)
        {
            int result = ticketData.DeleteTicketByID(id);

            if (result == 1)
            {
                return new { Success = true, Message = "Delete worked correctly" };
            }
            else
            {
                return new { Success = true, Message = "Delete did not go through" };
            }
        }

        [HttpPost]
        public object AddTicket(Ticket t)
        {
            int result = ticketData.AddTicket(t);

            if (result == 1)
            {
                return new { Success = true, Message = "Ticket Added" };
            }
            else
            {
                return new { Success = false, Message = "Ticket was not added" };
            }
        }

        [HttpPut]
        public object UpdateTicket(Ticket t)
        {

            int result = ticketData.UpdateTicket(t);

            if (result == 1)
            {
                return new { Success = true, Message = "Ticket updated" };
            }
            else
            {
                return new { Success = true, Message = "Something went wrong, ticket did not update" };
            }
        }
    }
}