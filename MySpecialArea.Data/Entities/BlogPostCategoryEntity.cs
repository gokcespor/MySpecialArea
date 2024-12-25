using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class BlogPostCategoryEntity : BaseEntity
	{
		public BlogPostEntity BlogPost { get; set; }
		public int BlogPostId { get; set; }
		public CategoryEntity Category { get; set; }
		public int CategoryId { get; set; }
	}
}
