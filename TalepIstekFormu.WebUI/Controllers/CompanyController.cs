using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.WebUI.Models;

namespace TalepIstekFormu.WebUI.Controllers
{
    public class CompanyController : Controller
    {
        ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public ActionResult Index()
        {
            return View(new CompanyListModel()
            {
                Companies = _companyService.GetAll(x => x.IsDeleted == false)
            });
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CompanyModel model)
        {
            try
            {
                CompanyModel companyModel = new CompanyModel();
                companyModel.GetCompany = new Entities.Company
                {
                    CompanyId = model.CompanyId,
                    CompanyName =model.CompanyName
                };
                _companyService.Create(companyModel.GetCompany);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return View(new CompanyModel()
            {
                GetCompany = _companyService.GetById(id)
            }) ;
        }
        [HttpPost]
        public ActionResult Edit(CompanyModel model)
        {
            try
            {
                CompanyModel companyModel = new CompanyModel();
                companyModel.GetCompany = new Entities.Company
                {
                    CompanyId = model.GetCompany.CompanyId,
                    CompanyName = model.GetCompany.CompanyName
                };
                _companyService.Update(companyModel.GetCompany);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var model = _companyService.GetById(id);
            CompanyModel companyModel = new CompanyModel();
            companyModel.GetCompany = new Entities.Company
            {
                CompanyId = model.CompanyId,
                CompanyName = model.CompanyName,
                IsDeleted=true
            };
            _companyService.Update(companyModel.GetCompany);
            return RedirectToAction("Index");
            return View();
        }

    }
}
