namespace Akeneo.Search
{
	public class PageCriteria : Criteria
	{

		public static PageCriteria For(string page)
		{
			return new PageCriteria
			{
				Operator = Operators.Equal,
				Value = page
			};
		}
	}
}
