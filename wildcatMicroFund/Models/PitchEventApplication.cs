using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class PitchEventApplication
    {
        [Key]
        public int PitchEvAppID { get; set; }
        public int PitchID { get; set; }
        public int UserAppID { get; set; }

        [ForeignKey("PitchID")]
        public virtual PitchEvent? PitchEvent { get; set; }

        [ForeignKey("UserAppID")]
        public virtual UserAssignment? UserAssignment { get; set; }
    }
}
