using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    public class FavoritesController : ControllerBase
    {

        private readonly IFavoritesDataService favoritesData;

        public FavoritesController(IFavoritesDataService favoritesData)
        {
            this.favoritesData = favoritesData;
        }


        /// <summary>
        /// Return all of the favorites for a specific email
        /// </summary>
        [HttpGet("email/{email}")]
        public IEnumerable<Favorite> GetFavoritesByID(string email)
        {
            return this.favoritesData.GetFavoritesByEmail(email);
        }

        /// <summary>
        /// Return all of the favorites for a specific ticket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IEnumerable<Favorite> GetFavoritesByID(int id)
        {
            return this.favoritesData.GetFavoritesByTicketID(id);
        }

        /// <summary>
        /// Add a favorite to a ticket
        /// </summary>
        [HttpPost]
        public object PostFavorite(Favorite favorite)
        {
            int result = favoritesData.AddFavorite(favorite);

            if (result == 1)
            {
                return new { success = true };
            }

            return new { success = false, message = "Something went wrong" };
        }


        [HttpDelete]
        public object DeleteFavorite(Favorite favorite)
        {
            int result = favoritesData.DeleteFavorite(favorite);

            if (result == 1)
            {
                return new { success = true };
            }

            return new { success = false, message = "Something went wrong" };
        }

    }
}