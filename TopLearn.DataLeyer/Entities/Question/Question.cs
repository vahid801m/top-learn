using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLeyer.Entities.Question
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int UserId { get; set; }
        [Display(Name ="عنوان سوال")]
        [MaxLength(300)]
        [Required(ErrorMessage ="لطفا عنوان سوال خود را وارد کنید")]
        public string Title { get; set; }

        [Display(Name ="متن سوال")]
        [Required(ErrorMessage ="لطفا متن سوال را وارد کنید")]
        public string Body { get; set; }

        [Required]
        public DateTime CreateQuestion { get; set; }

        [Required]
        public DateTime ModifiedQuestion { get; set; }

        #region Realtions

        public TopLearn.DataLayer.Entities.Course.Course Course { get; set; }
        public TopLearn.DataLayer.Entities.User.User User { get; set; }
        public List<Answer> Answers { get; set; }

        #endregion


    }
}
