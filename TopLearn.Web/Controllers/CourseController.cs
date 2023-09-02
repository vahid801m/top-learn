﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharpCompress.Archives;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLeyer.Entities.Course;

namespace TopLearn.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        private IOrderService _orderService;
        private IUserService _userService;
        public CourseController(ICourseService courseService, IOrderService orderService, IUserService userService)
        {
            _courseService = courseService;
            _orderService = orderService;
            _userService = userService;
        }

        public IActionResult Index(int pageId = 1, string filter = ""
            , string getType = "all", string orderByType = "date",
            int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        {
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _courseService.GetAllGroup();
            ViewBag.pageId = pageId;
            return View(_courseService.GetCourse(pageId, filter, getType, orderByType, startPrice, endPrice, selectedGroups, 9));
        }

       


        [Route("ShowCourse/{id}")]
        public IActionResult ShowCourse(int id, int episodeId = 0)
        {
            var course = _courseService.GetCourseForShow(id);
            if (course == null)
            {
                return NotFound();
            }

            if (episodeId != 0 && User.Identity.IsAuthenticated)
            {
                if (course.CourseEpisodes.All(e => e.EpisodeId != episodeId))
                {
                    return NotFound();
                }

                if (!course.CourseEpisodes.First(e => e.EpisodeId == episodeId).IsFree)
                {
                    if (!_orderService.IsUserInCourse(User.Identity.Name, id))
                    {
                        return NotFound();
                    }
                }

                var ep = course.CourseEpisodes.First(e => e.EpisodeId == episodeId);
                ViewBag.Episode = ep;
                string filePath = "";
                string checkFilePath = "";
                if (ep.IsFree)
                {
                    filePath = "/courseOnline/" + ep.EpisodeFileName.Replace(".rar", ".mp4");
                    checkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseOnline",
                        ep.EpisodeFileName.Replace(".rar", ".mp4"));
                }
                else
                {
                    filePath = "/CourseFilesOnline/" + ep.EpisodeFileName.Replace(".rar", ".mp4");
                    checkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFilesOnline",
                        ep.EpisodeFileName.Replace(".rar", ".mp4"));
                }


                if (!System.IO.File.Exists(checkFilePath))
                {
                    string targetPath = Directory.GetCurrentDirectory();
                    if (ep.IsFree)
                    {
                        targetPath = System.IO.Path.Combine(targetPath, "wwwroot/courseOnline");
                    }
                    else
                    {
                        targetPath = System.IO.Path.Combine(targetPath, "wwwroot/CourseFilesOnline");
                    }

                    string rarPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles",ep.EpisodeFileName);
                    var archive = ArchiveFactory.Open(rarPath);

                    var Entries = archive.Entries.OrderBy(x => x.Key.Length);
                    foreach (var en in Entries)
                    {
                        if (Path.GetExtension(en.Key) == ".mp4")
                        {
                            en.WriteTo(System.IO.File.Create(Path.Combine(targetPath, ep.EpisodeFileName.Replace(".rar", ".mp4"))));
                        }   
                    }
                }

                ViewBag.filePath = filePath;
            }

            return View(course);
        }

        [Authorize]
        public IActionResult BuyCourse(int id)
        {
            int orderId = _orderService.AddOrder(User.Identity.Name,id );
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }
        [Route("DownloadFile/{episodeId}")]
        public IActionResult DownloadFile(int episodeId)
        {
            var episode = _courseService.GetEpisodeById(episodeId);
            string fileName = episode.EpisodeFileName;
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles", fileName);
            
            if (episode.IsFree)
            {
                byte[] file = System.IO.File.ReadAllBytes(filePath);
                return File(file, "application/force-download", fileName);
            }
            if (User.Identity.IsAuthenticated)
            {
                if (_orderService.IsUserInCourse(User.Identity.Name, episode.CourseId))
                {
                    byte[] file = System.IO.File.ReadAllBytes(filePath);
                    return File(file, "application/force-download", fileName);
                }
            }

            return Forbid();

        }
        [HttpPost]
        public IActionResult CreateComment(CourseComment comment)
        {
            comment.CreateDate = DateTime.Now;
            comment.IsDelete = false;
            comment.UserId = _userService.GetUserIdByUsername(User.Identity.Name);
            _courseService.AddComment(comment);

            return View("ShowComment", _courseService.GetCourseComment(comment.CourseId));
        }
        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_courseService.GetCourseComment(id, pageId));
        }
        public IActionResult CourseVote(int id)
        {
            if (!_courseService.IsFree(id))
            {
                if (!_orderService.IsUserInCourse(User.Identity.Name, id))
                {
                    ViewBag.NotAccess = true;
                }
            }
            return PartialView(_courseService.GetCourseVote(id));
        }

        [Authorize]
        public IActionResult AddVote(int id, bool vote)
        {
            _courseService.AddVote(_userService.GetUserIdByUsername(User.Identity.Name), id, vote);

            return PartialView("CourseVote", _courseService.GetCourseVote(id));
        }
    }
}