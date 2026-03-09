using Microsoft.EntityFrameworkCore;
using ZenBlogServer.Domain.Entities;

namespace ZenBlogServer.Persistence.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<ContactInfo> Contacts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Blog> Blogs    { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Social> Socials    { get; set; }

}
