using AntaresSystemWeb.Data.Context;
using AntaresSystemWeb.Repository.Interfaces;
using Domain.Models;

namespace AntaresSystemWeb.Repository.Implementations
{
    public class FuncionarioRepository : BaseRepository<Funcionario, AntaresDbContext>, IFuncionarioRepository
    {
        public FuncionarioRepository(AntaresDbContext context) : base(context)
        {
        }
    }
}
