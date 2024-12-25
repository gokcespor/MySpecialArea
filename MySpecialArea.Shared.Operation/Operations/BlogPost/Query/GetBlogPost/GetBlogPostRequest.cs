using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPost
{
	public class GetBlogPostRequest : IRequest<GetBlogPostResponse>
	{
		public string Title { get; set; }
	}
}
