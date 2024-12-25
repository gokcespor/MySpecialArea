using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.User.Query.GetUsers
{
	public class GetUsersRequestHandler : IRequestHandler<GetUsersRequest, List<GetUsersResponse>>
	{
		public async Task<List<GetUsersResponse>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
		{
			var userList = new List<GetUsersResponse> {

				new GetUsersResponse
				{
					UserName = "Pikachu",
					FirstName = "Cihan",
					LastName = "Alagöz",
					Email = "pikachu@mail.com"
				},
				new GetUsersResponse
				{
					UserName = "Pikachu",
					FirstName = "Cihan",
					LastName = "Alagöz",
					Email = "pikachu@mail.com"
				}
			};
			return userList;

		}
	}
}
