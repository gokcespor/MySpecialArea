using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.User.Query.GetUser
{
	public class GetUserRequest : IRequest<GetUserResponse>
	{
		public string UserName { get; set; }
	}
}
