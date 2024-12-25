using Microsoft.EntityFrameworkCore;
using MySpecialArea.Data.Entities;
using MySpecialArea.Data.Infrastructure;

namespace MySpecialArea.Data.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<BlogPostEntity> BlogPosts => Set<BlogPostEntity>();
		public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
		public DbSet<UserEntity> Users => Set<UserEntity>();
		public DbSet<TagEntity> Tags => Set<TagEntity>();
		public DbSet<MessageEntity> Messages => Set<MessageEntity>();
		public DbSet<BlogPostCategoryEntity> BlogPostsCategories => Set<BlogPostCategoryEntity>();
		public DbSet<BlogPostTagEntity> BlogPostsTags => Set<BlogPostTagEntity>();
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntity).Assembly);
			base.OnModelCreating(modelBuilder);
		}
	} 
}
