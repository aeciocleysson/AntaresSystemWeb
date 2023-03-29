using AntaresLibary.Models;
using AntaresSystemWeb.Data.Context;
using AntaresSystemWeb.Repository.Interfaces;

namespace AntaresSystemWeb.Repository.Implementations
{
    public class CargoRepository : BaseRepository<Cargo, AntaresDbContext>, ICargoRepository
    {
        public CargoRepository(AntaresDbContext context) : base(context)
        {
        }
    }
}
