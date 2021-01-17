using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithGenerics.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}