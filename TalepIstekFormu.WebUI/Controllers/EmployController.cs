using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.WebUI.Models;

namespace TalepIstekFormu.WebUI.Controllers
{
    public class EmployController : Controller
    {
        private IEmployService _employService;
        private ICompanyService _companyService;
        private IDepartmentService _departmentService;

        public EmployController(
              IEmployService employService
            , ICompanyService companyService
            , IDepartmentService departmentService
            )
        {
            _employService = employService;
            _companyService = companyService;
            _departmentService = departmentService;
        }
        public ActionResult Index()
        {
            return View(new EmployListModel()
            {
                EmployLists = _employService.GetAllEmployList()
            });
        }
        public ActionResult Create()
        {
            List<SelectListItem> commpanySelectList = (from x in _companyService.GetAll()
                                                       where x.IsDeleted == false
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CompanyName,
                                                           Value = x.CompanyId.ToString()
                                                       }).ToList();
            List<SelectListItem> deparmentSelectList = (from y in _departmentService.GetAll()
                                                        where y.IsDeleted == false
                                                        select new SelectListItem
                                                        {
                                                            Text = y.DepartmentName,
                                                            Value = y.DepartmentId.ToString()
                                                        }).ToList();
            ViewBag.CommpanySelectList = commpanySelectList;
            ViewBag.DeparmentSelectList = deparmentSelectList;
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployModel employModel = new EmployModel();
                    employModel.Employ = new Entities.Employ { 
                    EmployName =model.Employ.EmployName,
                    EmploySurname =model.Employ.EmploySurname,
                    CompanyId =model.Employ.CompanyId,
                    DepartmentId =model.Employ.DepartmentId
                   
                    };
                    _employService.Create(employModel.Employ);
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
            ViewBag.CommpanySelectList = _companyService.GetAll();
            ViewBag.DeparmentSelectList = _departmentService.GetAll();
            return View(new EmployModel() { 
            Employ = _employService.GetById(id)
            });
        }
        [HttpPost]
        public ActionResult Edit(EmployModel model)
        {
            try
            {
                var entity = _employService.GetById(model.Employ.EmployId);
                entity.EmployName = model.Employ.EmployName;
                entity.EmploySurname = model.Employ.EmploySurname;
                entity.DepartmentId = model.Employ.DepartmentId;
                entity.CompanyId = model.Employ.CompanyId;
                _employService.Update(entity);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var entity = _employService.GetById(id);
            entity.IsDeleted = true;
            _employService.Update(entity);
            return RedirectToAction("Index");
        }
    }
}
