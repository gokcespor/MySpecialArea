using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Tag.Query.GetTags
{
	public class GetTagsRequest : IRequest<List<GetTagsResponse>>
	{
	}
}
