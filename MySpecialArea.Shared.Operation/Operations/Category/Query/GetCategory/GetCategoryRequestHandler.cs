using MediatR;
using MySpecialArea.Shared.Operation.Operations.User.Query.GetUser;

namespace MySpecialArea.Shared.Operation.Operations.Category.Query.GetCategory
{
	public class GetCategoryRequestHandler : IRequestHandler<GetCategoryRequest, GetCategoryResponse>
	{
		public async Task<GetCategoryResponse> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
		{
			return new GetCategoryResponse
			{
				Name = "Bilgisayar"
			};
		}
	}
}
