using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class Response
    {
        [Key]
        public int ResponseID { get; set; }
        
        [Required]
        [Display(Name = "Response")]
        public string? Responses { get; set; }

        public int AssignedQuestionID { get; set; }

        [ForeignKey("AssignedQuestionID")]
        public virtual AssignedQuestion? AssignedQuestion { get; set; }
    }
}
