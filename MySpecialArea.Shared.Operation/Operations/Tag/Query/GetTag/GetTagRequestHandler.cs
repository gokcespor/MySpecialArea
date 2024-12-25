using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Tag.Query.GetTag
{
	public class GetTagRequestHandler : IRequestHandler<GetTagRequest, GetTagResponse>
	{
		public async Task<GetTagResponse> Handle(GetTagRequest request, CancellationToken cancellationToken)
		{
			return new GetTagResponse
			{
				Name = "Teknoloji"
			};
		}
	}
}
