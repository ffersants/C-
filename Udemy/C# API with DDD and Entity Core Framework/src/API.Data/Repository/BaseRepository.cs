using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data.Context;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            bool deleted = false;
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id == id);
                if (result == null) return deleted;

                _dataset.Remove(result);

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
            return deleted;
        }
        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _dataset.AnyAsync(p => p.Id.Equals(id));
        }
        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }

                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }
        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null) return item;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;

                //busca os valores atuais do item resgatado e atualiza eles
                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
