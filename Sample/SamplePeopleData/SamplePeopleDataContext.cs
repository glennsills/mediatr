using Microsoft.EntityFrameworkCore;
using Sample.Data.Entities;

namespace Sample.Data;
public class SamplePeopleDataContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public string DbPath { get; private set; }

    public SamplePeopleDataContext(DbContextOptions<SamplePeopleDataContext> context)
    {
        var myContext = context;
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "SampleData.db");
    }
    SamplePeopleDataContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "SampleData.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");
}
