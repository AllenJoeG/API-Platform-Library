using ReRiskR.Core.DataService;
using ReRiskR.Core.Exceptions;
using ReRiskR.Core.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReRiskR.Core.DomainService
{
    public class DomainService<TDomain, TId> where TDomain : class, new()
    {
        readonly IEntityDataService<TDomain> _entityDataService;

        public DomainService(IEntityDataService<TDomain> entityDataService)
        {
            _entityDataService = entityDataService;
        }

        public virtual async Task<IEnumerable<TDomain>> GetAll()
        {
            return await _entityDataService.GetAll();
        }

        public virtual async Task<TDomain> GetById(TId id)
        {
            if (id.IsNullOrEmpty())
            {
                ThrowExceptionForInvalidLookupIdParameter();
            }

            var DbEntity = await _entityDataService.GetById(id);

            if (DbEntity == null)
            {
                ThrowExceptionForNonexistentEntity(id);
            }

            return DbEntity;
        }

        //Revisit to understand interplay between these Add methods
        public virtual async Task<TDomain> Add(TDomain entity)
        {
            return await Add(entity, null);
        }
        //Extends Add()
        public virtual async Task<TDomain> Add(TDomain entity, Action<TDomain> preProcessAction, Action<TDomain> postProcessAction = null)
        {
            if (entity == null) { ThrowExceptionForNullInputEntity(); }

            preProcessAction?.Invoke(entity);

            var taskResult = await _entityDataService.Add(entity);

            postProcessAction?.Invoke(taskResult);

            return taskResult;
        }

        //Revisit interplay between these two partials
        public virtual async Task<TDomain> Update(TId id, TDomain newEntity)
        {
            return await Update(id, newEntity, null);
        }
        //Extends Update()
        public virtual async Task<TDomain> Update(TId id, TDomain newEntity, Action<TDomain, TDomain> preProcessAction, Action<TDomain> postProcessAction = null)
        {
            if (newEntity == null) { ThrowExceptionForNullInputEntity(); }

            var oldEntity = await GetById(id);

            preProcessAction?.Invoke(oldEntity, newEntity);

            var taskResult = await _entityDataService.Update(newEntity);

            postProcessAction?.Invoke(taskResult);

            return taskResult;
        }

        public virtual async Task Delete(TId id)
        {
            var DbEntity = await GetById(id);

            await _entityDataService.Delete(DbEntity);
        }

        //
        //Helper Functions to throw Core Exceptions
        protected virtual void ThrowExceptionForInvalidLookupIdParameter()
        {
            throw new InvalidLookupIdParameterException<TDomain>();
        }

        protected virtual void ThrowExceptionForNullInputEntity()
        {
            throw new NullInputEntityException<TDomain>();
        }

        protected virtual void ThrowExceptionForNonexistentEntity(TId id)
        {
            throw new NonexistentEntityException<TDomain>(id);
        }
    }
}
