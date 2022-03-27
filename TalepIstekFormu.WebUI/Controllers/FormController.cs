using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.WebUI.Models;

namespace TalepIstekFormu.WebUI.Controllers
{
    public class FormController : Controller
    {
        readonly IFormService _formService;
        public FormController(IFormService formService)
        {
            _formService = formService;
        }
        public ActionResult Index()
        {
            FormListModel formlistmodel = new FormListModel();
            FormModel formmodel = new FormModel();
            var getform = _formService.GetAll();
            foreach (var item in getform)
            {
                item.CompanyName = formmodel.CompanyName;

                //formlistmodel.FormList.Add(formmodel);
            }

            return View(formlistmodel);
        }
    }
}