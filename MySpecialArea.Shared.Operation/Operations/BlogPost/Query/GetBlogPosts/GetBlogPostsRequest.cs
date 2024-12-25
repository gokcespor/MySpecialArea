using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpecialArea.Shared.Operation.Operations.BlogPost.Query.GetBlogPosts
{
	public class GetBlogPostsRequest : IRequest<List<GetBlogPostsResponse>>
	{
		public string Title { get; set; }
	}
}
