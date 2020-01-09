using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarsBackend.Controllers.Resources;
using CarsBackend.Models;
using CarsBackend.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace CarsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        VegaDbContext context;
        IMapper mapper;

        public VehiclesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost()]
        public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            // ha pl névnek számot ad meg akkor modelstate az hamis
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);

            vehicle.LastUpdate = DateTime.Now;

            context.Vehicles.Add(vehicle);
            context.SaveChanges();

            var result = mapper.Map<Vehicle, VehicleResource>(vehicle);

            return Ok(result);
        }
    }
}