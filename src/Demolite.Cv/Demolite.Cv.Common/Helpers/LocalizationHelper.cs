using System.Linq.Expressions;

namespace Demolite.Cv.Common.Helpers;

public static class LocalizationHelper
{
	public static string GetLocalizedPropertyValue<T>(this T obj, Expression<Func<T, string>> expression, bool isGerman)
		where T : class
	{
		var propertyName = GetPropertyName(expression);

		if (!isGerman)
			propertyName += "En";
		
		var propertyInfo = obj.GetType().GetProperty(propertyName);
		
		return propertyInfo?.GetValue(obj) as string ?? string.Empty;
	}

	private static string GetPropertyName<T>(Expression<Func<T, string>> expression)
	{
		if (expression.Body is MemberExpression memberExpression)
		{
			return memberExpression.Member.Name;
		}
    
		throw new ArgumentException("Expression must be a member access", nameof(expression));
	}
}