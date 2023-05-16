namespace ReRiskR.Core.Exceptions
{
    public class InvalidLookupIdParameterException<TEntity> : DomainException<TEntity>
    {
        //Provide base message and error code
        public InvalidLookupIdParameterException(string paramId = "id") : 
            base(
                $"Invalid lookup parameter: {paramId} does not find {typeof(TEntity).Name}.",
                "APP-DATA-ERROR-001"
            )
        {

        }
    }
}
