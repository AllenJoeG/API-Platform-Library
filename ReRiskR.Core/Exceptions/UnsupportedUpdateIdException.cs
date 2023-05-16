using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReRiskR.Core.Exceptions
{
    public class UnsupportedUpdateIdException<TEntity> : DomainException<TEntity>
    {
        public UnsupportedUpdateIdException(object paramValue, string paramName = "id") : 
            base(
                $"Can not update {typeof(TEntity).Name} field: {paramName} with provided value: {paramValue}.. Unsupported action.",
                "APP-DATA-ERROR-004"
            )
        {

        }
    }
}
