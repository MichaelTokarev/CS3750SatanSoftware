using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class Document
    {
        [Key]
        public int DocID { get; set; }
        public int AppID { get; set; }
        [Required]
        [Display(Name = "DocumentFile")]
        public string? DocFile { get; set; }
        public int DocTypeID { get; set; }

        [ForeignKey("DocTypeID")]
        public virtual DocumentType? DocumentType { get; set; }

        [ForeignKey("AppID")]
        public virtual Application? Application { get; set; }
    }
}
