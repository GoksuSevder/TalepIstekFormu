using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.WebUI.Models;

namespace TalepIstekFormu.WebUI.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public ActionResult Index()
        {
            return View(new DepartmentListModel()
            {
                Departments = _departmentService.GetAll(x => x.IsDeleted == false)
            });

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    DepartmentModel departmentModel = new DepartmentModel();
                    departmentModel.GetDepartment = new Entities.Department
                    {
                        DepartmentId = model.DepartmentId,
                        DepartmentName = model.DepartmentName
                    };
                    _departmentService.Create(departmentModel.GetDepartment);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(new DepartmentModel()
            {
                GetDepartment = _departmentService.GetById(id)
            });
        }

        [HttpPost]
        public ActionResult Edit(DepartmentModel model)
        {
            try
            {
                DepartmentModel departmentModel = new DepartmentModel();
                departmentModel.GetDepartment = new Entities.Department
                {
                    DepartmentId = model.GetDepartment.DepartmentId,
                    DepartmentName = model.GetDepartment.DepartmentName
                };

                _departmentService.Update(departmentModel.GetDepartment);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                var entity = _departmentService.GetById(id);
                DepartmentModel departmentModel = new DepartmentModel();
                departmentModel.GetDepartment = new Entities.Department
                {
                    DepartmentId = entity.DepartmentId,
                    DepartmentName = entity.DepartmentName,
                    IsDeleted = true
                };

                _departmentService.Update(departmentModel.GetDepartment);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
