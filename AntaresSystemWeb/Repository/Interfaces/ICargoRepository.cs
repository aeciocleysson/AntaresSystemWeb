using AntaresLibary.Models;
using AntaresSystemWeb.Data.Context;

namespace AntaresSystemWeb.Repository.Interfaces
{
    public interface ICargoRepository : IBaseRepository<Cargo, AntaresDbContext>
    {
    }
}
