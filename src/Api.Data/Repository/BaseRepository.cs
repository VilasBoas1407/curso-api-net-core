using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly MyContext _context;
        private DbSet<T> _dataSet;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataSet = context.Set<T>();
        }
            
        public async Task<bool> DeleteAsync(Guid Id)
        {
            try
            {
                bool ret = true;
                var result = await _dataSet
                    .SingleOrDefaultAsync(p => p.Id.Equals(Id));

                if (result == null)
                    return ret;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();

                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if(item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                item.CreateAt = DateTime.UtcNow;
                _dataSet.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public Task<T> SelectAsync(Guid id)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<T>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataSet
                    .SingleOrDefaultAsync(p => p.Id.Equals(item.Id));

                if (result == null)
                    return null;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }
    }
}
