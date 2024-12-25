using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MySpecialArea.Data.Infrastructure
{
	public class BaseConfigration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
	{
		public void Configure(EntityTypeBuilder<TEntity> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.CreatedDate)
				.IsRequired();
		}
	}
}
