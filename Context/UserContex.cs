using Microsoft.EntityFrameworkCore;
using Users.Entities;

namespace Users.Contexts;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UserContext(DbContextOptions options)
        : base(options)
    {
        Users = Set<User>();
    }
}
