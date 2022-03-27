using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepIstekFormu.Entities
{
    public class FormList
    {
        public string EmployFullName { get; set; }
        public string EmployName { get; set; }
        public string EmploySurname { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string IlgiliDepartmentName { get; set; }
        public int FormId { get; set; }
        public int EmployId { get; set; }
        public int DepartmentId { get; set; }
        public string TalebinGerceklesecegiSistem { get; set; }
        public string TalepNumarasi { get; set; }
        public DateTime OlusturulmaTarih { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public string TalepOzet { get; set; }
        public string TalepGerekce { get; set; }
        public bool MevcutSistemeEkMi { get; set; }
        public bool MevcutFonksiyonMu { get; set; }
        public bool YeniSistemMi { get; set; }
        public bool RaporlamaMi { get; set; }
        public string TalepKapsamIcerik { get; set; }
        public string KullaniciGrupKullanimSikligi { get; set; }
        public string HedeflenenFayda { get; set; }
        public bool GelirArtisiMi { get; set; }
        public bool MaliyetAzaltmaMi { get; set; }
        public bool RegulasyonaUyumMu { get; set; }
        public bool TakipIzlenebilirlikArtisMi { get; set; }
        public bool DigerMi { get; set; }
        public string RaporlamaGereksinimi { get; set; }
        public string Riskler { get; set; }
        public string CozumBilgileri { get; set; }
        public DateTime DevreyeAlimTarihi { get; set; }
        public FormDurum FormDurum { get; set; }
     
        
        public bool     BugHataDuzeltmeMi              { get; set; } = false;
        public bool     KucukDegisklikMi             { get; set; } = false;
        public bool     DegisklikMi                      { get; set; } = false;
        public bool      BuyukDegisklikProjeMi        { get; set; } = false;
        public string    TalepMaliyeti                   { get; set; }
        public string EtkilenecekSistemVeriTabanEntegrasyon { get; set; }
        public string    DisKaynakSecenekveMaliyeti      { get; set; }

    }
}
