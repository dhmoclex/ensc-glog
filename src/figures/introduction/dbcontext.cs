using Microsoft.EntityFrameworkCore;
using MvcUniversity.Models;

namespace MvcUniversity.Data;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;

    public string DbPath { get; private set; }

    public UniversityContext() {
        DbPath = "MvcUniversity.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        options.UseSqlite($"Data Source={DbPath}");
    }
}
