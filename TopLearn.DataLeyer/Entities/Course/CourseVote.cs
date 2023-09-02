using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLeyer.Entities.Course
{
    public class CourseVote
    {
        [Key]
        public int VoteId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public bool Vote { get; set; }
        public DateTime VoteDate { get; set; } = DateTime.Now;


        #region Relations

        public TopLearn.DataLayer.Entities.Course.Course Course { get; set; }
        public TopLearn.DataLayer.Entities.User.User User { get; set; }

        #endregion
    }
}
