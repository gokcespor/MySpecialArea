using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class MessageEntity : BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public BlogPostEntity BlogPost { get; set; }
		public int BlogPostId { get; set; }
		public UserEntity User { get; set; }
		public int UserId { get; set; }
	}
	public class MessageEntityConfigration : BaseConfigration<MessageEntity>
	{
		public void Configure(EntityTypeBuilder<MessageEntity> builder)
		{
			builder.Property(x => x.Title)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(x => x.Description)
				.IsRequired();
			builder.HasOne(x => x.BlogPost)
				.WithMany(x => x.Messages)
				.HasForeignKey(x => x.BlogPostId)
				.IsRequired();
			builder.HasOne(x => x.User)
				.WithMany(u => u.Messages)
				.HasForeignKey(x => x.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
