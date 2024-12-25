using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPost
{
	public class GetBlogPostRequestHandler : IRequestHandler<GetBlogPostRequest, GetBlogPostResponse>
	{
		public async Task<GetBlogPostResponse> Handle(GetBlogPostRequest request, CancellationToken cancellationToken)
		{
			return new GetBlogPostResponse
			{
				Title = "Yapay Zeka"
			};
		}
	}
}
