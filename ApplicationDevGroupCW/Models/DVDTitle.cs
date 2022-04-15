using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevGroupCW.Models
{
    public class DVDTitle
    {
        [Key]
        public int DVDNumber { get; set; }
        public string? DVDTitleName { get; set; }

        [ForeignKey("ProducerNumber")]
        public Producer? Producer { get; set; }

        [ForeignKey("CategroyNumber")]
        public DVDCategory? DVDCategory { get; set; }

        [ForeignKey("StudioNumber")]
        public Studio? Studio { get; set; }
        public DateTime DateReleased { get; set; }
        public float StandardCharge { get; set; } 
        public float PenaltyCharge { get; set; }
    }
}
