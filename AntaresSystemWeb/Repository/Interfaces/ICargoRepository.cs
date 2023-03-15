using AntaresSystemWeb.Data.Context;
using Domain.Models;

namespace AntaresSystemWeb.Repository.Interfaces
{
    public interface ICargoRepository : IBaseRepository<Cargo, AntaresDbContext>
    {
    }
}
