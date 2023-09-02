using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLeyer.Entities.User;

namespace TopLearn.DataLeyer.Entities.Order
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DiscountCode { get; set; }

        [Required]
        public int DisCountPercent { get; set; }

        public int? UsableCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<UserDiscountCode> UserDiscountCodes { get; set; }
    }
}
