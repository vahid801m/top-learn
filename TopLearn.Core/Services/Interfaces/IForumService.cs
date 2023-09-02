using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs.Question;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLeyer.Entities.Question;

namespace TopLearn.Core.Services.Interfaces
{
    public interface IForumService
    {

        #region Question

        int AddQuestion(Question question);

        ShowQuestionVM ShowQuestionVM(int questionId);
        #endregion

        #region Answer

        void AddAnswer(Answer answer);
        void IsChangeTrueAnswer(int questionId, int answerId);

        User GetUserByQuestionId(int questionId);
        IEnumerable<Question> GetQuestions(int? courseId, string filter);
        #endregion
    }
}
