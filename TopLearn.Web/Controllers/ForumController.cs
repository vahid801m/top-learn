using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLeyer.Entities.Question;
using Ganss.Xss;

namespace TopLearn.Web.Controllers
{
    public class ForumController : Controller
    {
        private IForumService _forumService;
        private ICourseService _courseService;
        private IOrderService _orderService;
        public ForumController(IForumService forumService, ICourseService courseService, IOrderService orderService)
        {
            _forumService = forumService;
            _courseService = courseService;
            _orderService = orderService;
        }

        public IActionResult Index(int courseId, string filter = "")
        {
            var course = _courseService.GetCourseById(courseId);
            ViewBag.CourseId = course;
            return View(_forumService.GetQuestions(courseId, filter));
        }

        #region Create Question

        [Authorize]
        public IActionResult CreateQuestion(int id)
        {
            Question question = new Question()
            {
                CourseId = id
            };
            return View(question);
        }


        [HttpPost]
        public IActionResult CreateQuestion(Question question)
        {
            if (!ModelState.IsValid)
            {
                return View(question);
            }

            question.UserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            int questionId = _forumService.AddQuestion(question);
            return Redirect($"/Forum/ShowQuestion/{questionId}");
        }


        #endregion

        #region Show Question

        public IActionResult ShowQuestion(int id)
        {
            return View(_forumService.ShowQuestionVM(id));
        }

        #endregion

        #region Answer

        public IActionResult Answer(int id, string body)
        {
            if (!string.IsNullOrEmpty(body))
            {
                var sanitizer = new HtmlSanitizer();
                body = sanitizer.Sanitize(body);
                _forumService.AddAnswer(new Answer()
                {
                    BodyAnswer = body,
                    CreateDate = DateTime.Now,
                    UserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString()),
                    QuestionId = id
                });
            }
            return RedirectToAction("ShowQuestion", new { id = id });
        }

        [Authorize]
        public IActionResult SelectIsTrueAnswer(int questionId, int answerId)
        {
            int currentUserId = _forumService.GetUserByQuestionId(questionId).UserId;
            var question = _forumService.ShowQuestionVM(questionId);
            if(question.Question.UserId==currentUserId)
            {
                _forumService.IsChangeTrueAnswer(questionId, answerId);
            }
            return RedirectToAction("ShowQuestion" ,new { id = questionId });
        }
        #endregion
    }
}
