using CleanArchDemo.Domain.Models;
using CleanArchDemo.Infrastructure.Seeds;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new VillaSeed());
    }

    public DbSet<Villa> Villas { get; set; }
}
