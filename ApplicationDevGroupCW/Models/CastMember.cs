using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDevGroupCW.Models
{
    [Keyless]
    public class CastMember
    {
        [ForeignKey("DVDNumber")]
        [Column(Order =1)]
        public DVDTitle? DVDTitle { get; set; }

        [ForeignKey("ActorNumber")]
        [Column(Order = 2)]
        public Actor? Actor { get; set; }
      
    }
}
