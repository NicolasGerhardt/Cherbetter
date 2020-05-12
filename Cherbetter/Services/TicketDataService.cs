using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
    }
}
