using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLeyer.Entities.Question;

namespace TopLearn.Core.DTOs.Question
{
    public class ShowQuestionVM
    {
        public TopLearn.DataLeyer.Entities.Question.Question Question { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
