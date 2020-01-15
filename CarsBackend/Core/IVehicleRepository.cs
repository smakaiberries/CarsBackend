using CarsBackend.Core.Models;
using CarsBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarsBackend.Core
{
    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void Remove(Vehicle vehicle);
        Task<IEnumerable<Vehicle>> GetVehicles(Filter filter);
    }
}