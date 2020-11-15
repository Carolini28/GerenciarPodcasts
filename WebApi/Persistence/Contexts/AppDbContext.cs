using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;

namespace WebApi.Persistence.Contexts {
	public class AppDbContext : DbContext {
		public DbSet<Episodio> Episodios { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Episodio>().ToTable("Episodios");
		}
	}
}