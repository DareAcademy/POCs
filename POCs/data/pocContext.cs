using Microsoft.EntityFrameworkCore;
namespace POCs.data
{
	public class pocContext:DbContext
	{
		public DbSet<Course_Sections> course_Sections { get; set; }
		public DbSet<Course_days> course_days { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("data source=localhost;initial catalog=POCs;integrated security=true");
			base.OnConfiguring(optionsBuilder);

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course_days>().HasKey(xyz => new { xyz.Section_Id, xyz.day});
			base.OnModelCreating(modelBuilder);
		}
	}
}
