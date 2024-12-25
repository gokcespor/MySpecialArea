using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class UserEntity : BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateOnly BirthDate { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string UserName { get; set; }
		public List<MessageEntity> Messages { get; set; }
		public List<BlogPostEntity> BlogPosts { get; set; }
	}
	public class UserConfigration : BaseConfigration<UserEntity>
	{
		public void Configure(EntityTypeBuilder<UserEntity> builder)
		{
			builder.Property(x => x.FirstName)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(x => x.LastName)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(x => x.BirthDate)
				.IsRequired();
			builder.Property(x => x.Email)
				.IsRequired();
			builder.Property(x => x.Password)
				.IsRequired();
			builder.Property(x => x.UserName)
				.IsRequired()
				.HasMaxLength(20);
			builder.HasMany(x => x.BlogPosts)
				.WithOne(x => x.Author)
				.HasForeignKey(x => x.AuthorId)
				.OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(x => x.Messages)
				.WithOne(m => m.User)
				.HasForeignKey(m => m.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
