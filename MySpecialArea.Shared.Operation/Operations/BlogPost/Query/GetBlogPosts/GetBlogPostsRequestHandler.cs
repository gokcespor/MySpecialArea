using MediatR;

namespace MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPosts
{
	public class GetBlogPostsRequestHandler : IRequestHandler<GetBlogPostsRequest, List<GetBlogPostsResponse>>
	{
		public async Task<List<GetBlogPostsResponse>> Handle(GetBlogPostsRequest request, CancellationToken cancellationToken)
		{
			var blogPostList = new List<GetBlogPostsResponse>
			{
				new GetBlogPostsResponse
				{
					Title = "Yapay Zeka",
					PictureUrl = "image.jpeg"
				}
			};
			return blogPostList;
		}
	}
}
