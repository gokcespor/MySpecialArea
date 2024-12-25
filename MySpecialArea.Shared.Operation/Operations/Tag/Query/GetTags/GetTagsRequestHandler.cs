using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpecialArea.Shared.Operation.Operations.Tag.Query.GetTags
{
	public class GetTagsRequestHandler : IRequestHandler<GetTagsRequest, List<GetTagsResponse>>
	{
		public async Task<List<GetTagsResponse>> Handle(GetTagsRequest request, CancellationToken cancellationToken)
		{
			var tagList = new List<GetTagsResponse>
			{
				new GetTagsResponse
				{
					Name = "Teknoloji"
				},
				new GetTagsResponse
				{
					Name = "Yazılım"
				}
			};
			return tagList;
		}
	}
}
