using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }

        [Required]
        [Display(Name = "Question Summary")]
        public string? QuestionSummary { get; set; }

        [Required]
        [Display(Name = "Question Extended")]
        public string? QuestionExtended { get; set; }

        [Required]
        [Display(Name = "Active")]
        public bool QuestIsActive { get; set; }
    }
}
