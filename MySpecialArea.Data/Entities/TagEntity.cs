using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class TagEntity : BaseEntity
	{
		public string Name { get; set; }
		public List<BlogPostEntity> BlogPosts { get; set; }
	}
	public class TagEntityConfigration : BaseConfigration<TagEntity>
	{
		public void Configure(EntityTypeBuilder<TagEntity> builder)
		{
			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(10);
		}
	}
}
