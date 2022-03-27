using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.Entities;
using TalepIstekFormu.WebUI.Models;

namespace TalepIstekFormu.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IFormService _formService;
        private IDepartmentService _departmentService;

        public AdminController(
            IFormService formService
            , IDepartmentService departmentService
            )
        {
            _formService = formService;
            _departmentService = departmentService;
        }
        public ActionResult Index()
        {
            var result = new FormListModel()
            {
                FormLists = _formService.GetAllFormListIncludingEmploy()
            };
            return View(result);
        }
        [HttpPost]
        public ActionResult Create(FormModel model)
        {
            FormModel formModel = new FormModel();
            formModel.Form = new Entities.Form()
            {
                FormId = model.FormId,
                EmployId = model.EmployId,
                TalebinGerceklesecegiSistem = model.TalebinGerceklesecegiSistem,
                TalepNumarasi = model.TalepNumarasi,
                OlusturulmaTarih = Convert.ToDateTime(model.OlusturulmaTarih),
                GuncellemeTarih = Convert.ToDateTime(model.GuncellemeTarih),
                DepartmentName = model.DepartmentName,
                CompanyName = model.CompanyName,
                TalepOzet = model.TalepOzet,
                TalepGerekce = model.TalepGerekce,
                MevcutSistemeEkMi = model.MevcutSistemeEkMi,
                MevcutFonksiyonMu = model.MevcutFonksiyonMu,
                YeniSistemMi = model.YeniSistemMi,
                RaporlamaMi = model.RaporlamaMi,
                TalepKapsamIcerik = model.TalepKapsamIcerik,
                KullaniciGrupKullanimSikligi = model.KullaniciGrupKullanimSikligi,
                HedeflenenFayda = model.HedeflenenFayda,
                GelirArtisiMi = model.GelirArtisiMi,
                MaliyetAzaltmaMi = model.MaliyetAzaltmaMi,
                RegulasyonaUyumMu = model.RegulasyonaUyumMu,
                TakipIzlenebilirlikArtisMi = model.TakipIzlenebilirlikArtisMi,
                DigerMi = model.DigerMi,
                Riskler = model.Riskler,
                RaporlamaGereksinimi = model.RaporlamaGereksinimi,
                CozumBilgileri = model.CozumBilgileri,
                DevreyeAlimTarihi = Convert.ToDateTime(model.DevreyeAlimTarihi),
                FormDurum = (FormDurum)1,
                DepartmentId=1
            };
            _formService.Create(formModel.Form);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Detail(int id)
        {
            List<SelectListItem> deparmentSelectList = (from y in _departmentService.GetAll()
                                                        where y.IsDeleted == false
                                                        select new SelectListItem
                                                        {
                                                            Text = y.DepartmentName,
                                                            Value = y.DepartmentId.ToString()
                                                        }).ToList();
            ViewBag.DeparmentSelectList = deparmentSelectList;
            var deasdas = new FormListModel()
            {
                FormList = _formService.GetByIdFormListIncludingEmploy(id)
            };
            return View(deasdas);
        }
        public ActionResult Edit(int id)
        {
            List<SelectListItem> deparmentSelectList = (from y in _departmentService.GetAll()
                                                        where y.IsDeleted == false
                                                        select new SelectListItem
                                                        {
                                                            Text = y.DepartmentName,
                                                            Value = y.DepartmentId.ToString()
                                                        }).ToList();
            ViewBag.DeparmentSelectList = deparmentSelectList;
            var deasdas = new FormListModel()
            {
                FormList = _formService.GetByIdFormListIncludingEmploy(id)
            };
            return View(deasdas);
        }
        [HttpPost]
        public ActionResult Edit(int id,FormListModel model)
        {
            var getform = _formService.GetById(id);
            getform.GuncellemeTarih = DateTime.Now;
            getform.FormDurum = model.FormList.FormDurum;
            getform.TalepNumarasi = model.FormList.TalepNumarasi;
            getform.BugHataDuzeltmeMi = model.FormList.BugHataDuzeltmeMi;
            getform.KucukDegisklikMi = model.FormList.KucukDegisklikMi;
            getform.DegisklikMi = model.FormList.DegisklikMi;
            getform.BuyukDegisklikProjeMi = model.FormList.BuyukDegisklikProjeMi;
            getform.TalepMaliyeti = model.FormList.TalepMaliyeti;
            getform.EtkilenecekSistemVeriTabanEntegrasyon = model.FormList.EtkilenecekSistemVeriTabanEntegrasyon;
            getform.DisKaynakSecenekveMaliyeti = model.FormList.DisKaynakSecenekveMaliyeti;
            getform.DepartmentId = model.FormList.DepartmentId;
            _formService.Update(getform);
            return RedirectToAction("Index");
        }
    }



}
