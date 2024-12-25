using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.User.Query.GetUser
{
	public class GetUserRequestHandler : IRequestHandler<GetUserRequest, GetUserResponse>
	{
		public async Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
		{
			//var userEntity = _db.Users.Single(x => x.UserName == request.UserName);
			return new GetUserResponse
			{
				UserName = "Gök",
				FirstName = "Gökçe",
				LastName = "Spor Alagöz",
				Email = "gokce@mail.com"
			};
		}
	}
}
