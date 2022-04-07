using System.ComponentModel.DataAnnotations;

namespace ApplicationDevGroupCW.Models
{
    public class MembershipCategory
    {
        [Key]
        public int MembershipCategoryNumber { get; set; }
        public string MembershipCategoryDescription { get; set; }
        public float MembershipCategoryTotalLoans { get; set; }
    }
}
