using SEClassroom.AppLogic.Abstractions;
using SEClassroom.AppLogic.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEClassroom.Controllers
{
    public class TeacherController: Controller
    {
        private readonly ITeacherRepository teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        /*/ Aici modific --------------------------->
        [AllowAnonymous]
        public IActionResult Index()
        {
            var model = teacherRepository.GetTeacherByUserId();
            return View(model);
        }*/

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                teacherRepository.Add(teacher);
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(Guid Id)
        {
            var employee = teacherRepository.GetTeacherByUserId(Id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(Guid Id)
        {
            var employee = teacherRepository.GetTeacherByUserId(Id);
            
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // Vezi si aici ----------------->
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid ID)
        {
            teacherRepository.Delete(ID);
            return RedirectToAction(nameof(Index));
        }
    }
}

