using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.DTOs.Question;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLeyer.Entities.Question;

namespace TopLearn.Core.Services
{
    public class ForumService : IForumService
    {
        private TopLearnContext _context;
        public ForumService(TopLearnContext context)
        {
            _context = context;
        }

        public void AddAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
        }

        public int AddQuestion(Question question)
        {
            question.CreateQuestion = DateTime.Now;
            question.ModifiedQuestion = DateTime.Now;
            _context.Add(question);
            _context.SaveChanges();

            return question.QuestionId;
        }

        public IEnumerable<Question> GetQuestions(int? courseId, string filter = "")
        {
            IQueryable<Question> result = _context.Questions
                .Where(q => EF.Functions.Like(q.Title, $"%{filter}%"));

            if (courseId != null)
            {
                result = result.Where(q => q.CourseId == courseId);
            }

            return result.Include(q => q.Course)
                .Include(q => q.User).ToList();
        }

        public User GetUserByQuestionId(int questionId)
        {
         return _context.Users.Find(questionId);
        }

        public void IsChangeTrueAnswer(int questionId, int answerId)
        {
            var answers = _context.Answers.Where(c => c.QuestionId == questionId);

            foreach (var ans in answers)
            {
                ans.IsTrue=false;

                if(ans.AnswerId == answerId)
                {
                    ans.IsTrue = true;
                }
            }
            _context.Answers.UpdateRange(answers);
            _context.SaveChanges();
        }

        public ShowQuestionVM ShowQuestionVM(int questionId)
        {

            var question = new ShowQuestionVM();
            question.Question = _context.Questions.Include(c => c.User).Where(c => c.QuestionId == questionId).FirstOrDefault();
            question.Answers = _context.Answers.Where(c => c.QuestionId == questionId).Include(c => c.User).ToList();
            return question;

        }
    }
}
