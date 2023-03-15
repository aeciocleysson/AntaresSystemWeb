using AntaresSystemWeb.Repository.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AntaresSystemWeb.Repository.Implementations
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity, TContext> where TEntity : BaseModel where TContext : DbContext
    {
        public BaseRepository(TContext context)
        {
            _context = context;
        }

        protected readonly TContext _context;

        public async Task Delete(TEntity model)
        {
            model.Delete();
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> Insert(TEntity model)
        {
            var response = await _context.AddAsync(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<List<TEntity>> Select()
        {
            return await _context.Set<TEntity>().Where(w => w.IsAtivo == true && w.IsDeleted == false).ToListAsync();
        }

        public async Task<TEntity> Select(int id)
        {
            return await _context.Set<TEntity>().Where(w => w.Id == id && w.IsAtivo == true && w.IsDeleted == false).SingleOrDefaultAsync();
        }

        public async Task<TEntity> Update(TEntity model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return model;
        }
    }
}