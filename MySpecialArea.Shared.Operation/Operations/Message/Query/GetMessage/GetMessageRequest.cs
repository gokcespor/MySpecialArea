using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Message.Query.GetMessage
{
	public class GetMessageRequest : IRequest<GetMessageResponse>
	{
		public string Title { get; set; }
	}
}
