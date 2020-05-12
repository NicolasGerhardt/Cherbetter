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
    public class FavoritesController : ControllerBase
    {

        private readonly IFavoritesDataService favoritesData;

        public FavoritesController(IFavoritesDataService favoritesData)
        {
            this.favoritesData = favoritesData;
        }
    }
}