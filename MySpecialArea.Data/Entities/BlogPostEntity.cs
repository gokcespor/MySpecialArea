using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class BlogPostEntity : BaseEntity
	{
		public string Title { get; set; }
		public string PictureUrl { get; set; }
		public List<CategoryEntity> Categories { get; set; }
		public List<TagEntity> Tags { get; set; }
		public UserEntity Author { get; set; }
		public int AuthorId { get; set; }
		public List<MessageEntity> Messages { get; set; }
	}
	public class BlogPostConfigration : BaseConfigration<BlogPostEntity>
	{
		public void Configure(EntityTypeBuilder<BlogPostEntity> builder)
		{
			builder.Property(x => x.Title)
				.IsRequired()
				.HasMaxLength(200);

			builder.HasMany(x => x.Messages)
				.WithOne(b => b.BlogPost)
				.HasForeignKey(m => m.BlogPostId)
				.IsRequired();
		}
	}
}
