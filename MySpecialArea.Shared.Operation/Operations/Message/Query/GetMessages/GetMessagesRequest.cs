using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.Message.Query.GetMessages
{
	public class GetMessagesRequest : IRequest<List<GetMessagesResponse>>
	{
	}
}
