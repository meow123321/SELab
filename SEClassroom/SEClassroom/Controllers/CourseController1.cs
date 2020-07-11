using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEClassroom.AppLogic.Data;
using Microsoft.AspNetCore.Authorization;
using SEClassroom.AppLogic.Abstractions;
using SEClassroom.Models;

namespace SEClassroom.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = courseRepository.GetCourse();
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult MessageSend()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Info()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                courseRepository.Add(course);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            var employee = courseRepository.GetCourse(Id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        public IActionResult Edit(Course teacher)
        {
            if (ModelState.IsValid)
            {
                courseRepository.Update(teacher);

                return RedirectToAction(nameof(Index));
            }
            return View(teacher);
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            var employee = courseRepository.GetCourse(Id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid Id)
        {
            courseRepository.Delete(Id);
            return RedirectToAction(nameof(Index));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
