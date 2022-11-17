using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace wildcatMicroFund.Models
{
    public class QuestionDetail
    {
        [Key]
        public int QuestionDetailID { get; set; }

        [Required]
        [Display(Name = "Question Detail")]
        public string? QuestionDetailInfo { get; set; }
    }
}
