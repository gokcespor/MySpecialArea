using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Tag.Query.GetTag
{
	public class GetTagRequest : IRequest<GetTagResponse>
	{
		public string Name { get; set; }
	}
}
