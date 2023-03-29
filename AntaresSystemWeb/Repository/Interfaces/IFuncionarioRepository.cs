using AntaresLibary.Models;
using AntaresSystemWeb.Data.Context;

namespace AntaresSystemWeb.Repository.Interfaces
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario, AntaresDbContext>
    {
    }
}