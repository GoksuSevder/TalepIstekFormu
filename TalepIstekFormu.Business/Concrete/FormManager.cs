using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TalepIstekFormu.Business.Abstract;
using TalepIstekFormu.DataAccess.Abstract;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.Business.Concrete
{
    public class FormManager : IFormService
    {
        private readonly IFormDal _dal;
        private readonly IEmployDal _employdal;
        private readonly ICompanyDal _companydal;
        private readonly IDepartmentDal _departmentdal;

        public FormManager(
            IFormDal dal,
            IEmployDal employDal,
            ICompanyDal companydal,
            IDepartmentDal departmentdal
            )
        {
            _dal = dal;
            _employdal = employDal;
            _companydal = companydal;
            _departmentdal = departmentdal;
        }
        public Form Create(Form entity)
        {
            return _dal.Create(entity);
        }

        public void Delete(Form entity)
        {
            _dal.Delete(entity);
        }

        public List<Form> GetAll(Expression<Func<Form, bool>> filter = null)
        {
            return _dal.GetAll(filter).ToList();
        }

        public List<FormList> GetAllFormListIncludingEmploy()
        {
            var query = (from form in _dal.GetAll().ToList()
                         join employ in _employdal.GetAll() on form.EmployId equals employ.EmployId
                         join department in _departmentdal.GetAll().ToList() on employ.DepartmentId equals department.DepartmentId
                         join company in _companydal.GetAll().ToList() on employ.CompanyId equals company.CompanyId
                         join formdepartman in _departmentdal.GetAll().ToList() on form.DepartmentId equals formdepartman.DepartmentId
                         select new
                         {
                             EmployName = employ.EmployName,
                             EmploySurname = employ.EmploySurname,
                             CompanyName = company.CompanyName,
                             DepartmentName = department.DepartmentName,
                             FormId = form.FormId,
                             EmployId = form.EmployId,
                             TalebinGerceklesecegiSistem = form.TalebinGerceklesecegiSistem,
                             TalepNumarasi = form.TalepNumarasi,
                             OlusturulmaTarih = form.OlusturulmaTarih,
                             GuncellemeTarih = form.GuncellemeTarih,
                             TalepOzet = form.TalepOzet,
                             TalepGerekce = form.TalepGerekce,
                             MevcutSistemeEkMi = form.MevcutSistemeEkMi,
                             MevcutFonksiyonMu = form.MevcutFonksiyonMu,
                             YeniSistemMi = form.YeniSistemMi,
                             RaporlamaMi = form.RaporlamaMi,
                             TalepKapsamIcerik = form.TalepKapsamIcerik,
                             KullaniciGrupKullanimSikligi = form.KullaniciGrupKullanimSikligi,
                             HedeflenenFayda = form.HedeflenenFayda,
                             GelirArtisiMi = form.GelirArtisiMi,
                             MaliyetAzaltmaMi = form.MaliyetAzaltmaMi,
                             RegulasyonaUyumMu = form.RegulasyonaUyumMu,
                             TakipIzlenebilirlikArtisMi = form.TakipIzlenebilirlikArtisMi,
                             DigerMi = form.DigerMi,
                             RaporlamaGereksinimi = form.RaporlamaGereksinimi,
                             Riskler = form.Riskler,
                             CozumBilgileri = form.CozumBilgileri,
                             DevreyeAlimTarihi = form.DevreyeAlimTarihi,
                             FormDurum = form.FormDurum,

                             BugHataDuzeltmeMi = form.BugHataDuzeltmeMi,
                             KucukDegisklikMi = form.KucukDegisklikMi,
                             DegisklikMi = form.DegisklikMi,
                             BuyukDegisklikProjeMi = form.BuyukDegisklikProjeMi,
                             TalepMaliyeti = form.TalepMaliyeti,

                             EtkilenecekSistemVeriTabanEntegrasyon = form.EtkilenecekSistemVeriTabanEntegrasyon,
                             DisKaynakSecenekveMaliyeti = form.DisKaynakSecenekveMaliyeti,
                             IlgiliDepartmentName = formdepartman.DepartmentName,
                             DepartmentId = form.DepartmentId
                         }).ToList();
            List<FormList> formlist = new List<FormList>();
            foreach (var item in query)
            {
                FormList forms = new FormList();

                forms.EmployFullName = item.EmployName + " " + item.EmploySurname;
                forms.EmployName = item.EmployName;
                forms.EmploySurname = item.EmploySurname;
                forms.CompanyName = item.CompanyName;
                forms.DepartmentName = item.DepartmentName;
                forms.FormId = item.FormId;
                forms.EmployId = item.EmployId;
                forms.TalebinGerceklesecegiSistem = item.TalebinGerceklesecegiSistem;
                forms.TalepNumarasi = item.TalepNumarasi;
                forms.OlusturulmaTarih = item.OlusturulmaTarih;
                forms.GuncellemeTarih = item.GuncellemeTarih;
                forms.TalepOzet = item.TalepOzet;
                forms.TalepGerekce = item.TalepGerekce;
                forms.MevcutSistemeEkMi = item.MevcutSistemeEkMi;
                forms.MevcutFonksiyonMu = item.MevcutFonksiyonMu;
                forms.YeniSistemMi = item.YeniSistemMi;
                forms.RaporlamaMi = item.RaporlamaMi;
                forms.TalepKapsamIcerik = item.TalepKapsamIcerik;
                forms.KullaniciGrupKullanimSikligi = item.KullaniciGrupKullanimSikligi;
                forms.HedeflenenFayda = item.HedeflenenFayda;
                forms.GelirArtisiMi = item.GelirArtisiMi;
                forms.MaliyetAzaltmaMi = item.MaliyetAzaltmaMi;
                forms.RegulasyonaUyumMu = item.RegulasyonaUyumMu;
                forms.TakipIzlenebilirlikArtisMi = item.TakipIzlenebilirlikArtisMi;
                forms.DigerMi = item.DigerMi;
                forms.RaporlamaGereksinimi = item.RaporlamaGereksinimi;
                forms.Riskler = item.Riskler;
                forms.CozumBilgileri = item.CozumBilgileri;
                forms.DevreyeAlimTarihi = item.DevreyeAlimTarihi;
                forms.FormDurum = item.FormDurum;

                forms.BugHataDuzeltmeMi = item.BugHataDuzeltmeMi;
                forms.KucukDegisklikMi = item.KucukDegisklikMi;
                forms.DegisklikMi = item.DegisklikMi;
                forms.BuyukDegisklikProjeMi = item.BuyukDegisklikProjeMi;
                forms.TalepMaliyeti = item.TalepMaliyeti;
                forms.EtkilenecekSistemVeriTabanEntegrasyon = item.EtkilenecekSistemVeriTabanEntegrasyon;
                forms.DisKaynakSecenekveMaliyeti = item.DisKaynakSecenekveMaliyeti;
                forms.IlgiliDepartmentName = item.IlgiliDepartmentName;
                forms.DepartmentId = (int)item.DepartmentId;
                formlist.Add(forms);
            };
            return formlist;
        }

        public Form GetById(int id)
        {
            return _dal.GetById(id);
        }

        public FormList GetByIdFormListIncludingEmploy(int id)
        {
            var getform = GetAllFormListIncludingEmploy();
            var item = getform.Find(x => x.FormId == id);
            FormList result = new FormList();

            result.EmployFullName = item.EmployName + " " + item.EmploySurname;
            result.EmployName = item.EmployName;
            result.EmploySurname = item.EmploySurname;
            result.CompanyName = item.CompanyName;
            result.DepartmentName = item.DepartmentName;
            result.FormId = item.FormId;
            result.EmployId = item.EmployId;
            result.TalebinGerceklesecegiSistem = item.TalebinGerceklesecegiSistem;
            result.TalepNumarasi = item.TalepNumarasi;
            result.OlusturulmaTarih = DateTime.Parse(item.OlusturulmaTarih.ToShortDateString());
            result.GuncellemeTarih = DateTime.Parse(item.GuncellemeTarih.ToShortDateString());
            result.TalepOzet = item.TalepOzet;
            result.TalepGerekce = item.TalepGerekce;
            result.MevcutSistemeEkMi = item.MevcutSistemeEkMi;
            result.MevcutFonksiyonMu = item.MevcutFonksiyonMu;
            result.YeniSistemMi = item.YeniSistemMi;
            result.RaporlamaMi = item.RaporlamaMi;
            result.TalepKapsamIcerik = item.TalepKapsamIcerik;
            result.KullaniciGrupKullanimSikligi = item.KullaniciGrupKullanimSikligi;
            result.HedeflenenFayda = item.HedeflenenFayda;
            result.GelirArtisiMi = item.GelirArtisiMi;
            result.MaliyetAzaltmaMi = item.MaliyetAzaltmaMi;
            result.RegulasyonaUyumMu = item.RegulasyonaUyumMu;
            result.TakipIzlenebilirlikArtisMi = item.TakipIzlenebilirlikArtisMi;
            result.DigerMi = item.DigerMi;
            result.RaporlamaGereksinimi = item.RaporlamaGereksinimi;
            result.Riskler = item.Riskler;
            result.CozumBilgileri = item.CozumBilgileri;
            result.DevreyeAlimTarihi = DateTime.Parse(item.DevreyeAlimTarihi.ToShortDateString());
            result.FormDurum = item.FormDurum;


            result.BugHataDuzeltmeMi = item.BugHataDuzeltmeMi;
            result.KucukDegisklikMi = item.KucukDegisklikMi;
            result.DegisklikMi = item.DegisklikMi;
            result.BuyukDegisklikProjeMi = item.BuyukDegisklikProjeMi;
            result.TalepMaliyeti = item.TalepMaliyeti;
            result.EtkilenecekSistemVeriTabanEntegrasyon = item.EtkilenecekSistemVeriTabanEntegrasyon;
            result.DisKaynakSecenekveMaliyeti = item.DisKaynakSecenekveMaliyeti;
            result.DepartmentId = item.DepartmentId;
            result.IlgiliDepartmentName = item.IlgiliDepartmentName;

            return result;
        }

        public Form GetOne(Expression<Func<Form, bool>> filter)
        {
            return _dal.GetOne(filter);
        }

        public Form Update(Form entity)
        {
            return _dal.Update(entity);
        }
    }
}
