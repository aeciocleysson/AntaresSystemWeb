using AntaresLibary.Models;
using Microsoft.EntityFrameworkCore;

namespace AntaresSystemWeb.Repository.Interfaces
{
    public interface IBaseRepository<TEntity, TContext> where TEntity : BaseModel where TContext : DbContext
    {
        Task<TEntity> Insert(TEntity model);

        Task<TEntity> Update(TEntity model);

        Task Delete(TEntity model);

        Task<List<TEntity>> Select();

        Task<TEntity> Select(int id);
    }
}
