using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.DataLeyer.Entities.Order
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int OrderSum { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public bool IsFinaly { get; set; }


        #region  Relations

        public virtual TopLearn.DataLayer.Entities.User.User User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
