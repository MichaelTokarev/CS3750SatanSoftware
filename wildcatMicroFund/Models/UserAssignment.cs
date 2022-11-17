using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wildcatMicroFund.Models
{
    public class UserAssignment
    {
        [Key]
        public int UserAppID { get; set; }
        public int UserAppAssignTypeID { get; set; }
        public int UserID { get; set; }
        public int AppID { get; set; }

        [ForeignKey("UserAppAssignTypeID")]
        public virtual UserAppAssignType? UserAppAssignType { get; set; }

        [ForeignKey("AppID")]
        public virtual Application? Application { get; set; }

        //
        // USER TABLE FK
        //
        //[ForeignKey("FoodTypeId")]
        //public virtual FoodType? FoodType { get; set; }
    }
}
