﻿using Cherbetter.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Favorite> GetFavoritesByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Favorite> GetFavoritesByTicketID(int TiceketID)
        {
            throw new NotImplementedException();
        }

    }
}
