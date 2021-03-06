using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevGroupCW.Models
{
    public class Loan
    {
        [Key]
        public int LoanNumber { get; set; }

        [ForeignKey("LoanTypeNumber")]
        public LoanType? LoanType { get; set; }

        [ForeignKey("CopyNumber")]
        public DVDCopy? DVDCopy { get; set; }

        [ForeignKey("MemberNumber")]
        public Member? Member { get; set; }

        public DateTime DateOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }  

    }
}
