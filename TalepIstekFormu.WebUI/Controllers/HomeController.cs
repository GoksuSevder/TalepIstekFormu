using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.WebUI.Models;

namespace TalepIstekFormu.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IFormService _formService;
        private IEmployService _employService;
        private ICompanyService _companyService;
        private IDepartmentService _departmentService;

        public HomeController(
            IFormService formService,
            IEmployService employService,
            ICompanyService companyService,
            IDepartmentService departmentService
            )
        {
            _formService = formService;
            _employService = employService;
            _companyService = companyService;
            _departmentService = departmentService;
        }
        public ActionResult Index()
        {
            FormModel model = new FormModel();
            model.EmployLists = _employService.GetAllEmployList();
            return View(model);
        }
        [HttpPost]
        public ActionResult GetEmploy(int id)
        {
            var employ = _employService.GetAllEmployList().Find(x => x.EmployId == id && x.IsDeleted == false);
            var getemploy = _employService.GetById(id);
            
            EmployModel data = new EmployModel();
            data.EmployId = employ.EmployId;
            data.EmployName = employ.EmployName;
            data.EmploySurname = employ.EmploySurname;
            data.CompanyName = employ.CompanyName;
            data.DepartmentName = employ.DepartmentName;
            data.CompanyId = getemploy.CompanyId;
            data.DepartmentId = getemploy.DepartmentId;

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    
    }
}