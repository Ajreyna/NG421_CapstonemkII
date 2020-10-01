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
    [ApiController]
    [Route("[controller]")]
    public class RockerController : ControllerBase
    {
        private ApplicationDbContext _context;

        public RockerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Rocker> Get()
        {
            Rocker[] rockers = null;
            rockers = _context.Rockers.ToArray();
            return rockers;
        }

        [HttpPost]
        public Rocker Post([FromBody]Rocker rocker)
        {
            _context.Rockers.Add(rocker);
             _context.SaveChanges();
             return rocker;
                        
        }    
    }
}
