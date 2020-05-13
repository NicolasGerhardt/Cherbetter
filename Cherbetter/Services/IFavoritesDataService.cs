using Cherbetter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cherbetter.Services
{
    public interface IFavoritesDataService
    {
        public int AddFavorite(Favorite favorite);
        public int DeleteFavorite(Favorite favorite);
        public IEnumerable<Favorite> GetFavoritesByEmail(string email);
        public IEnumerable<Favorite> GetFavoritesByTicketID(int TiceketID);
        public int UpdateFavorite(Favorite favorite);
    }
}
