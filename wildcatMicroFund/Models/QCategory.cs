using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class QCategory
    {
        [Key]
        public int QCategoryType { get; set; }
        [Required]
        [Display(Name = "Question Category")]
        public string QCategoryDesc { get; set; }
    }
}
