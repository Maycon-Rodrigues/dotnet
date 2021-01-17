using System;
using Microsoft.EntityFrameworkCore;

namespace RestWithGenerics.Models.Context
{
  public class MySQLContext : DbContext
  {
    public MySQLContext() { }

    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){ }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Books> Books { get; set; }
  }
}