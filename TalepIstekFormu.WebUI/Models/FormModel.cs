using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TalepIstekFormu.Entities;

namespace TalepIstekFormu.WebUI.Models
{
    public class FormModel
    {
        public int FormId { get; set; }
        public int EmployId { get; set; }
        public virtual EmployModel Employ { get; set; }

        public string TalebinGerceklesecegiSistem { get; set; } = "";

        public string TalepNumarasi { get; set; } = "";

        public DateTime OlusturulmaTarih { get; set; }

        public DateTime GuncellemeTarih { get; set; }


        public string DepartmentName { get; set; } = "";


        public string CompanyName { get; set; } = "";

        public string TalepOzet { get; set; } = "";

        public string TalepGerekce { get; set; } = "";

        public bool MevcutSistemeEkMi { get; set; } = false;

        public bool MevcutFonksiyonMu { get; set; } = false;

        public bool YeniSistemMi { get; set; } = false;

        public bool RaporlamaMi { get; set; } = false;

        public string TalepKapsamIcerik { get; set; } = "";

        public string KullaniciGrupKullanimSikligi { get; set; }

        public string HedeflenenFayda { get; set; } = "";

        public bool GelirArtisiMi { get; set; } = false;
        public bool MaliyetAzaltmaMi { get; set; } = false;
        public bool RegulasyonaUyumMu { get; set; } = false;
        public bool TakipIzlenebilirlikArtisMi { get; set; } = false;
        public bool DigerMi { get; set; } = false;
        public string RaporlamaGereksinimi { get; set; }
        public string Riskler { get; set; } = "";

        public string CozumBilgileri { get; set; } = "";

        public DateTime DevreyeAlimTarihi { get; set; }
        public FormDurum FormDurum { get; set; }

        public bool BugHataDuzeltmeMi { get; set; } = false;
        public bool KucukDegisklikMi { get; set; } = false;
        public bool DegisklikMi { get; set; } = false;
        public bool BuyukDegisklikProjeMi { get; set; } = false;
        public string TalepMaliyeti { get; set; }
        public string EtkilenecekSistemVeriTabanEntegrasyon { get; set; }
        public string DisKaynakSecenekveMaliyeti { get; set; }

        public List<EmployList> EmployLists { get; set; }
        public FormList FormList { get; set; }
        public Form Form { get; set; }
    }
}