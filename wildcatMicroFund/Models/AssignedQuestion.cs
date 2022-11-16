using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class AssignedQuestion
    {
        [Key]
        public int AssignedQuestionID { get; set; }
        [Display(Name = "Assigned Question Date")]
        public DateTime AppQuestionDate { get; set; }
        public int QuestID { get; set; }
        public int AppID { get; set; }

        [ForeignKey("QuestID")]
        public virtual Question? Question { get; set; }

        [ForeignKey("AppID")]
        public virtual Application? Application { get; set; }
    }
}
