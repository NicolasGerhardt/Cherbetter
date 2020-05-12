using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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



        
    }
}