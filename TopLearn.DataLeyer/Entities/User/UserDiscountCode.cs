using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLeyer.Entities.Order;

namespace TopLearn.DataLeyer.Entities.User
{
    public class UserDiscountCode
    {
        [Key]
        public int UC_Id { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }


        public TopLearn.DataLayer.Entities.User.User User { get; set; }
        public Discount Discount { get; set; }
    }
}
