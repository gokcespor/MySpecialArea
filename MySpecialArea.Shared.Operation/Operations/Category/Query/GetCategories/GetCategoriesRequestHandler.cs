using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Category.Query.GetCategories
{
	public class GetCategoriesRequestHandler : IRequestHandler<GetCategoriesRequest, List<GetCategoriesResponse>>
	{
		public async Task<List<GetCategoriesResponse>> Handle(GetCategoriesRequest request, CancellationToken cancellationToken)
		{
			var categoryList = new List<GetCategoriesResponse>
			{
				new GetCategoriesResponse
				{
					Name = "Bilim"
				},
				new GetCategoriesResponse
				{
					Name = "Matematik"
				}
			}.ToList();
			return categoryList;
		}
	}
}
