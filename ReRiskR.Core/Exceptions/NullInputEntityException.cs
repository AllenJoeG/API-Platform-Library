namespace ReRiskR.Core.Exceptions
{
    public class NullInputEntityException<TEntity> : DomainException<TEntity>
    {
        public NullInputEntityException() :
            base(
                "Null Object provided for create/update",
                "APP-DATA-ERROR-003"
            )
        { 
        
        }
    }
}
