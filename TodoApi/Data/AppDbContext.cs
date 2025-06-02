// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
// This code defines the AppDbContext class, which inherits from DbContext.
// It includes a constructor that takes DbContextOptions<AppDbContext> as a parameter,
// and it defines a DbSet<Todo> property named Todos. This property allows you to query and save Todo entities in the database.
// The DbSet<Todo> property is used to interact with the Todo entities in the database.
// The AppDbContext class is typically used in conjunction with Entity Framework Core to manage database operations.
// The DbSet<Todo> property is used to interact with the Todo entities in the database.