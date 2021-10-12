using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Entities
{
    public class Post : BaseEntity
    {        
        public string Topic { get; set; }
        public string Message { get; set; }
    }
}
