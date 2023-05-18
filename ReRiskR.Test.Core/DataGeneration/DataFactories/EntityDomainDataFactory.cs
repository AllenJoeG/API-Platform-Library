using System;

namespace ReRiskR.Test.Core.DataGeneration.DataFactories
{
    public abstract class EntityDomainDataFactory<TEntity> : EntityDataFactory<TEntity>
    {
        protected abstract void AssignDomainData(TEntity e);

        public override TEntity Factory_Entity(Action<TEntity> action = null)
        {
            var entity = base.Factory_Entity(e =>
            {
                AssignDomainData(e);

                //EISK documentation suggests this supports custom
                //overrides from user. I do not understand!
                action?.Invoke(e);
            });

            return entity;
        }
    }
}
