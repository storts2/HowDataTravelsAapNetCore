using Microsoft.EntityFrameworkCore;
using MVC_CRUD_WithDb.Models;

namespace MVC_CRUD_WithDb.Context;

public class SchoolDbContext : DbContext
{
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

    DbSet<Student> Students { get; set; }
}
