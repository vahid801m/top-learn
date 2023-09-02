using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.DataLeyer.Entities.Course
{
    public  class CourseComment
    {
        [Key]
        public int CommentId { get; set; }

        public int CourseId { get; set; }

        [MaxLength(700)]
        public string  Comment { get; set; }

        public int UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsDelete { get; set; }

        public bool IsAdminRead { get; set; }


        #region Relations

        public TopLearn.DataLayer.Entities.Course.Course Course { get; set; }
        public TopLearn.DataLayer.Entities.User.User User { get; set; }

        #endregion
    }
}
