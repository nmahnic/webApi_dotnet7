using System;
using System.Net.Http;
using MagicVilla.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa{Id = 1, VillaName = "Vista a la playa"},
                new Villa{Id = 2, VillaName = "Vista a la pileta"}
            };
        }
    }
}