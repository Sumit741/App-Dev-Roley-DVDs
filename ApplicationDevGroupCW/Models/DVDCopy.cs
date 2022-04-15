using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevGroupCW.Models
{
    public class DVDCopy
    {
        [Key]
        public int CopyNumber { get; set; }

        [ForeignKey("DVDNumber")]
        public DVDTitle? DVDTitle { get; set; }

        public DateTime DatePurchased { get; set; }
    }
}
