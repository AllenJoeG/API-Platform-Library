using ReRiskR.Core.Exceptions;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ReRiskR.Core.Utils
{
    //Helper Functions for LINQ Expressions
    public static class ExpressionUtil<TDomain>
    {
        public static object GetPropertyValue<TField>(
            Expression<Func<TDomain, TField>> expression, 
            TDomain data)
        {
            if (data == null) { throw new NullInputEntityException<TDomain>(); }

            var property = GetPropertyInfo(expression);
            var value = property.GetValue(data);
            return value;
        }

        public static PropertyInfo GetPropertyInfo<TField>(
            Expression<Func<TDomain, TField>> expression)
        {
            var expressionBody = (MemberExpression)expression.Body;
            return (PropertyInfo)expressionBody.Member;
        }

        public static void SetPropertyValue<TField>(
            Expression<Func<TDomain, TField>> expression, 
            TDomain data, 
            object value)
        {
            if (data == null) { throw new NullInputEntityException<TDomain>() };
            var property = GetPropertyInfo(expression);
            property.SetValue(data, value);
        }
    }
}
