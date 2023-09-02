using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using TopLearn.Core.DTOs.Course;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Pages.Admin.Courses
{
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<ShowCourseForAdminViewModel> ListCourse { get; set; }

        public void OnGet(int courseId, string filtercourse = "", int pageId = 1)
        {
            //var course = _courseService.GetCourseById(courseId);
            //if (course != null)
            //{
            //    //if (course.CourseImageName == "Defult.jpg")
            //    //{
            //    //    new ShowCourseForAdminViewModel()
            //    //    {
            //    //        CourseId = courseId,
            //    //        CurrentPage = pageId,
            //    //        ImageName = course.CourseImageName
            //    //    };

            //    //};

            //}

            ListCourse = _courseService.GetCoursesForAdmin(filtercourse, pageId);
        }

    }
}
