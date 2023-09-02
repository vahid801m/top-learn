using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TopLearn.DataLeyer.Entities.Question
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }

        [Required]
        public int QuestionId { get; set; }

        public TopLearn.DataLayer.Entities.User.User User { get; set; }

        public Question Question { get; set; }

        [Required]
        public string BodyAnswer { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }

        public bool IsTrue { get; set; } = false;



    }
}
