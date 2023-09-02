using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.DataLeyer.Entities.Order
{
    public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public int Price { get; set; }


        #region Relations
        public Order Order { get; set; }

        public TopLearn.DataLayer.Entities.Course.Course Course { get; set; }

        #endregion
    }
}
