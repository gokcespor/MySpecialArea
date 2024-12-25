using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class BlogPostTagEntity : BaseEntity
	{
		public TagEntity Tag { get; set; }
		public int TagId { get; set; }
		public BlogPostEntity BlogPost { get; set; }
		public int BlogPostId { get; set; }
	}
}
