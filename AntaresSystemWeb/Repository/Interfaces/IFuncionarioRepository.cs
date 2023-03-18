using AntaresSystemWeb.Data.Context;
using Domain.Models;

namespace AntaresSystemWeb.Repository.Interfaces
{
    public interface IFuncionarioRepository : IBaseRepository<Funcionario, AntaresDbContext>
    {
    }
}