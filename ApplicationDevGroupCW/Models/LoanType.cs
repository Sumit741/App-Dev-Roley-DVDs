using System.ComponentModel.DataAnnotations;

namespace ApplicationDevGroupCW.Models
{
    public class LoanType
    {
        [Key]
        public int LoanTypeNumber { get; set; }
        public string? LoanTypeDescription { get; set; }
        public DateTime LoanDuration { get; set; }    
    }
}
