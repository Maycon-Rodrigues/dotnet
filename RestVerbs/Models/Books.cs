using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestVerbs.Models
{
  [Table("books")]
  public class Books
  {
    [Column("id")]
    public string Id { get; set; }

    [Column("author")]
    public string Author { get; set; }

    [Column("launchDate")]
    public DateTime LaunchDate { get; set; }

    [Column("price")]
    public decimal Price { get; set; }

    [Column("title")]
    public string Title { get; set; }
  }
}