using System.ComponentModel.DataAnnotations;

namespace ApplicationDevGroupCW.Models
{
    public class Producer
    {
        [Key]
        public int ProducerNumner { get; set; } 
        public string? ProducerName { get; set; }
    }
}
