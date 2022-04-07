using System.ComponentModel.DataAnnotations;

namespace ApplicationDevGroupCW.Models
{
    public class Studio
    {
        [Key]
        public int StudioNumber { get; set; }
        public string StudioName { get; set; }
    }
}
