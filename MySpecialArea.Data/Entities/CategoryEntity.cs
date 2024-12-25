using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Entities
{
	public class CategoryEntity : BaseEntity
	{
		public string Name { get; set; }
		public List<BlogPostEntity> BlogPosts { get; set; }
	}
	public class CategoryEntityConfigration : BaseConfigration<CategoryEntity> // veri tabanı validasyonu
	{
		public void Configure(EntityTypeBuilder<CategoryEntity> builder)
		{
			builder.Property(x => x.Name)
				.IsRequired()
				.HasMaxLength(20);
		}
	}
}
