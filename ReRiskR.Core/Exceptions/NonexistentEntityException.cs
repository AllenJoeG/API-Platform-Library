namespace ReRiskR.Core.Exceptions
{
    public class NonexistentEntityException<TEntity> : DomainException<TEntity>
    {
        public NonexistentEntityException(object paramValue, string paramName = "id") : 
            base(
                $"No {typeof(TEntity).Name} exists for provided id {paramValue} and parameter {paramName}.",
                "APP-DATA-ERROR-002"
            ) 
        { 
        
        }
    }
}
