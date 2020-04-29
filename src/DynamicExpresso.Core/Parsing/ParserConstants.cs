using System.Linq.Expressions;

namespace DynamicExpresso.Parsing
{
	internal static class ParserConstants
	{
		public static readonly Expression NullLiteralExpression = Expression.Constant(null);

		public const string KeywordAs = "as";
		public const string KeywordIs = "is";
		public const string KeywordNew = "new";
		public const string KeywordTypeof = "typeof";
		public const string KeywordAnd = "and";
		public const string KeywordOr = "or";

		public static readonly string[] ReservedKeywords = {
				KeywordAs,
				KeywordIs,
				KeywordNew,
				KeywordTypeof,
				KeywordAnd,
				KeywordOr
			};
	}
}
