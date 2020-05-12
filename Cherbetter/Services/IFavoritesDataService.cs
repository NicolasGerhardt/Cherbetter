using Cherbetter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cherbetter.Services
{
    public interface IFavoritesDataService
    {
        public IEnumerable<Favorite> GetFavoritesByEmail(string email);
        public IEnumerable<Favorite> GetFavoritesByTicketID(int TiceketID);
    }
}
