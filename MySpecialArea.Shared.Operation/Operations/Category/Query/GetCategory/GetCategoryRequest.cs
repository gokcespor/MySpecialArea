using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Category.Query.GetCategory
{
	public class GetCategoryRequest : IRequest<GetCategoryResponse>
	{
		public string Name { get; set; }
	}
}
