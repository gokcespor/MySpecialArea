using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Category.Query.GetCategories
{
	public class GetCategoriesRequest : IRequest<List<GetCategoriesResponse>>
	{
		public string Name { get; set; }
	}
}
