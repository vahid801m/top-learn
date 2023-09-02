using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Entities.Course;


namespace TopLearn.Web.Pages.Admin.Courses
{
    public class EditCourseModel : PageModel
    {
        private ICourseService _courseService;

        public EditCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }
        public void OnGet(int id)
        {
            Course = _courseService.GetCourseById(id); // کدوم کورس

            var groups = _courseService.GetGroupForManageCourse(); // گروپ ها رو میاره
            ViewData["Groups"] = new SelectList(groups, "Value", "Text", Course.GroupId); // ویودیتا گروپ رو اینجا پر میکنه
            List<SelectListItem> subgroups=new List<SelectListItem>()
            {
                new SelectListItem() // یه حالت اضافه میکنه در حالتی ک چیزی نباشه
                {
                    Text="انتخاب کنید", Value=""
                }
            };
            subgroups.AddRange(_courseService.GetSubGroupForManageCourse(Course.GroupId)); // این رو باز چک کنم 
            string selectedSubGroups = null;
            if(Course.SubGroup != null)
            {
                selectedSubGroups = Course.SubGroup.ToString();
            }
            ViewData["SubGroups"] = new SelectList(subgroups, "Value", "Text", selectedSubGroups);

            var teachers = _courseService.GetTeachers();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text", Course.TeacherId);

            var levels = _courseService.GetLevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text", Course.LevelId);

            var statues = _courseService.GetStatues();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text", Course.StatusId);

        }

        public IActionResult OnPost(IFormFile imgCourseUp, IFormFile demoUp)
        {
            if (!ModelState.IsValid)
                return Page();

            _courseService.UpdateCourse(Course, imgCourseUp, demoUp);

            return RedirectToPage("Index");
        }
    }
}