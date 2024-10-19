using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq.Expressions;

public static class FilterHelper
{
    public static Expression<Func<T, bool>> BuildPredicate<T>(string filterJson)
    {
        var filters = JsonConvert.DeserializeObject<List<object>>(filterJson);
        var parameter = Expression.Parameter(typeof(T), "x");
        Expression? expression = null;

        for (int i = 0; i < filters.Count; i++)
        {
            if (filters[i] is JArray condition)
            {
                var field = condition[0].ToString();
                var operation = condition[1].ToString();
                var value = condition[2].ToObject<object>();

                var property = Expression.Property(parameter, field);
                var constant = Expression.Constant(value);
                Expression binaryExpression = operation switch
                {
                    "=" => Expression.Equal(property, constant),
                    "contains" => Expression.Call(property, "Contains", null, constant),
                    ">" => Expression.GreaterThan(property, constant),
                    "<" => Expression.LessThan(property, constant),
                    ">=" => Expression.GreaterThanOrEqual(property, constant),
                    "<=" => Expression.LessThanOrEqual(property, constant),
                    _ => throw new NotImplementedException($"Operation {operation} is not supported")
                };

                expression = expression == null ? binaryExpression : Expression.AndAlso(expression, binaryExpression);
            }
        }

        if (expression == null)
            throw new ArgumentException("No valid filters provided.");

        return Expression.Lambda<Func<T, bool>>(expression, parameter);
    }
}
