using System.ComponentModel.DataAnnotations;

namespace wildcatMicroFund.Models
{
    public class UserAppAssignType
    {
        [Key]
        public int UserAppAssignTypeID { get; set; }
        public string? UserAppAssignTypeDesc { get; set; }

    }
}
