using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class RockerController : ControllerBase
    {
        private readonly ILogger<RockerController> _logger;

        public RockerController(ILogger<RockerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Rocker> Get()
        {
            Rocker[] rockers = null;
            using (var context = new ApplicationDbContext())
            {
                rockers = context.Rockers.ToArray();
            }
            return rockers;
        }

            

        
        
    }
}
