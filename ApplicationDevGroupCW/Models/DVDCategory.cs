using System.ComponentModel.DataAnnotations;

namespace ApplicationDevGroupCW.Models
{
    public class DVDCategory
    {
        [Key]
        public int CategoryNumber { get; set; } 
        public string CategoryDescription { get; set; }
        public Boolean AgeRestricted { get; set; }
    }
}
