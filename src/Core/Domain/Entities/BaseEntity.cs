using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
