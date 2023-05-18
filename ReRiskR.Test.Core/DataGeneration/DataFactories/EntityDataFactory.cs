using System;
using AutoFixture;
using AutoFixture.DataAnnotations;

namespace ReRiskR.Test.Core.DataGeneration.DataFactories
{
    public class EntityDataFactory<TEntity>
    {
        public virtual TEntity Factory_Entity(Action<TEntity> action = null)
        {
            var fixture = Factory_Fixture();

            var obj = fixture.Create<TEntity>();

            action?.Invoke(obj);

            return obj;
        }


        //Plenty to learn about here from AutoFixture documentation and EISK implementation
        private Fixture Factory_Fixture()
        {
            Fixture fixture = new Fixture();

            fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            fixture.Customize(new NoDataAnnotationsCustomization());
            fixture.Customizations.Add(new RangeAttributeRelay());

            //This is an EISK custom class to be imported
            //fixture.Customizations.Add(new StringAttributeAggregatedRelay());
            return fixture;
        }
    }
}
