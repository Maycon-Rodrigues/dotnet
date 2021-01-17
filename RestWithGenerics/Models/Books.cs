using System;
using System.ComponentModel.DataAnnotations.Schema;
using RestWithGenerics.Models.Base;

namespace RestWithGenerics.Models
{
  [Table("books")]
  public class Books : BaseEntity
  {
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