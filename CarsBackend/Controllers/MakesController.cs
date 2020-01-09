using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsBackend.Models;
using CarsBackend.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        VegaDbContext context;

        public MakesController(VegaDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await this.context.Makes.Include(m => m.Models).ToListAsync();
        }

        [HttpGet("/api/vehicles/features")]
        public async Task<IEnumerable<Features>> GetFeatures()
        {
            return await this.context.Features.ToListAsync();
        }
    }
}