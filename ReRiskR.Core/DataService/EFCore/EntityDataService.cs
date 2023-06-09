﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReRiskR.Core.DataService.EFCore
{
    public class EntityDataService<TEntity> : IEntityDataService<TEntity> where TEntity : class, new()
    {
        protected readonly DbContext DbContext;

        public EntityDataService(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual async Task<IList<TEntity>> GetAll()
        {
            return await DbContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetById<TId>(TId id)
        {
            //Only queries DB if the id can't be found in the DbContext
            return await DbContext.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            //an EFCore ChangeTracking EntityEntry
            //'Adds' the entity changes to staging for SaveChanges() call
            var obj = DbContext.Add(entity);

            await DbContext.SaveChangesAsync();

            return obj.Entity;
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            //an EFCore ChangeTracking EntityEntry
            //Stages the updates for next SaveChanges() call
            var obj = DbContext.Update(entity);

            await DbContext.SaveChangesAsync();

            return obj.Entity;
        }

        public virtual async Task Delete(TEntity entity)
        {
            DbContext.Remove(entity);
            await DbContext.SaveChangesAsync();

            //Note, doesn't return an EntityEntry
        }
    }
}
