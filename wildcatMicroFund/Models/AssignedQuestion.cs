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
        public int QuestUseID { get; set; }
        public int AppID { get; set; }

        [ForeignKey("QuestUseID")]
        public virtual QuestionUse? QuestionUse { get; set; }

        [ForeignKey("AppID")]
        public virtual Application? Application { get; set; }
    }
}
